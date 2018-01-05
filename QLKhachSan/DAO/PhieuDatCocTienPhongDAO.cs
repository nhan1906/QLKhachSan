using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuDatCocTienPhongDAO
    {
        #region Singleton
        private static PhieuDatCocTienPhongDAO instance;

        public static PhieuDatCocTienPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDatCocTienPhongDAO();
                return instance;
            }
        }

        private PhieuDatCocTienPhongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;
        public PhieuDatCocTienPhong LayMaVuaDatDoc()
        {
            int idDC = (int) provider.ExecuteScalar("select max(idDC) from PhieuDatCocTienPhong");
            return new PhieuDatCocTienPhong(provider.ExecuteQuery("select * from PhieuDatCocTienPhong where idDC = " + idDC).Rows[0]);
        }
        

        public bool ThemPhieuDatCocTienPhong(PhieuDatCocTienPhong phieu)
        {
            string query = "InsertPhieuDatCocTienPhong @soTien , @maPhong , @maNV , @thoiGianNhan";
            return provider.ExecuteNonQuery(query, new object[] { phieu.SoTien , phieu.MaPhong , phieu.MaNV , phieu.ThoiGianNhan }) > 0;
        }
    }
}
