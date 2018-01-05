using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuDatPhongService
    {
        #region Singleton
        private static PhieuDatPhongService instance;

        public static PhieuDatPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDatPhongService();
                return instance;
            }
        }


        private PhieuDatPhongService() { }
        #endregion

        private PhieuDatPhongDAO data = PhieuDatPhongDAO.Instance;
        private ChiTietDatPhongDAO chiTietDatPhongData = ChiTietDatPhongDAO.Instance;

        public bool KiemTraDaTonTaiMa(string maDatPhong)
        {
            return data.KiemTraMaDaTonTai(maDatPhong);
        }


        public bool ThemPhieuDatPhong(PhieuDatPhong phieuDatPhong)
        {
            return data.TaoPhieuDatPhong(phieuDatPhong);
        }

        public PhieuDatPhong LayChiTietPhieuDat(string maDatPhong)
        {
            return data.LayPhieuDatPhongTheoMa(maDatPhong);
        }

        public bool HuyPhieuDatPhong(string maDatPhong)
        {
            return data.HuyDatPhong(maDatPhong);
        }

        public bool PhongKhongTheDat(int maPhong , DateTime checkIn, DateTime checkOut)
        {
            return data.KiemTraDieuKienDatPhong(maPhong, checkIn, checkOut);
        }
    }
}
