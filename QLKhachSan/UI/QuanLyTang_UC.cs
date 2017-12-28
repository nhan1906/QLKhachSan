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

        private BindingSource bingding = new BindingSource();
        private TangService tangService = TangService.Instance;
        private FormatViewServices formatView = FormatViewServices.Instance;

        public static QuanLyTang_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuanLyTang_UC();
                return instance;
            }
        }

        public QuanLyTang_UC()
        {
            InitializeComponent();
            formatView.FormatDataGridView(dtgvTang);
            dtgvTang.DataSource = bingding;
            tangService.HienThiDataGridView(bingding);

            dtgvTang.Columns.Add("thaoTac", "Thao tác");

            dtgvTang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvTang.Columns[1].Width = 150;
            dtgvTang.Columns[2].Width = 150;
            dtgvTang.Columns[3].Width = 200;

            dtgvTang.Columns[0].HeaderText = "Tên tầng";
            dtgvTang.Columns[1].HeaderText = "Tầng thứ";
            dtgvTang.Columns[2].HeaderText = "Số phòng";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemTang f = new ThemTang();
            f.ShowDialog();
        }

        public void CapNhat()
        {
            tangService.HienThiDataGridView(bingding);
        }
    }
}
