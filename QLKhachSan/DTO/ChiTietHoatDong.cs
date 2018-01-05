using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoatDong
    {
        private string maHD;
        private int idLoaiHoatDong;
        private string maLQ;

        public ChiTietHoatDong() { }

        public ChiTietHoatDong(DataRow row)
        {
            maHD = row["maHD"].ToString();
            idLoaiHoatDong = (int)row["idLoaiHoatDong"];
            maLQ = row["maLQ"].ToString();
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

        public int IdLoaiHoatDong
        {
            get
            {
                return idLoaiHoatDong;
            }

            set
            {
                idLoaiHoatDong = value;
            }
        }

        public string MaLQ
        {
            get
            {
                return maLQ;
            }

            set
            {
                maLQ = value;
            }
        }
    }
}
