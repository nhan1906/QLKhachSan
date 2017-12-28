using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiGiuongDAO
    {
        #region Singleton
        private static LoaiGiuongDAO instance;

        public static LoaiGiuongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiGiuongDAO();
                return instance;
            }
        }

        private LoaiGiuongDAO() { }

        #endregion

        private DataProvider provider = DataProvider.Instance;

        public List<LoaiGiuong> LayDanhSachLoaiGiuong()
        {
            List<LoaiGiuong> list = new List<LoaiGiuong>();
            DataTable data = provider.ExecuteQuery("Select * from LoaiGiuong");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new LoaiGiuong(row));
            }
            return list;
        }
    }
}
