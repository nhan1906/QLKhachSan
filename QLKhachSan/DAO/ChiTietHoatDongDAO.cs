using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoatDongDAO
    {
        #region Singleton
        private static ChiTietHoatDongDAO instance;

        public static ChiTietHoatDongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoatDongDAO();
                return instance;
            }
        }

        private ChiTietHoatDongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemChiTietHoatDong(ChiTietHoatDong ct)
        {
            string query = "InsertChiTietHoatDong @maHD , @idLoaiHoatDong , @maLQ";
            return provider.ExecuteNonQuery(query, new object[] { ct.MaHD, ct.IdLoaiHoatDong, ct.MaLQ }) > 0;
        }

        public bool KiemTraMaDaTonTai(string maHD)
        {
            return provider.ExecuteQuery("Select * from ChiTietHoatDong where maHD = N'" + maHD + "'").Rows.Count > 0;
        }

        public float TinhTienPhong(Phong phong)
        {
            string query = "select * from ChiTietHoatDong inner join PhieuNhanPhong on ChiTietHoatDong.maLQ = PhieuNhanPhong.maNhanPhong where ChiTietHoatDong.maHD = N'" + phong.MaHDHienTai + "' and idLoaiHoatDong = 1";
            DataTable data = provider.ExecuteQuery(query);
            PhieuNhanPhong phieuNhanPhong = new PhieuNhanPhong();
            phieuNhanPhong.CheckIn = (DateTime)data.Rows[0]["checkIn"];
            phieuNhanPhong.CheckOut = (DateTime)data.Rows[0]["checkOut"];
            int soNgayDuKien = (phieuNhanPhong.CheckOut - phieuNhanPhong.CheckIn).Add(new TimeSpan(1, 0, 0, 0)).Days;
            if (phieuNhanPhong.CheckOut > DateTime.Now)
                return soNgayDuKien * phong.LoaiPhong.GiaNgay;
            return 0;

        }
    }
}
