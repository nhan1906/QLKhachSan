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
    public partial class ThemTaiKhoanForm : MetroForm
    {


        public ThemTaiKhoanForm()
        {
            InitializeComponent();
        }

        private AccountService accountService = AccountService.Instance;
        public string maNV = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInfo())
            {

                Account account = new Account();
                account.MaNV = txtMaNV.Text;
                account.Username = txtUsername.Text;
                account.Displayname = txtDisplayname.Text;
                account.Password = txtPassword.Text;
                if (rNhanVien.Checked == true)
                    account.Phanquyen = 0;
                else
                    account.Phanquyen = 1;
                int result = accountService.ThemTaiKhoanMoi(account);
                if (result == 3)
                {
                    this.Close();
                }
                if (result == 2)
                {
                    txtMaNV.Focus();
                }
                if (result == 1)
                {
                    txtUsername.Focus();
                }

            }
        }

        private bool ValidateInfo()
        {
            bool flag = true;
            SetDefaultError();
            
            if(txtMaNV.Text == "")
            {
                error.SetError(txtMaNV, "Chọn nhân viên");
                flag = false;
                
            }
            if(txtConfirm.Text == "")
            {
                error.SetError(txtConfirm, "Bắt buộc");
                txtConfirm.Focus();
                flag = false;
            }
            if(txtPassword.Text == "")
            {
                error.SetError(txtPassword, "Bắt buộc");
                txtPassword.Focus();
                flag = false;
            }
            if(txtDisplayname.Text == "")
            {
                error.SetError(txtDisplayname, "Bắt buộc");
                txtDisplayname.Focus();
                flag = false;
            }
            if (txtUsername.Text == "")
            {
                error.SetError(txtUsername, "Bắt buộc");
                txtUsername.Focus();
                flag = false;
            }
            if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                error.SetError(txtConfirm, "Không khớp password");
                txtConfirm.Focus();
                flag = false;
            }
            return flag;
        }

        private void SetDefaultError()
        {
            error.SetError(txtUsername, "");
            error.SetError(txtDisplayname, "");
            error.SetError(txtPassword, "");
            error.SetError(txtConfirm, "");
            error.SetError(txtMaNV, "");
        }

        private void txtMaNV_ButtonClick(object sender, EventArgs e)
        {
            DanhSachNhanVienForm f = new DanhSachNhanVienForm(this);
            f.ShowDialog();
            txtMaNV.Text = maNV;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
