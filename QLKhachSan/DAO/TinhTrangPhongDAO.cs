using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TinhTrangPhongDAO
    {
        #region Singleton
        private static TinhTrangPhongDAO instance;

        public static TinhTrangPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TinhTrangPhongDAO();
                return instance;
            }
        }

        private TinhTrangPhongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public List<TinhTrangPhong> DanhSachTinhTrangPhong()
        {
            List<TinhTrangPhong> list = new List<TinhTrangPhong>();
            DataTable data = provider.ExecuteQuery("select * from TinhTrangPhong");
            foreach(DataRow row in data.Rows)
            {
                list.Add(new TinhTrangPhong(row));
            }
            return list;
        }
    }
}
