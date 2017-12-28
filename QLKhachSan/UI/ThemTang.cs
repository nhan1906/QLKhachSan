using BUS;
using DTO;
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
    public partial class ThemTang : MetroForm
    {

        private TangService tangService = TangService.Instance;

        public ThemTang()
        {
            InitializeComponent();
        }


        private void autoGenerateLink_Click(object sender, EventArgs e)
        {
            tangService.LayTangTiepTheo(txtTangThu);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            error.SetError(txtTangThu, "");
            if (txtTangThu.Text == "")
            {
                error.SetError(txtTangThu, "Bắt buộc");
                return;
            }
            Tang tang = new Tang();
            tang.TangThu = Convert.ToInt32(txtTangThu.Text);
            tang.TenTang = "Tầng " + tang.TangThu;
            int i = tangService.ThemTang(tang);
            if (i == 2)
            {
                error.SetError(txtTangThu, "Đã tồn tại tầng " + tang.TangThu);
            }
            if (i == 1)
            {
                QuanLyTang_UC.Instance.CapNhat();
            }
        }

        private void txtTangThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
