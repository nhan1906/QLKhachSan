using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan
    {
        private string tenPhongBan;

        public PhongBan() { }

        public PhongBan(DataRow row)
        {
            tenPhongBan = row["tenPhongBan"].ToString();
        }

        public string TenPhongBan
        {
            get
            {
                return tenPhongBan;
            }

            set
            {
                tenPhongBan = value;
            }
        }
    }
}
