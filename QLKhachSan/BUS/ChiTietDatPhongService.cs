using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietDatPhongService
    {
        #region Singleton
        private static ChiTietDatPhongService instance;

        public static ChiTietDatPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietDatPhongService();
                return instance;
            }
        }


        private ChiTietDatPhongService() { }
        #endregion

        private ChiTietDatPhongDAO data = ChiTietDatPhongDAO.Instance;

        public bool ThemChiTietDatPhong(Phong phong ,string maDatPhong)
        {
            return data.ThemPhongDatPhong(phong, maDatPhong);
        }

    }
}
