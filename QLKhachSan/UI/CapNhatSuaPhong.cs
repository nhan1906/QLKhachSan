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
    public partial class CapNhatSuaPhong : MetroForm
    {

        private int maPhong;
        private PhieuSuaChuaPhongService phieuSuaPhongService = PhieuSuaChuaPhongService.Instance;

        public CapNhatSuaPhong(int maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ValidateChiPhi())
            {
                phieuSuaPhongService.CapNhatChiPhiSuaPhong(txtChiPhiSuaPhong, maPhong, notify);
                this.Close();
            }

        }

        private bool ValidateChiPhi()
        {
            error.SetError(txtChiPhiSuaPhong, "");
            if(txtChiPhiSuaPhong.Text == "")
            {
                error.SetError(txtChiPhiSuaPhong, "Bắt buộc");
                return false;
            }   
            if(Convert.ToInt32(txtChiPhiSuaPhong.Text) % 1000 != 0)
            {
                error.SetError(txtChiPhiSuaPhong, "Không hợp lệ");
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
