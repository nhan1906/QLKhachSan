using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuSuaChuaDAO
    {
        #region Singleton
        private static PhieuSuaChuaDAO instance;

        public static PhieuSuaChuaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuSuaChuaDAO();
                return instance;
            }
        }

        private PhieuSuaChuaDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemPhieuSuaChua(PhieuSuaChua phieuSuaChua)
        {
            return provider.ExecuteNonQuery("InsertPhieuSuaPhong @maPhong , @ngayBatDau , @ngayDuKienKT , @ghiChu", new object[] { phieuSuaChua.MaPhong , phieuSuaChua.NgayBatDau, phieuSuaChua.NgayDuKienKT, phieuSuaChua.GhiChu }) > 0;
        }

        public bool CapNhatPhieuSuaChua(float tongTienSC, int maPhong)
        {
            return provider.ExecuteNonQuery("Update PhieuSuaPhong set tongTienSC = " + tongTienSC + " where maPhong = " + maPhong) > 0;
        }
    }
}
