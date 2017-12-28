using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tang
    {
        private string tenTang;
        private int tangThu;
        private int soPhong;

        public string TenTang
        {
            get
            {
                return tenTang;
            }

            set
            {
                tenTang = value;
            }
        }

        public int TangThu
        {
            get
            {
                return tangThu;
            }

            set
            {
                tangThu = value;
            }
        }

        public int SoPhong
        {
            get
            {
                return soPhong;
            }

            set
            {
                soPhong = value;
            }
        }

        public Tang() { }

        public Tang(DataRow row)
        {
            TangThu = (int)row["tangThu"];
            TenTang = row["tenTang"].ToString();
            SoPhong = (int)row["soPhong"];
        }
    }
}
