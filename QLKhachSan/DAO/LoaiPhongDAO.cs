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
            string query = "Insert into LoaiPhong (maLoaiPhong  , tenChatLuong , tenLoaiGiuong , giaGio , giaDem , giaNgay , soNguoiToiDa) values ( N'" + loaiPhong.MaLoaiPhong + "' , N'" + loaiPhong.TenChatLuong +"' , N'" + loaiPhong.TenLoaiGiuong + "' , "  + loaiPhong.GiaGio + " , " + loaiPhong.GiaDem + " , " + loaiPhong.GiaNgay + " , " + loaiPhong.SoNguoiToiDa + " )";
            return provider.ExecuteNonQuery(query) > 0;
        }

        public bool KiemTraTonTaiCua(LoaiPhong loaiPhong)
        {
            string query = "Select * from LoaiPhong where tenChatLuong = N'" + loaiPhong.TenChatLuong +  "' and tenLoaiGiuong = N'" + loaiPhong.TenLoaiGiuong + "'";
            return provider.ExecuteQuery(query).Rows.Count > 0;
        }
    }
}
