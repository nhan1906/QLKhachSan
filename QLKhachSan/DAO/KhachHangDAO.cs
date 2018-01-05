using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            string query = "InsertKhachHang @cmnd , @hoKH ,  @tenKH , @sdt , @gioiTinh , @diaChi , "+
                " @ngheNghiep  , @ngayCapCMND , @ngaySinh , " +
                " @email , @ghiChu , @quoctich , @soVisa , @thoiHanVisa , @tamTruTu , @tamTruDen";
            List<object> paras = new List<object>();
            paras.Add(khachHang.Cmnd);
            paras.Add(khachHang.HoKhachHang);
            paras.Add(khachHang.TenKhachHang);
            paras.Add(khachHang.SoDienThoai);
            paras.Add(khachHang.GioiTinh);
            paras.Add(khachHang.DiaChi);
            paras.Add(khachHang.NgheNghiep);
            if (khachHang.NgayCapCMND != null)
                paras.Add(khachHang.NgayCapCMND);
            else
                paras.Add("");
            if (khachHang.NgaySinh != null)
                paras.Add(khachHang.NgaySinh);
            else
                paras.Add("");
            paras.Add(khachHang.Email);
            paras.Add(khachHang.GhiChu);
            paras.Add(khachHang.QuocTich);
            paras.Add(khachHang.SoVisa);
            if (khachHang.ThoiHanViSa != null)
                paras.Add(khachHang.ThoiHanViSa);
            else
                paras.Add("");
            if (khachHang.TamTruTu != null)
                paras.Add(khachHang.TamTruTu);
            else
                paras.Add("");
            if (khachHang.TamTruDen != null)
                paras.Add(khachHang.TamTruDen);
            else
                paras.Add("");
            return provider.ExecuteNonQuery(query, paras.ToArray()) > 0;
        }

        public KhachHang LayKhachHangBangMaKH(string maKH)
        {
            DataTable data = provider.ExecuteQuery("select * from KhachHang where maKH = N'" + maKH + "'");
            foreach(DataRow row in data.Rows)
            {
                return new KhachHang(row);
            }
            return null;
        }

        public object LayDanhSachKhachHangTheoSoGT(string text)
        {
            List<KhachHang> khachHangList = new List<KhachHang>();
            DataTable data = provider.ExecuteQuery("select * from KhachHang where cmnd like '" + text + "%'");
            foreach (DataRow row in data.Rows)
            {
                khachHangList.Add(new KhachHang(row));
            }
            return khachHangList;
        }

        public List<KhachHang> LayDanhSachKhachHang()
        {
            List<KhachHang> khachHangList = new List<KhachHang>();
            DataTable data = provider.ExecuteQuery("select * from KhachHang");
            foreach(DataRow row in data.Rows)
            {
                khachHangList.Add(new KhachHang(row));
            }
            return khachHangList;
        }

        public bool KiemTraDaTonTaiKhachHang(string text)
        {
            return provider.ExecuteQuery("select * from KhachHang where CMND = N'" + text + "'").Rows.Count > 0;
        }

        //Sửa thông tin khách hàng
        public bool SuaKhachHang(KhachHang khachHang)
        {
            string query = "SuaKhachHang @maKhachHang , @tenKhachHang , @cmnd , @soDienThoai , @email , @diaChi , @quocTich , @ngaySinh , @gioiTinh";
            return provider.ExecuteNonQuery(query, new object[] {khachHang.MaKhachHang , khachHang.TenKhachHang, khachHang.Cmnd, khachHang.SoDienThoai, khachHang.Email, khachHang.DiaChi, khachHang.QuocTich, khachHang.NgaySinh, khachHang.GioiTinh }) > 0;
        }


    }
}
