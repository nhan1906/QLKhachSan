using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangOPhong
    {
        private string maNhanPhong;
        private int maPhong;
        private string maKH;

        public KhachHangOPhong() { }

        public KhachHangOPhong(DataRow row)
        {
            MaNhanPhong = row["maNhanPhong"].ToString();
            MaPhong = (int)row["maPhong"];
            MaKH = row["maKH"].ToString();
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

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }
    }
}
