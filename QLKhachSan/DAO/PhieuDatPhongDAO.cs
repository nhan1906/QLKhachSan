using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuDatPhongDAO
    {
        #region Singleton
        private static PhieuDatPhongDAO instance;

        public static PhieuDatPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDatPhongDAO();
                return instance;
            }
        }

        private PhieuDatPhongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool KiemTraMaDaTonTai(string maDatPhong)
        {
            return provider.ExecuteQuery("Select * from PhieuDatPhong where maDatPhong = N'" + maDatPhong + "'").Rows.Count > 0;
        }

        public bool TaoPhieuDatPhong(PhieuDatPhong phieuDatPhong)
        {
            string query = "InsertPhieuDatPhong @maDatPhong , @tenNguoiDat , @sdtNguoiDat , @emailNguoiDat , @ngayDen , @ngayDi , @yeuCauKhac";
            if (provider.ExecuteNonQuery(query, new object[] { phieuDatPhong.MaDatPhong, phieuDatPhong.TenNguoiDat, phieuDatPhong.SdtNguoiDat, phieuDatPhong.EmailNguoiDat, phieuDatPhong.NgayDen, phieuDatPhong.NgayDi , phieuDatPhong.YeuCauKhac}) > 0)
            {
                return true;
            }
            return false;
        }

        public bool HuyDatPhong(string maDatPhong)
        {
            string query = "update PhieuDatPhong Set tinhTrang = -1 where maDatPhong = N'" + maDatPhong + "'";
            return provider.ExecuteNonQuery(query) > 0;
        }

        public PhieuDatPhong LayPhieuDatPhongTheoMa(string maDatPhong)
        {
            string query = "Select * from PhieuDatPhong where maDatPhong = N'" + maDatPhong + "'";
            DataTable data = provider.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                return new PhieuDatPhong(row);
            }
            return null;
        }
    }
}
