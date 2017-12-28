using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiPhongService
    {
        #region Singleton
        private static LoaiPhongService instance;

        public static LoaiPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongService();
                return instance;
            }
        }

        private LoaiPhongService() { }

        #endregion

        private LoaiPhongDAO data = LoaiPhongDAO.Instance;

    }
}
