using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BangHienTrangPhongDatService
    {
        #region Singleton
        private static BangHienTrangPhongDatService instance;

        public static BangHienTrangPhongDatService Instance
        {
            get
            {
                if (instance == null)
                    instance = new BangHienTrangPhongDatService();
                return instance;
            }
        }


        private BangHienTrangPhongDatService() { }
        #endregion

        private BangHienTrangPhongDatDAO data = BangHienTrangPhongDatDAO.Instance;

        public void HienThiDataGridView(BindingSource binding, DateTime checkIn , DateTime checkOut)
        {
            binding.DataSource = data.LayDanhSachHienTrangPhong(checkIn, checkOut);
        }

    }
}
