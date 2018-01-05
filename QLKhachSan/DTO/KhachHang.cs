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
        private string hoKhachHang;
        private string tenKhachHang;
        private string cmnd;
        private string soDienThoai;
        private string email;
        private string diaChi;
        private string quocTich;
        private DateTime? ngaySinh;
        private int gioiTinh;
        private string ngheNghiep;
        private DateTime? ngayCapCMND;
        private string ghiChu;
        private string soVisa;
        private DateTime? thoiHanViSa;
        private DateTime? tamTruTu;
        private DateTime? tamTruDen;

        public KhachHang() { }

        public KhachHang(DataRow row)
        {
            MaKhachHang = row["maKH"].ToString();
            HoKhachHang = row["hoKH"].ToString();
            TenKhachHang = row["tenKH"].ToString();
            Cmnd = row["cmnd"].ToString();
            SoDienThoai = row["sdt"].ToString();
            Email = row["email"].ToString();
            DiaChi = row["diaChi"].ToString();
            QuocTich = row["quocTich"].ToString();
            NgaySinh = (DateTime?)row["ngaySinh"];
            GioiTinh = (int)row["gioiTinh"];
            ThoiHanViSa = (DateTime?)row["ThoiHanViSa"];
            TamTruDen = (DateTime?)row["TamTruDen"];
            TamTruTu = (DateTime?)row["TamTruTu"];
            NgayCapCMND = (DateTime?)row["NgayCapCMND"];
            GhiChu = row["GhiChu"].ToString();
            SoVisa = row["SoVisa"].ToString();
            NgheNghiep = row["NgheNghiep"].ToString();
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

        public string NgheNghiep
        {
            get
            {
                return ngheNghiep;
            }

            set
            {
                ngheNghiep = value;
            }
        }

        public DateTime? NgayCapCMND
        {
            get
            {
                return ngayCapCMND;
            }

            set
            {
                ngayCapCMND = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public string SoVisa
        {
            get
            {
                return soVisa;
            }

            set
            {
                soVisa = value;
            }
        }

        public DateTime? TamTruTu
        {
            get
            {
                return tamTruTu;
            }

            set
            {
                tamTruTu = value;
            }
        }

        public DateTime? TamTruDen
        {
            get
            {
                return tamTruDen;
            }

            set
            {
                tamTruDen = value;
            }
        }

        public DateTime? ThoiHanViSa
        {
            get
            {
                return thoiHanViSa;
            }

            set
            {
                thoiHanViSa = value;
            }
        }

        public string HoKhachHang
        {
            get
            {
                return hoKhachHang;
            }

            set
            {
                hoKhachHang = value;
            }
        }
    }
}
