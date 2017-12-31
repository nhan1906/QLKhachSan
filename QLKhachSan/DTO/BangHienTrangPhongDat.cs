using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangHienTrangPhongDat
    {
        private byte[] hinhMoTa;
        private string maLoaiPhong;
        private string tenLoaiPhong;
        private float giaNgay;
        private int tong;
        private int dat;
        private int con;

        public byte[] HinhMoTa
        {
            get
            {
                return hinhMoTa;
            }

            set
            {
                hinhMoTa = value;
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

        public string TenLoaiPhong
        {
            get
            {
                return tenLoaiPhong;
            }

            set
            {
                tenLoaiPhong = value;
            }
        }

        public float GiaNgay
        {
            get
            {
                return giaNgay;
            }

            set
            {
                giaNgay = value;
            }
        }

        public int Tong
        {
            get
            {
                return tong;
            }

            set
            {
                tong = value;
            }
        }

        public int Dat
        {
            get
            {
                return dat;
            }

            set
            {
                dat = value;
            }
        }

        public int Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public BangHienTrangPhongDat() { }

        public BangHienTrangPhongDat(DataRow row)
        {
            HinhMoTa = (byte[])row["hinhMoTa"];
            MaLoaiPhong = row["maLoaiPhong"].ToString();
            TenLoaiPhong = row["tenLoai"].ToString();
            GiaNgay = (float)Convert.ToDouble(row["giaNgay"].ToString());
            Tong = (int)row["tong"];
            Con = (int)row["con"];
            Dat = (int)row["dat"];
        }
    }
}
