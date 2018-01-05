using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhanPhongDAO
    {
        #region Singleton
        private static PhieuNhanPhongDAO instance;

        public static PhieuNhanPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhanPhongDAO();
                return instance;
            }
        }

        private PhieuNhanPhongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemPhieuNhanPhong(PhieuNhanPhong phieuNhanPhong)
        {
            return provider.ExecuteNonQuery("InsertPhieuNhanPhong @maNhanPhong , @maPhong , @checkIn , @checkOut , @soNguoi , @soTreEm , @maHD", new object[] {
            phieuNhanPhong.MaNhanPhong , phieuNhanPhong.MaPhong , phieuNhanPhong.CheckIn , phieuNhanPhong.CheckOut , phieuNhanPhong.SoNguoi, phieuNhanPhong.SoTreEm, phieuNhanPhong.MaHD}) > 0;
        }

        public PhieuNhanPhong LayPhieuNhanPhongTheoMaPhong(int maPhong)
        {
            DataTable data = provider.ExecuteQuery("Select * from PhieuNhanPhong where maPhong = " + maPhong);
            return new PhieuNhanPhong(data.Rows[0]);
        }
    }
}
