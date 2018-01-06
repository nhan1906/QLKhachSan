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
    public partial class CapLaiMatKhauForm : MetroForm
    {
        private AccountService accountService = AccountService.Instance;

        public CapLaiMatKhauForm(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInfo())
            {
                accountService.CapNhatLaiMatKhau(txtPassword.Text, txtUsername.Text);
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool ValidateInfo()
        {
            bool flag = true;
            SetDefaultError();
            
            if (txtConfirm.Text == "")
            {
                error.SetError(txtConfirm, "Bắt buộc");
                txtConfirm.Focus();
                flag = false;
            }
            if (txtPassword.Text == "")
            {
                error.SetError(txtPassword, "Bắt buộc");
                txtPassword.Focus();
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
            error.SetError(txtPassword, "");
            error.SetError(txtConfirm, "");
        }
        
    }
}
