using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiPhongDAO
    {
        #region Singleton
        private static LoaiPhongDAO instance;

        public static LoaiPhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongDAO();
                return instance;
            }
        }

        private LoaiPhongDAO() { }

        #endregion

        private DataProvider provider = DataProvider.Instance;

    }
}
