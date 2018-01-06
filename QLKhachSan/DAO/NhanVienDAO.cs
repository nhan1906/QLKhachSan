using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        #region Singleton
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }

        private NhanVienDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public NhanVien LayNhanVienDangNhap(string maNV)
        {
            DataTable data = provider.ExecuteQuery("select * from NhanVien where maNV = N'" + maNV + "'");
            if (data.Rows.Count > 0)
                return new NhanVien(data.Rows[0]);
            return null;
        }

        public List<NhanVien> DanhSachTatCaNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = provider.ExecuteQuery("select * from NhanVien");
            foreach(DataRow row in data.Rows)
            {
                list.Add(new NhanVien(row));
            }
            return list;
        }
    }
}
