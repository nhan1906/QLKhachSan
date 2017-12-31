using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietDatPhongDAO
    {
        #region Singleton
        private static ChiTietDatPhongDAO instance;

        public static ChiTietDatPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietDatPhongDAO();
                return instance;
            }
        }

        private ChiTietDatPhongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemPhongDatPhong(Phong phong, string maDatPhong)
        {
            string query = "InsertChiTietDatPhong @maDatPhong , @maPhong , @maLoaiPhong";
            return provider.ExecuteNonQuery(query, new object[] { maDatPhong, phong.MaPhong , phong.MaLoaiPhong }) > 0;
        }

    }
}
