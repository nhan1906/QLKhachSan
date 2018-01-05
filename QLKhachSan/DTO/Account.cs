using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string displayname;
        private string maNV;
        private int phanquyen;

        public Account() { }

        public Account(DataRow row)
        {
            username = row["username"].ToString();
            password = row["password"].ToString();
            displayname = row["displayname"].ToString();
            maNV = row["maNV"].ToString();
            phanquyen = (int)row["phanquyen"];
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Displayname
        {
            get
            {
                return displayname;
            }

            set
            {
                displayname = value;
            }
        }

        public int Phanquyen
        {
            get
            {
                return phanquyen;
            }

            set
            {
                phanquyen = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }
    }
}
