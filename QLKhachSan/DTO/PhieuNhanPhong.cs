using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhanPhong
    {
        private string maNhanPhong;
        private int maPhong;
        private DateTime checkIn;
        private DateTime checkOut;
        private DateTime? checkOutReal;
        private int soNguoi;
        private int soTreEm;
        private string maHD;
        private string lyDoTraPhong;

        private float datCoc; // mang dữ liệu

        public PhieuNhanPhong()
        {

        }

        public PhieuNhanPhong(DataRow row)
        {
            MaNhanPhong = row["maNhanPhong"].ToString();
            MaPhong = (int)row["maPhong"];
            checkIn = (DateTime)row["checkIn"];
            checkOut = (DateTime)row["checkIn"];
            soNguoi = (int)row["soNguoi"];
            soTreEm = (int)row["soTreEm"];
            //datCoc = (float)Convert.ToDouble(row["datCoc"].ToString());
            if (row["checkOutReal"].ToString() == "")
                checkOutReal = null;
            else
            {
                checkOutReal = (DateTime)row["checkOutReal"];
            }
            MaHD = row["maHD"].ToString();
            LyDoTraPhong = row["lyDoTraPhong"].ToString();
        }

        public string MaNhanPhong
        {
            get
            {
                return maNhanPhong;
            }

            set
            {
                maNhanPhong = value;
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

        public DateTime CheckIn
        {
            get
            {
                return checkIn;
            }

            set
            {
                checkIn = value;
            }
        }

        public DateTime CheckOut
        {
            get
            {
                return checkOut;
            }

            set
            {
                checkOut = value;
            }
        }
        

        public DateTime? CheckOutReal
        {
            get
            {
                return checkOutReal;
            }

            set
            {
                checkOutReal = value;
            }
        }

        public int SoNguoi
        {
            get
            {
                return soNguoi;
            }

            set
            {
                soNguoi = value;
            }
        }

        public int SoTreEm
        {
            get
            {
                return soTreEm;
            }

            set
            {
                soTreEm = value;
            }
        }

        public string MaHD
        {
            get
            {
                return maHD;
            }

            set
            {
                maHD = value;
            }
        }

        public string LyDoTraPhong
        {
            get
            {
                return lyDoTraPhong;
            }

            set
            {
                lyDoTraPhong = value;
            }
        }

        public float DatCoc
        {
            get
            {
                return datCoc;
            }

            set
            {
                datCoc = value;
            }
        }
    }
}
