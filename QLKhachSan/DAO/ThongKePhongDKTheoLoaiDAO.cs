using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKePhongDKTheoLoaiDAO
    {
        #region Singleton
        private static ThongKePhongDKTheoLoaiDAO instance;

        public static ThongKePhongDKTheoLoaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKePhongDKTheoLoaiDAO();
                return instance;
            }
        }

        private ThongKePhongDKTheoLoaiDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public DataTable LayDanhSachDKTheoLoai(string maDatPhong)
        {
            DataTable data = provider.ExecuteQuery("LayDanhSachPhongDaDangKy @maDatPhong" , new object[] { maDatPhong });
            data.Columns.Add(new DataColumn("thaoTac", typeof(string)));
            return data;
        }

    }
}
