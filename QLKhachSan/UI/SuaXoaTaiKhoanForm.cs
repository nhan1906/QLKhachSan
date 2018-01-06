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
    public partial class SuaXoaTaiKhoanForm : MetroForm
    {
        private AccountService accountService = AccountService.Instance;
        private Account account;
        private Account accountHT;
        public SuaXoaTaiKhoanForm(Account account, Account accountHT)
        {
            InitializeComponent();
            this.account = account;
            this.accountHT = accountHT;
        }

        private void btnCapMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            CapLaiMatKhauForm f = new CapLaiMatKhauForm(account.Username);
            f.ShowDialog();
            this.Close();
        }

        private void btnXoaMK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                accountService.XoaTaiKhoan(account, accountHT);
                
            }
            this.Close();
        }
    }
}
