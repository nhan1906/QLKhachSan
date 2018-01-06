using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuPhuThu
    {
        private string maPT;
        private float tienPhuThu;
        private string nguyenNhan;

        public PhieuPhuThu() { }

        public PhieuPhuThu(DataRow row)
        {
            maPT = row["maPT"].ToString();
            tienPhuThu = (float)Convert.ToDouble(row["tienPhuThu"].ToString());
            nguyenNhan = row["nguyenNhan"].ToString();
        }

        public string MaPT
        {
            get
            {
                return maPT;
            }

            set
            {
                maPT = value;
            }
        }

        public float TienPhuThu
        {
            get
            {
                return tienPhuThu;
            }

            set
            {
                tienPhuThu = value;
            }
        }

        public string NguyenNhan
        {
            get
            {
                return nguyenNhan;
            }

            set
            {
                nguyenNhan = value;
            }
        }
    }
}
