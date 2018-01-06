using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuSuDungDichVuDAO
    {
        #region Singleton
        private static PhieuSuDungDichVuDAO instance;

        public static PhieuSuDungDichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuSuDungDichVuDAO();
                return instance;
            }
        }

        private PhieuSuDungDichVuDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemPhieuSuDungDichVu(PhieuSuDungDichVu phieu)
        {
            string query = "InsertPhieuSuDungDichVu @maDV , @soLuong  , @thoiGianNhan";
            return provider.ExecuteNonQuery(query, new object[] { phieu.MaDV, phieu.SoLuong, DateTime.Now }) > 0;
        }

        public PhieuSuDungDichVu LayMaVuaSuDungDichVu()
        {
            int idSDDV = (int)provider.ExecuteScalar("select max(idSDDV) from PhieuSuDungDichVu");
            return new PhieuSuDungDichVu(provider.ExecuteQuery("select * from PhieuSuDungDichVu where idSDDV = " + idSDDV).Rows[0]);
        }
    }
}
