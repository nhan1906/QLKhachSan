using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        #region Singleton
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
        }

        private KhachHangDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        //Thêm khách hàng
        public bool ThemKhachHang(KhachHang khachHang)
        {
            string query = "ThemKhachHang @tenKhachHang , @cmnd , @soDienThoai , @email , @diaChi , @quocTich , @ngaySinh , @gioiTinh";
            return provider.ExecuteNonQuery(query, new object[] { khachHang.TenKhachHang ,  khachHang.Cmnd , khachHang.SoDienThoai , khachHang.Email , khachHang.DiaChi , khachHang. QuocTich , khachHang.NgaySinh , khachHang.GioiTinh}) > 0;
        }

        //Sửa thông tin khách hàng
        public bool SuaKhachHang(KhachHang khachHang)
        {
            string query = "SuaKhachHang @maKhachHang , @tenKhachHang , @cmnd , @soDienThoai , @email , @diaChi , @quocTich , @ngaySinh , @gioiTinh";
            return provider.ExecuteNonQuery(query, new object[] {khachHang.MaKhachHang , khachHang.TenKhachHang, khachHang.Cmnd, khachHang.SoDienThoai, khachHang.Email, khachHang.DiaChi, khachHang.QuocTich, khachHang.NgaySinh, khachHang.GioiTinh }) > 0;
        }
    }
}
