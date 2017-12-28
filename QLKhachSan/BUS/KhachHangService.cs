using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangService
    {
        #region Singleton
        private static KhachHangService instance;

        public static KhachHangService Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangService();
                return instance;
            }
        }

        private KhachHangService() { }

        #endregion

        private KhachHangDAO data = KhachHangDAO.Instance;
    }
}
