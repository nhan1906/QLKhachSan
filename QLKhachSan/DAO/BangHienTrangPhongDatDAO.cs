using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BangHienTrangPhongDatDAO
    {
        #region Singleton
        private static BangHienTrangPhongDatDAO instance;

        public static BangHienTrangPhongDatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BangHienTrangPhongDatDAO();
                return instance;
            }
        }

        private BangHienTrangPhongDatDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public DataTable LayDanhSachHienTrangPhong(DateTime checkIn, DateTime checkOut)
        {
        
            DataTable data = provider.ExecuteQuery("BangHienTrangPhongDat @checkIn , @checkOut" , new object[] { checkIn , checkOut });
            data.Columns.Add(new DataColumn("thaoTac", typeof(string)));
            return data;
        }
    }
}
