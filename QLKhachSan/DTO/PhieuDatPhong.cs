using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatPhong
    {
        private string maDatPhong;
        private string tenNguoiDat;
        private string sdtNguoiDat;
        private string emailNguoiDat;
        private DateTime? ngayDen;
        private DateTime? ngayDi;
        private string yeuCauKhac;


        public PhieuDatPhong()
        {

        }

        public PhieuDatPhong(DataRow row)
        {
            MaDatPhong = row["maDatPhong"].ToString();
            TenNguoiDat = row["tenNguoiDat"].ToString();
            SdtNguoiDat = row["sdtNguoiDat"].ToString();
            EmailNguoiDat = row["emailNguoiDat"].ToString();
            if (!row["NgayDen"].Equals(""))
                NgayDen = (DateTime)row["ngayDen"];
            if (!row["NgayDi"].Equals(""))
                NgayDi = (DateTime)row["ngayDi"];
            YeuCauKhac = row["yeuCauKhac"].ToString();
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

        public string TenNguoiDat
        {
            get
            {
                return tenNguoiDat;
            }

            set
            {
                tenNguoiDat = value;
            }
        }

        public string SdtNguoiDat
        {
            get
            {
                return sdtNguoiDat;
            }

            set
            {
                sdtNguoiDat = value;
            }
        }

        public string EmailNguoiDat
        {
            get
            {
                return emailNguoiDat;
            }

            set
            {
                emailNguoiDat = value;
            }
        }

        public DateTime? NgayDen
        {
            get
            {
                return ngayDen;
            }

            set
            {
                ngayDen = value;
            }
        }

        public DateTime? NgayDi
        {
            get
            {
                return ngayDi;
            }

            set
            {
                ngayDi = value;
            }
        }

        public string YeuCauKhac
        {
            get
            {
                return yeuCauKhac;
            }

            set
            {
                yeuCauKhac = value;
            }
        }
    }
}
