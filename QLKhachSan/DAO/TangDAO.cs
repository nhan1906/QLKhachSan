using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TangDAO
    {
        #region Singleton
        private static TangDAO instance;

        public static TangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TangDAO();
                return instance;
            }
        }

        private TangDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public List<Tang> LayDanhSachTang()
        {
            List<Tang> list = new List<Tang>();
            DataTable data = provider.ExecuteQuery("Select * from Tang");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Tang(row));
            }
            return list;
        }

        public List<Tang> LayDanhSachTang(int trangThu, int soPhanTuTrang)
        {
            List<Tang> list = new List<Tang>();
            DataTable data = provider.ExecuteQuery("PhanTrangTheo @page , @number" ,new object[] { trangThu, soPhanTuTrang} );
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Tang(row));
            }
            return list;
        }

        public int LayTangTiepTheo()
        {
            string query = "Select Max(tangThu) from Tang";
            int? tangThu = (int?)provider.ExecuteScalar(query);
            if (tangThu == null)
                tangThu = 1;
            else
                tangThu++;
            return (int) tangThu;
        }

        public int LaySoTang()
        {
            return provider.ExecuteQuery("select * from Tang").Rows.Count;
        }

        public bool ThemTang(Tang tang)
        {
            string query = "Insert into Tang (tenTang , tangThu) values ( N'"  + tang.TenTang + "' , " + tang.TangThu + ")";
            return provider.ExecuteNonQuery(query) > 0;
        }

        public bool TangThuDaTonTai(int tangThu)
        {
            string query = "Select * from Tang where tangThu = " + tangThu;
            return provider.ExecuteQuery(query).Rows.Count > 0;
        }

        public bool SuaTang(Tang tang)
        {
            return true;
        }

        public bool XoaTang(Tang tang)
        {
            return true;
        }
    }
}
