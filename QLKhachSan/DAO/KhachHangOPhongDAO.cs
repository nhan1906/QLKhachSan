using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangOPhongDAO
    {
        #region Singleton
        private static KhachHangOPhongDAO instance;

        public static KhachHangOPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangOPhongDAO();
                return instance;
            }
        }

        private KhachHangOPhongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemKhachHangVaoPhong(KhachHangOPhong item)
        {
            string query = "Insert into KhachHangOPhong (maNhanPhong, maPhong, maKH)VALUES(N'"+item.MaNhanPhong+"' , "+item.MaPhong+" , N'"+item.MaKH+"')";
            return provider.ExecuteNonQuery(query) > 0;
        }

        public string LayMaKHThuNhatCuaPhong(string maNhanPhong)
        {
            DataTable data = provider.ExecuteQuery("Select * from KhachHangOPhong where maNhanPhong = N'" + maNhanPhong + "'");
            return data.Rows[0]["maKH"].ToString();
        }
    }
}
