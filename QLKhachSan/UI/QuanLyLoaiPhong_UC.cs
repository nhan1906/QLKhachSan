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

namespace UI
{
    public partial class QuanLyLoaiPhong_UC : UserControl
    {

        private LoaiPhongService loaiPhongService = LoaiPhongService.Instance;
        private FormatViewServices formatView = FormatViewServices.Instance;
        private List<Button> buttonXems = new List<Button>();
        private List<Button> buttonSuas = new List<Button>();
        private List<Button> buttonXoas = new List<Button>();

        public QuanLyLoaiPhong_UC()
        {
            InitializeComponent();
            formatView.FormatDataGridView(dtgvLoaiPhong);
            loaiPhongService.HienThiDataGridView(dtgvLoaiPhong);
            dtgvLoaiPhong.Columns.Add("thaoTac", "Thao tác");

            dtgvLoaiPhong.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvLoaiPhong.Columns[0].Width = 100;
            dtgvLoaiPhong.Columns[1].Width = 100;
            dtgvLoaiPhong.Columns[2].Width = 100;
            dtgvLoaiPhong.Columns[3].Width = 120;
            dtgvLoaiPhong.Columns[4].Width = 120;
            dtgvLoaiPhong.Columns[5].Width = 120;
            dtgvLoaiPhong.Columns[6].Width = 100;

            dtgvLoaiPhong.Columns[0].HeaderText = "Mã loại phòng";
            dtgvLoaiPhong.Columns[1].HeaderText = "Tên chất lượng";
            dtgvLoaiPhong.Columns[2].HeaderText = "Tên loại giường";
            dtgvLoaiPhong.Columns[3].HeaderText = "Giá giờ";
            dtgvLoaiPhong.Columns[4].HeaderText = "Giá đêm";
            dtgvLoaiPhong.Columns[5].HeaderText = "Giá ngày";
            dtgvLoaiPhong.Columns[6].HeaderText = "Số người TĐ";

            VeView();
        }

        private void VeView()
        {
            dtgvLoaiPhong.Controls.Clear();
            dtgvLoaiPhong.Controls.Clear();
            dtgvLoaiPhong.Controls.Clear();
            dtgvLoaiPhong.Controls.Clear();
            dtgvLoaiPhong.Controls.Clear();
            buttonXems.Clear();
            buttonXoas.Clear();
            buttonSuas.Clear();
            int widthXem = 760 + 10;
            int widthSua = 760 + 45;
            int widthXoa = 760 + 80;
            int i = 0;
            foreach (DataGridViewRow row in dtgvLoaiPhong.Rows)
            {
                Button buttonXem = new Button();
                Button buttonSua = new Button();
                Button buttonXoa = new Button();
                buttonXem.Size = new Size(30, 30);
                buttonSua.Size = new Size(30, 30);
                buttonXoa.Size = new Size(30, 30);
                buttonXems.Add(buttonXem);
                buttonSuas.Add(buttonSua);
                buttonXoas.Add(buttonXoa);
                dtgvLoaiPhong.Controls.Add(buttonXem);
                dtgvLoaiPhong.Controls.Add(buttonSua);
                dtgvLoaiPhong.Controls.Add(buttonXoa);
                buttonXem.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                buttonSua.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                buttonXoa.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                buttonXem.Location = new Point(widthXem, 50 + 36 * i + 3);
                buttonSua.Location = new Point(widthSua, 50 + 36 * i + 3);
                buttonXoa.Location = new Point(widthXoa, 50 + 36 * i + 3);
                buttonXem.Click += Xem;
                buttonSua.Click += Sua;
                buttonXoa.Click += Xoa;
                i++;
            }
        }

        private void Xoa(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int top = button.Top;
            int rowIndex = (top - 3 - 50) / 36;
            XoaChonDtgv();
            dtgvLoaiPhong.Rows[rowIndex].Selected = true;
        }

        private void Sua(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int top = button.Top;
            int rowIndex = (top - 3 - 50) / 36;
            XoaChonDtgv();
            dtgvLoaiPhong.Rows[rowIndex].Selected = true;
        }

        private void Xem(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int top = button.Top;
            int rowIndex = (top - 3 - 50) / 36;
            XoaChonDtgv();
            dtgvLoaiPhong.Rows[rowIndex].Selected = true;
        }

        public void XoaChonDtgv()
        {
            foreach (DataGridViewRow row in dtgvLoaiPhong.Rows)
            {
                row.Selected = false;
            }
        }

    }
}
