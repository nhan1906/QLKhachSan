using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DichVuDAO
    {
        #region Singleton
        private static DichVuDAO instance;

        public static DichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuDAO();
                return instance;
            }
        }

        private DichVuDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public List<DichVu> LayDanhSachDichVuTheoNhom(string tenLoaiDV)
        {
            List<DichVu> list = new List<DichVu>();
            DataTable data = provider.ExecuteQuery("select * from DichVu where tenLoaiDV = N'" + tenLoaiDV + "'");
            foreach(DataRow row in data.Rows)
            {
                list.Add(new DichVu(row));
            }
            return list;
        }

        public float TongTienDichVu(string maHDHienTai)
        {
            string query = "select Sum(PhieuSuDungDichVu.soLuong * DichVu.donGiaDonVi) from ChiTietHoatDong inner join PhieuSuDungDichVu " +
                    "on ChiTietHoatDong.maLQ = PhieuSuDungDichVu.maSDDV inner join DichVu on DichVu.maDV = PhieuSuDungDichVu.maDV " +
                    "where maHD = N'" + maHDHienTai + "'";
            if (provider.ExecuteScalar(query).ToString() == "")
                return 0;
            return (float)((Double)provider.ExecuteScalar(query));
        }
    }
}
