using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace UI
{
    public partial class QuanLyTang_UC : UserControl
    {

        private static QuanLyTang_UC instance;


        public delegate void SendMessage(Panel Message);
        public SendMessage Sender;
        private Panel pnContaner;
        private void GetMessage(Panel Message)
        {
            pnContaner = Message;
        }

        private BindingSource bingding = new BindingSource();
        private TangService tangService = TangService.Instance;
        private FormatViewServices formatView = FormatViewServices.Instance;
        private List<Button> buttonDeletes = new List<Button>();
        private List<Button> buttonEdits = new List<Button>();

        private int soPhanTuTrang, soTrang, trangHienTai;

        public static QuanLyTang_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuanLyTang_UC();
                return instance;
            }
        }

        public void XacDinhTrang()
        {
            if(tangService.SoTang() % soPhanTuTrang == 0)
                soTrang = tangService.SoTang() / soPhanTuTrang;
            else
                soTrang = tangService.SoTang() / soPhanTuTrang + 1;
            trangHienTai = soTrang;
        }

        public void VeView()
        {
            dtgvTang.Controls.Clear();
            dtgvTang.Controls.Clear();
            dtgvTang.Controls.Clear();
            dtgvTang.Controls.Clear();
            dtgvTang.Controls.Clear();
            buttonEdits.Clear();
            buttonDeletes.Clear();
            int widthDelete = dtgvTang.Width - 125;
            int widthEdit = dtgvTang.Width - 75;
            int i = 0;
            foreach(DataGridViewRow row in dtgvTang.Rows)
            {
                Button buttonDelete = new Button();
                Button buttonEdit = new Button();
                buttonEdit.Size = new Size(30, 30);
                buttonDelete.Size = new Size(30, 30);
                buttonDeletes.Add(buttonDelete);
                buttonEdits.Add(buttonEdit);
                dtgvTang.Controls.Add(buttonEdit);
                dtgvTang.Controls.Add(buttonDelete);
                buttonDelete.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                buttonEdit.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                buttonDelete.Location = new Point(widthDelete, 50 + 36 * i + 3);
                buttonEdit.Location = new Point(widthEdit, 50 + 36 * i + 3);
                buttonDelete.Click += XoaTang;
                buttonEdit.Click += SuaTang;
                i++;
            }

        }

        private void SuaTang(object sender, EventArgs e)
        {
            // Ẩn tất cả button;
            for(int i = 0; i < buttonDeletes.Count; i++)
            {
                buttonDeletes[i].Visible = false;
                buttonEdits[i].Visible = false;
            }
            txtTangThu.Visible = true;
            btnCapNhat.Visible = true;
            btnHuy.Visible = true;
            Button button = (Button)sender;
            int top = button.Top;
            int rowIndex = (top - 3 - 50) / 36;
            XoaChonDtgv();
            dtgvTang.Rows[rowIndex].Selected = true;
            dtgvTang.Controls.Add(txtTangThu);
            dtgvTang.Controls.Add(btnCapNhat);
            dtgvTang.Controls.Add(btnHuy);
            int widthtxtTangThu = dtgvTang.Width - 500 + 10;
            int widthHuy = dtgvTang.Width - 200 + 100 - 80;
            int widthCapNhat = dtgvTang.Width - 200 + 100 + 10;
            int heightTangThu = 50 + 36 * rowIndex + (36 - txtTangThu.Height) / 2;
            int heightButton = 50 + 36 * rowIndex + (36 - btnHuy.Height) / 2;
            txtTangThu.Width = 130;
            dtgvTang.Controls.Add(txtTangThu);
            txtTangThu.Location = new Point(widthtxtTangThu, heightTangThu);
            btnCapNhat.Location = new Point(widthCapNhat, heightButton);
            btnHuy.Location = new Point(widthHuy, heightButton);

            btnCapNhat.Click += CapNhat;
            btnHuy.Click += Huy;

            txtTangThu.Text = dtgvTang.Rows[rowIndex].Cells[2].Value.ToString();
            txtTangThu.KeyPress += txtTangThu_KeyPress;
        }

        private void txtTangThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Huy(object sender, EventArgs e)
        {
            txtTangThu.Visible = false;
            btnCapNhat.Visible = false;
            btnHuy.Visible = false;
            for (int i = 0; i < buttonDeletes.Count; i++)
            {
                buttonDeletes[i].Visible = true;
                buttonEdits[i].Visible = true;
            }
        }

        private void CapNhat(object sender, EventArgs e)
        {
            txtTangThu.Visible = false;
            btnCapNhat.Visible = false;
            btnHuy.Visible = false;
            for (int i = 0; i < buttonDeletes.Count; i++)
            {
                buttonDeletes[i].Visible = true;
                buttonEdits[i].Visible = true;
            }
        }

        private void XoaTang(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int top = button.Top;
            int rowIndex = (top - 3 - 50) / 36;
            XoaChonDtgv();
            dtgvTang.Rows[rowIndex].Selected = true;

        }

        public void XoaChonDtgv()
        {
            foreach(DataGridViewRow row in dtgvTang.Rows)
            {
                row.Selected = false;
            }
        }

        private void dtgvTang_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (trangHienTai == 1)
                return;
            else
            {
                trangHienTai--;
                tangService.HienThiDataGridView(bingding, trangHienTai, soPhanTuTrang);
                VeView();
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai == soTrang)
                return;
            else
            {
                trangHienTai++;
                tangService.HienThiDataGridView(bingding, trangHienTai, soPhanTuTrang);
                VeView();
            }
        }
        

        public QuanLyTang_UC()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            //1 trang tối đa 20 phần tử
            soPhanTuTrang = 15;
            XacDinhTrang();
            formatView.FormatDataGridView(dtgvTang);
            dtgvTang.DataSource = bingding;
            tangService.HienThiDataGridView(bingding , trangHienTai , soPhanTuTrang);

            dtgvTang.Columns.Add("thaoTac", "Thao tác");

            dtgvTang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvTang.Columns[1].Width = 150;
            dtgvTang.Columns[2].Width = 150;
            dtgvTang.Columns[3].Width = 200;

            dtgvTang.Columns[0].HeaderText = "Tên tầng";
            dtgvTang.Columns[1].HeaderText = "Tầng thứ";
            dtgvTang.Columns[2].HeaderText = "Số phòng";

            VeView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemTang f = new ThemTang();
            f.ShowDialog();
            XacDinhTrang();
            tangService.HienThiDataGridView(bingding, trangHienTai, soPhanTuTrang);
            VeView();
        }
    }
}
