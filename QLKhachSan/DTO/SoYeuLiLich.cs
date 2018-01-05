using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SoYeuLiLich
    {

        private string maLL;
        private string ho;
        private string ten;
        private string cmnd;
        private string soDienThoai;
        private string email;
        private string diaChiTamTru;
        private string queQuan;
        private string quocTich;
        private string trinhDo;
        private DateTime? ngaySinh;
        private int gioiTinh;
        private DateTime? ngayCapCMND;
        private string ghiChu;

        public SoYeuLiLich() { }

        public SoYeuLiLich(DataRow row)
        {
            maLL = row["maLL"].ToString();
            ho = row["ho"].ToString();
            ten = row["ten"].ToString();
            cmnd = row["cmnd"].ToString();
            soDienThoai = row["sdt"].ToString();
            email = row["email"].ToString();
            diaChiTamTru = row["diaChiTamTru"].ToString();
            queQuan = row["queQuan"].ToString();
            quocTich = row["quocTich"].ToString();
            trinhDo = row["trinhDo"].ToString();
            NgaySinh = (DateTime?)row["ngaySinh"];
            GioiTinh = (int)row["gioiTinh"];
            NgayCapCMND = (DateTime?)row["NgayCapCMND"];
            GhiChu = row["GhiChu"].ToString();
        }
        public string MaLL
        {
            get
            {
                return maLL;
            }

            set
            {
                maLL = value;
            }
        }

        public string Ho
        {
            get
            {
                return ho;
            }

            set
            {
                ho = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
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

        public string DiaChiTamTru
        {
            get
            {
                return diaChiTamTru;
            }

            set
            {
                diaChiTamTru = value;
            }
        }

        public string QueQuan
        {
            get
            {
                return queQuan;
            }

            set
            {
                queQuan = value;
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

        public string TrinhDo
        {
            get
            {
                return trinhDo;
            }

            set
            {
                trinhDo = value;
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

    }
}
