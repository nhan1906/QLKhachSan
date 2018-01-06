using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Tulpep.NotificationWindow;
using System.Windows.Forms;

namespace BUS
{
    public class AccountService
    {
        #region Singleton
        private static AccountService instance;

        public static AccountService Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountService();
                return instance;
            }
        }


        private AccountService() { }
        #endregion

        private AccountDAO data = AccountDAO.Instance;

        public void CapNhatLaiMatKhau(string password, string username)
        {
            data.CapNhatLaiMatKhau(password, username);
            MessageBox.Show("Bạn đã cập nhật lại mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK);
        }

        public Account LayAccountDangNhap(string username)
        {
            return data.LayThongTinTaiKhoanBangUsername(username);
        }

        private NhanVienDAO nvData = NhanVienDAO.Instance;

        public NhanVien Login(Account account)
        {
            if(data.Login(account.Username, account.Password))
            {
                Account info = data.LayThongTinTaiKhoanBangUsername(account.Username);
                NhanVien nv = nvData.LayNhanVienDangNhap(info.MaNV);
                return nv;
            }
            return null;
        }

        public void XoaTaiKhoan(Account account, Account accountHT)
        {
            if(accountHT.Username == account.Username)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản của mình", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(account.Phanquyen == 0)
                if (data.XoaTaiKhoan(account.Username))
                {
                    MessageBox.Show("Bạn đã xóa tài khoản có username là : " + account.Username, "Thông báo", MessageBoxButtons.OK);
                }
            else
                {
                    if(accountHT.Username == "admin")
                    {
                        if (data.XoaTaiKhoan(account.Username))
                        {
                            MessageBox.Show("Bạn đã xóa tài khoản có username là : " + account.Username, "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    MessageBox.Show("Bạn không có quyền xóa tài khoản này: " + account.Username, "Thông báo", MessageBoxButtons.OK);
                }
        }

        public void DrawDtgv(DataGridView dtgvTaiKhoan)
        {
            dtgvTaiKhoan.Columns["password"].Visible = false;
            dtgvTaiKhoan.Columns["username"].HeaderText = "Tên đăng nhập";
            dtgvTaiKhoan.Columns["displayname"].HeaderText = "Tên hiển thị";
            dtgvTaiKhoan.Columns["maNV"].HeaderText = "Tài khoản thuộc Nhân viên";
            dtgvTaiKhoan.Columns["loaiTK"].HeaderText = "Loại tài khoản";
            dtgvTaiKhoan.Columns["phanQuyen"].Visible = false;


            dtgvTaiKhoan.Columns["username"].Width = 200;
            dtgvTaiKhoan.Columns["displayname"].Width = 200;
            dtgvTaiKhoan.Columns["maNV"].Width = 200;
            dtgvTaiKhoan.Columns["phanQuyen"].Width = 200;
            foreach(DataGridViewRow row in dtgvTaiKhoan.Rows)
            {
                if ((int)row.Cells["phanQuyen"].Value == 0)
                    row.Cells["loaiTK"].Value = "Nhân viên";
                else
                    row.Cells["loaiTK"].Value = "Quản lý";
            }
        }

        public int ThemTaiKhoanMoi(Account account)
        {
            //Ten dang nhap da ton tai
            if (data.TenDangNhapDaTonTai(account.Username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                return 1;
            }
            //MaNV da co tai khoan
            if (data.MaNhanVienDaTonTai(account.MaNV))
            {
                MessageBox.Show("Nhân viên này đã được cấp tài khoản", "Thông báo", MessageBoxButtons.OK);
                return 2;
            }
            //Them vao
            data.ThemTaiKhoanMoi(account);
            return 3;
        }

        public void HienThiTatCaTaiKhoanLenDtgv(DataGridView dtgv)
        {
            dtgv.DataSource = data.LayTatCaAccount();
        }
    }
}
