using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Tulpep.NotificationWindow;

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
    }
}
