using DTO;
using System;
using System.Collections.Generic;
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
            return new List<Phong>(12);
        }

    }
}
