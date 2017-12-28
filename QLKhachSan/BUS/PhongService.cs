using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhongService
    {
        #region Singleton
        private static PhongService instance;

        public static PhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongService();
                return instance;
            }
        }

        private PhongService() { }

        #endregion

        private PhongDAO data = PhongDAO.Instance;


        public void HienThiDanhSachPhong(FlowLayoutPanel flp)
        {
            
        }
        
    }
}
