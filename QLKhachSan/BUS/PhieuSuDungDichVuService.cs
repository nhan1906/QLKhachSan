using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class PhieuSuDungDichVuService
    {
        #region Singleton
        private static PhieuSuDungDichVuService instance;

        public static PhieuSuDungDichVuService Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuSuDungDichVuService();
                return instance;
            }
        }


        private PhieuSuDungDichVuService() { }
        #endregion

        private PhieuSuDungDichVuDAO data = PhieuSuDungDichVuDAO.Instance;
        private LoaiHoatDongDAO loaiHDData = LoaiHoatDongDAO.Instance;
        private ChiTietHoatDongDAO ctHDData = ChiTietHoatDongDAO.Instance;

        public void ThemPhieuSuDungDichVu(DichVu dichVu, int sl, Phong phong)
        {

            PhieuSuDungDichVu phieu = new PhieuSuDungDichVu();
            phieu.SoLuong = sl;
            phieu.MaDV = dichVu.MaDV;
            if (data.ThemPhieuSuDungDichVu(phieu))
            {
                ChiTietHoatDong ctHD = new ChiTietHoatDong();
                ctHD.MaHD = phong.MaHDHienTai;
                phieu = data.LayMaVuaSuDungDichVu();
                ctHD.MaLQ = phieu.MaSDDV;
                ctHD.IdLoaiHoatDong = loaiHDData.LayMaCuaLoaiHoatDong("SD dịch vụ");
                ctHDData.ThemChiTietHoatDong(ctHD);
            }

            // Hien thi notify o day
        }
    }
}
