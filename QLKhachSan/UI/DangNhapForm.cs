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
    public partial class DangNhapForm : MetroForm
    {

        private AccountService accountService = AccountService.Instance;

        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (ValidateCheckIn())
            {
                Account account = new Account();
                account.Username = txtUsername.Text;
                account.Password = txtPassword.Text;
                NhanVien info = accountService.Login(account);
                if (info == null)
                {
                    MessageBox.Show("Tài khoản bạn đăng nhập không tồn tại.\nVui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK);  
                }
                else {
                    this.Hide();
                    Account accountHT = accountService.LayAccountDangNhap(account.Username);
                    Main main = new Main(info , accountHT);
                    main.Hide();
                    SplashScreen f = new SplashScreen();
                    f.ShowDialog();
                    this.Close();
                }
            }
            
        }

        private bool ValidateCheckIn()
        {
            SetDefaultError();
            if(txtUsername.Text == "")
            {
                error.SetError(txtUsername, "Bắt buộc");
                return false;
            }
            if (txtPassword.Text == "")
            {
                error.SetError(txtUsername, "Bắt buộc");
                return false;
            }
            return true;
        }

        private void SetDefaultError()
        {
            error.SetError(txtUsername, "");
            error.SetError(txtPassword, "");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
