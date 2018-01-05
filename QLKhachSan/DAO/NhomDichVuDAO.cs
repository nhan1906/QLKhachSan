using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhomDichVuDAO
    {
        #region Singleton
        private static NhomDichVuDAO instance;

        public static NhomDichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhomDichVuDAO();
                return instance;
            }
        }

        private NhomDichVuDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public List<NhomDichVu> LayDanhSachNhomDichVu()
        {
            List<NhomDichVu> list = new List<NhomDichVu>();
            DataTable data = provider.ExecuteQuery("select * from NhomDichVu");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new NhomDichVu(row));
            }
            return list;
        }
    }
}
