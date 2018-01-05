using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienService
    {
        #region Singleton
        private static NhanVienService instance;

        public static NhanVienService Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienService();
                return instance;
            }
        }


        private NhanVienService() { }
        #endregion

        private NhanVienDAO data = NhanVienDAO.Instance;
    }
}
