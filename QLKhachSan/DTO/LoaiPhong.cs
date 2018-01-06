using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong
    {
        private string maLoaiPhong;
        private string tenChatLuong;
        private string tenLoaiGiuong;
        private float giaNgay;
        private int soNguoiToiDa;
        private byte[] hinhMoTa; 

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
        
        public string TenChatLuong
        {
            get
            {
                return tenChatLuong;
            }

            set
            {
                tenChatLuong = value;
            }
        }

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

        public int SoNguoiToiDa
        {
            get
            {
                return soNguoiToiDa;
            }

            set
            {
                soNguoiToiDa = value;
            }
        }

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

        public LoaiPhong() { }

        public LoaiPhong(DataRow row)
        {
            MaLoaiPhong = row["maLoaiPhong"].ToString();
            TenLoaiGiuong = row["tenLoaiGiuong"].ToString();
            TenChatLuong = row["tenChatLuong"].ToString();
            
            GiaNgay = (float)Convert.ToDouble(row["giaNgay"].ToString());

            SoNguoiToiDa = (int)row["soNguoiToiDa"];

            HinhMoTa = (byte[])row["hinhMoTa"];
        }
    }
}
