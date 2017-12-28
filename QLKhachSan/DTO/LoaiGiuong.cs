using System;
using System.Data;

namespace DTO
{
    public class LoaiGiuong
    {
        private string tenLoaiGiuong;
        private int soNguoi;
        private int soGiuong;

        public string TenLoaiGiuong
        {
            get
            {
                return tenLoaiGiuong;
            }

            set
            {
                tenLoaiGiuong = value;
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

        public int SoGiuong
        {
            get
            {
                return soGiuong;
            }

            set
            {
                soGiuong = value;
            }
        }

        public LoaiGiuong() { }

        public LoaiGiuong(DataRow row)
        {
            TenLoaiGiuong = row["tenLoaiGiuong"].ToString();
            SoGiuong = (int)row["soGiuong"];
            SoNguoi = (int)row["soNguoi"];
        }
    }
}
