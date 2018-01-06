using BUS;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DanhSachNhanVienForm : MetroForm
    {

        private NhanVienService nhanVienService = NhanVienService.Instance;
        private FormatViewServices formatView = FormatViewServices.Instance;
        private ThemTaiKhoanForm f = null;

        public DanhSachNhanVienForm(ThemTaiKhoanForm f)
        {
            InitializeComponent();
            this.f = f;
            nhanVienService.HienThiLenDataGridView(dtgvNhanVien);
            formatView.FormatDataGridView(dtgvNhanVien);
            dtgvNhanVien.DoubleClick += DtgvNhanVien_DoubleClick;
        }

        private void DtgvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvNhanVien.SelectedRows.Count == 0)
                return;
            string maNV = dtgvNhanVien.SelectedRows[0].Cells["maNV"].Value.ToString();
            f.maNV = maNV;
            this.Close();
        }
    }
}
