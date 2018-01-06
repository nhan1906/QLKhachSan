using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private int maPhong;
        private int phongSo;
        private int tangThu;
        private string maLoaiPhong;
        private string tenTinhTrangPhong;
        private int ban;
        private string maHDHienTai;
        private LoaiPhong loaiPhong;

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

        public int PhongSo
        {
            get
            {
                return phongSo;
            }

            set
            {
                phongSo = value;
            }
        }

        public int TangThu
        {
            get
            {
                return tangThu;
            }

            set
            {
                tangThu = value;
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

        public string TenTinhTrangPhong
        {
            get
            {
                return tenTinhTrangPhong;
            }

            set
            {
                tenTinhTrangPhong = value;
            }
        }

        public int Ban
        {
            get
            {
                return ban;
            }

            set
            {
                ban = value;
            }
        }

        public string MaHDHienTai
        {
            get
            {
                return maHDHienTai;
            }

            set
            {
                maHDHienTai = value;
            }
        }

        public LoaiPhong LoaiPhong
        {
            get
            {
                return loaiPhong;
            }

            set
            {
                loaiPhong = value;
            }
        }

        public Phong() { }

        public Phong(DataRow row)
        {
            MaPhong = (int)row["maPhong"];
            PhongSo = (int)row["phongSo"];
            TangThu = (int)row["tangThu"];
            MaLoaiPhong = row["maLoaiPhong"].ToString();
            TenTinhTrangPhong = row["tenTinhTrangPhong"].ToString();
            Ban = (int)row["Ban"];
            MaHDHienTai = row["maHDHienTai"].ToString();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LoaiPhong where maLoaiPhong = N'" + maLoaiPhong + "'");
            LoaiPhong = new LoaiPhong(data.Rows[0]);
        }
    }
}
