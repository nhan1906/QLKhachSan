using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string cmnd;
        private string soDienThoai;
        private string email;
        private string diaChi;
        private string quocTich;
        private DateTime? ngaySinh;
        private int gioiTinh;

        public KhachHang() { }

        public KhachHang(DataRow row)
        {
            MaKhachHang = row["maKhachHang"].ToString();
            TenKhachHang = row["tenKhachHang"].ToString();
            Cmnd = row["cmnd"].ToString();
            SoDienThoai = row["soDienThoai"].ToString();
            Email = row["email"].ToString();
            DiaChi = row["diaChi"].ToString();
            QuocTich = row["quocTich"].ToString();
            NgaySinh = (DateTime?)row["ngaySinh"];
            GioiTinh = (int)row["gioiTinh"];
        }

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return tenKhachHang;
            }

            set
            {
                tenKhachHang = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string QuocTich
        {
            get
            {
                return quocTich;
            }

            set
            {
                quocTich = value;
            }
        }

        public DateTime? NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public int GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }
    }
}
