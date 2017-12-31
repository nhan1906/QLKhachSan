using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDatPhong
    {
        private string maDatPhong;
        private int maPhong;
        private string maLoaiPhong;

        public ChiTietDatPhong()
        {

        }

        public ChiTietDatPhong(DataRow row)
        {
            maDatPhong = row["maDatPhong"].ToString();
            maPhong = (int)row["maPhong"];
            maLoaiPhong = row["maLoaiPhong"].ToString();
        }

        public string MaDatPhong
        {
            get
            {
                return maDatPhong;
            }

            set
            {
                maDatPhong = value;
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

        public string MaLoaiPhong
        {
            get
            {
                return maLoaiPhong;
            }

            set
            {
                maLoaiPhong = value;
            }
        }
    }
}
