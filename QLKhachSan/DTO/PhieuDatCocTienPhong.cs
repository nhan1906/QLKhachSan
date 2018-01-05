using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatCocTienPhong
    {
        private string maDC;
        private float soTien;
        private int maPhong;
        private string maNV;
        private DateTime thoiGianNhan;

        public PhieuDatCocTienPhong() { }

        public PhieuDatCocTienPhong(DataRow row)
        {
            maDC = row["maDC"].ToString();
            soTien = (float)Convert.ToDouble(row["soTien"].ToString());
            maPhong = (int)row["maPhong"];
            maNV = row["maNV"].ToString();
            thoiGianNhan = (DateTime)row["thoiGianNhan"];
        }

        public string MaDC
        {
            get
            {
                return maDC;
            }

            set
            {
                maDC = value;
            }
        }

        public float SoTien
        {
            get
            {
                return soTien;
            }

            set
            {
                soTien = value;
            }
        }

        public int MaPhong
        {
            get
            {
                return maPhong;
            }

            set
            {
                maPhong = value;
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

        public DateTime ThoiGianNhan
        {
            get
            {
                return thoiGianNhan;
            }

            set
            {
                thoiGianNhan = value;
            }
        }
    }
}
