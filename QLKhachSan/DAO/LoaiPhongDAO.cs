using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiPhongDAO
    {
        #region Singleton
        private static LoaiPhongDAO instance;

        public static LoaiPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongDAO();
                return instance;
            }
        }

        private LoaiPhongDAO() { }

        #endregion

        private DataProvider provider = DataProvider.Instance;

        public List<LoaiPhong> LayDanhSachLoaiPhong()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            DataTable data = provider.ExecuteQuery("Select * from LoaiPhong");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new LoaiPhong(row));
            }
            return list;
        }

        public bool ThemLoaiPhong(LoaiPhong loaiPhong)
        {
            string query = "InsertLoaiPhong @maLoaiPhong  , @tenChatLuong , @tenLoaiGiuong , @giaGio , @giaDem , @giaNgay , @soNguoiToiDa , @hinhMoTa";
            return provider.ExecuteNonQuery(query , new object[] { loaiPhong.MaLoaiPhong , loaiPhong.TenChatLuong , loaiPhong.TenLoaiGiuong , loaiPhong.GiaGio , loaiPhong.GiaDem , loaiPhong.GiaNgay , loaiPhong.SoNguoiToiDa , loaiPhong.HinhMoTa}) > 0;
        }

        public LoaiPhong LayLoaiPhongBangMa(string maLoaiPhong)
        {
            string query = "Select * from LoaiPhong where maLoaiPhong = N'"+maLoaiPhong+"'";
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                return new LoaiPhong(row);
            }
            return null;
        }

        public bool KiemTraTonTaiCua(LoaiPhong loaiPhong)
        {
            string query = "Select * from LoaiPhong where tenChatLuong = N'" + loaiPhong.TenChatLuong +  "' and tenLoaiGiuong = N'" + loaiPhong.TenLoaiGiuong + "'";
            return provider.ExecuteQuery(query).Rows.Count > 0;
        }
    }
}
