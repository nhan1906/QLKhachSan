using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietDatPhongDAO
    {
        #region Singleton
        private static ChiTietDatPhongDAO instance;

        public static ChiTietDatPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietDatPhongDAO();
                return instance;
            }
        }

        private ChiTietDatPhongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemPhongDatPhong(Phong phong, string maDatPhong)
        {
            string query = "InsertChiTietDatPhong @maDatPhong , @maPhong , @maLoaiPhong";
            return provider.ExecuteNonQuery(query, new object[] { maDatPhong, phong.MaPhong , phong.MaLoaiPhong }) > 0;
        }

        public List<ChiTietDatPhong> LayDanhSachDatPhong(string maDatPhong)
        {
            List<ChiTietDatPhong> list = new List<ChiTietDatPhong>();
            DataTable data = provider.ExecuteQuery("select * from ChiTietDatPhong where maDatPhong = N'" + maDatPhong + "'");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new ChiTietDatPhong(row));
            }
            return list;
        }

        public int LaySoPhongDaDat(string maDatPhong, string maLoaiPhong)
        {
            string query = "select Count(*) from ChiTietDatPhong where maDatPhong = N'" + maDatPhong + "' and maLoaiPhong = N'" + maLoaiPhong + "' ";
            return (int)provider.ExecuteScalar(query);
        }

        public List<int> DanhSachPhongDaDatTheoLoai(string maDatPhong , string maLoaiPhong)
        {
            List<int> maPhongList = new List<int>();
            string query = "select * from ChiTietDatPhong where maDatPhong = N'" + maDatPhong + "' and maLoaiPhong = N'" + maLoaiPhong + "' ";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                maPhongList.Add((int)row["maPhong"]);
            }
            return maPhongList;
        }

        public List<Phong> DanhSachPhongDaDat(string maDatPhong, string maLoaiPhong)
        {
            List<Phong> dsPhong = new List<Phong>();
            string query = "Select * from Phong inner join ChiTietDatPhong on Phong.maPhong = ChiTietDatPhong.maPhong where maDatPhong = N'" + maDatPhong + "' and ChiTietDatPhong.maLoaiPhong = N'" + maLoaiPhong + "'";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                dsPhong.Add(new Phong(row));
            }
            return dsPhong;
        }
    }
}
