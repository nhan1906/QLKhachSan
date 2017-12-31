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
    }
}
