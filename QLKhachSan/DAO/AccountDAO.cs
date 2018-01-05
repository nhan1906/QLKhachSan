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

        public Account LayThongTinTaiKhoanBangUsername(string username)
        {
            DataTable data = provider.ExecuteQuery("select * from Account where username = N'"+username+"'");
            if (data.Rows.Count > 0)
                return new Account(data.Rows[0]);
            return null;
        }
    }
}
