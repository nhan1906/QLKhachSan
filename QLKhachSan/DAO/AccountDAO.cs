using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        #region Singleton
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
        }

        private AccountDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool Login(string username , string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach(byte item in hasData)
            {
                hasPass += item;
            }

            string query = "CheckLogin @username , @password";
            return provider.ExecuteQuery(query, new object[] { username, hasPass }).Rows.Count > 0;

        }

        public void CapNhatLaiMatKhau(string password, string username)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = "update Account set password = N'" + password + "' where username = N'" + username + "'";
            provider.ExecuteNonQuery(query);
        }

        public int LayPhanQuyenTaiKhoan(string username)
        {
            DataTable data = provider.ExecuteQuery("select * from Account where username = N'" + username + "'");
            if (data.Rows.Count > 0)
            {
                return (new Account(data.Rows[0])).Phanquyen;
            }
            return -1;
        }

        public bool XoaTaiKhoan(string username)
        {
            return provider.ExecuteNonQuery("delete from Account where username = N'" + username + "'") > 0;
        }

        public Account LayThongTinTaiKhoanBangUsername(string username)
        {
            DataTable data = provider.ExecuteQuery("select * from Account where username = N'"+username+"'");
            if (data.Rows.Count > 0)
                return new Account(data.Rows[0]);
            return null;
        }

        public bool MaNhanVienDaTonTai(string maNV)
        {
            DataTable data = provider.ExecuteQuery("select * from Account where maNV = N'" + maNV + "'");
            return data.Rows.Count > 0;
        }

        public bool ThemTaiKhoanMoi(Account account)
        {

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(account.Password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            string query = "InsertAccount @username , @password , @displayname , @maNV , @phanquyen";
            return provider.ExecuteNonQuery(query, new object[] { account.Username, hasPass, account.Displayname, account.MaNV, account.Phanquyen }) > 0;
        }

        public List<Account> LayTatCaAccount()
        {
            List<Account> list = new List<Account>();
            DataTable data = provider.ExecuteQuery("select * from Account");
            foreach(DataRow row in data.Rows)
            {
                list.Add(new Account(row));
            }
            return list;
        }

        public bool TenDangNhapDaTonTai(string username)
        {
            DataTable data = provider.ExecuteQuery("select * from Account where username = N'" + username + "'");
            return data.Rows.Count > 0;
        }
    }
}
