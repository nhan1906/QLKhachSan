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
    }
}
