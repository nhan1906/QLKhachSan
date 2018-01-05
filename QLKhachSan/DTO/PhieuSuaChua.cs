using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuSuaChua
    {
        private string maSuaPhong;
        private int maPhong;
        private DateTime ngayBatDau;
        private DateTime ngayDuKienKT;
        private DateTime? ngayKT;
        private float tongTienSC;
        private string ghiChu;

        public PhieuSuaChua() { }

        public PhieuSuaChua(DataRow row)
        {
            MaSuaPhong = row["maSuaPhong"].ToString();
            maPhong = (int)row["maPhong"];
            ngayBatDau = (DateTime)row["ngayBatDau"];
            ngayKT = (DateTime?)row["ngayKT"];
            ngayDuKienKT = (DateTime)row["ngayDuKienKT"];
            tongTienSC = (float)Convert.ToDouble(row["tongTienSC"].ToString());
            ghiChu = row["ghiChu"].ToString();
        }

        public string MaSuaPhong
        {
            get
            {
                return maSuaPhong;
            }

            set
            {
                maSuaPhong = value;
            }
        }

        public DateTime NgayBatDau
        {
            get
            {
                return ngayBatDau;
            }

            set
            {
                ngayBatDau = value;
            }
        }

        public DateTime NgayDuKienKT
        {
            get
            {
                return ngayDuKienKT;
            }

            set
            {
                ngayDuKienKT = value;
            }
        }

        public DateTime? NgayKT
        {
            get
            {
                return ngayKT;
            }

            set
            {
                ngayKT = value;
            }
        }

        public float TongTienSC
        {
            get
            {
                return tongTienSC;
            }

            set
            {
                tongTienSC = value;
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
    }
}
