using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DanhSachPhongConTrongDAO
    {
        #region Singleton
        private static DanhSachPhongConTrongDAO _instance;

        public static DanhSachPhongConTrongDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DanhSachPhongConTrongDAO();
                return _instance;
            }
        }

        private DanhSachPhongConTrongDAO() { }
        #endregion

        private DataProvider provider = DataProvider.Instance;

        public List<Phong> DanhSachPhongTrongTheoLoai(DateTime checkIn , DateTime checkOut , string maLoaiPhong)
        {
            List<Phong> phongTrongs = new List<Phong>();
            DataTable data = provider.ExecuteQuery("DanhSachPhongConTrong @soPhong , @checkIn , @checkOut , @maLoaiPhong", new object[] {1, checkIn, checkOut, maLoaiPhong });
            foreach(DataRow row in data.Rows)
            {
                phongTrongs.Add(new Phong(row));
            }
            return phongTrongs;
        }
    }
}
