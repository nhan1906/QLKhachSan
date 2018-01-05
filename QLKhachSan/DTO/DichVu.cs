using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu
    {

        private string maDV;
        private string tenDV;
        private string tenLoaiDV;
        private string tenDonVi;
        private string hangHoa;
        private float donGiaDonVi;

        public DichVu() { }

        public DichVu(DataRow row)
        {
            maDV = row["maDV"].ToString();
            tenDV = row["tenDV"].ToString();
            tenLoaiDV = row["tenLoaiDV"].ToString();
            tenDonVi = row["tenDonVi"].ToString();
            if (((int)row["hangHoa"]) == 0)
                hangHoa = "Khác";
            else
                hangHoa = "Hàng hóa";
            donGiaDonVi = (float)Convert.ToDouble(row["donGiaDonVi"].ToString());
        }

        public string MaDV
        {
            get
            {
                return maDV;
            }

            set
            {
                maDV = value;
            }
        }

        public string TenDV
        {
            get
            {
                return tenDV;
            }

            set
            {
                tenDV = value;
            }
        }

        public string TenLoaiDV
        {
            get
            {
                return tenLoaiDV;
            }

            set
            {
                tenLoaiDV = value;
            }
        }

        public string TenDonVi
        {
            get
            {
                return tenDonVi;
            }

            set
            {
                tenDonVi = value;
            }
        }

        public string HangHoa
        {
            get
            {
                return hangHoa;
            }

            set
            {
                hangHoa = value;
            }
        }

        public float DonGiaDonVi
        {
            get
            {
                return donGiaDonVi;
            }

            set
            {
                donGiaDonVi = value;
            }
        }
    }
}
