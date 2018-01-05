using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiHoatDongDAO
    {
        #region Singleton
        private static LoaiHoatDongDAO instance;

        public static LoaiHoatDongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiHoatDongDAO();
                return instance;
            }
        }

        private LoaiHoatDongDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public int LayMaCuaLoaiHoatDong(string tenLoaiHoatDong)
        {
            return new LoaiHoatDong(provider.ExecuteQuery("select * from LoaiHoatDong where tenLoaiHoatDong = N'" + tenLoaiHoatDong + "'").Rows[0]).IdLoaiHoatDong;
        }
    }
}
