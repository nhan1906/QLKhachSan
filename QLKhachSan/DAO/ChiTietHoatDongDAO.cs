using DTO;
using System;
using System.Collections.Generic;
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

    }
}
