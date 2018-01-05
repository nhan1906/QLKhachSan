﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhongDAO
    {
        #region Singleton
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongDAO();
                return instance;
            }
        }

        private PhongDAO() { }

        #endregion

        private DataProvider provider = DataProvider.Instance;

        public List<Phong> LayDanhSachTatCaPhong()
        {
            List<Phong> list = new List<Phong>();
            DataTable data = provider.ExecuteQuery("Select * from Phong");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Phong(row));
            }
            return list;
        }

        public List<Phong> LocDanhSachPhong(string maLoaiPhong , string tangThu , string tenTinhTrangPhong)
        {
            List<Phong> list = new List<Phong>();
            string query = "select * from Phong where maLoaiPhong like N'" + maLoaiPhong + "' and tangThu like N'" + tangThu + "' and tenTinhTrangPhong like N'" + tenTinhTrangPhong + "'";
            DataTable data = provider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Phong(row));
            }
            return list;
        }

        public bool CapNhatDonDepPhong(int i, int maPhong)
        {
            return provider.ExecuteNonQuery("update Phong set ban = " + i + " where maPhong = " + maPhong) > 0;
        }

        public int LayPhongTiepTheoCuaTang(int tangThu)
        {
            return (int)provider.ExecuteScalar("SELECT ISNULL(MAX(phongSo), 0) from Phong WHERE tangThu = " + tangThu);
        }

        public bool ThemPhong(Phong phong)
        {
            if(provider.ExecuteNonQuery("INSERT INTO Phong ( maPhong , phongSo , tangThu , maLoaiPhong , tenTinhTrangPhong) VALUES (" + phong.MaPhong + " , " + phong.PhongSo + " , " + phong.TangThu + " , N'" + phong.MaLoaiPhong+ "' , N'" + phong.TenTinhTrangPhong + "' )") > 0)
            {
                TangDAO.Instance.CapNhatTang(phong.TangThu);
                return true;
            }
            return false;
        }

        public Phong LayPhongBangMaPhong(int maPhong)
        {
            DataTable data = provider.ExecuteQuery("select * from Phong where maPhong = " + maPhong);
            if (data.Rows.Count > 0)
                return new Phong(data.Rows[0]);
            return null;
        }

        public bool CapNhatTrangThaiPhong(string tenTinhTrangPhong, int maPhong)
        {
            return provider.ExecuteNonQuery("update Phong set tenTinhTrangPhong = N'" + tenTinhTrangPhong + "' where maPhong = " + maPhong) > 0;
        }

        public bool CapNhatMaHDHienTai(string maHD, int maPhong)
        {
            return provider.ExecuteNonQuery("update Phong set maHDHienTai = N'" + maHD + "' where maPhong = " + maPhong) > 0;
        }
    }
}
