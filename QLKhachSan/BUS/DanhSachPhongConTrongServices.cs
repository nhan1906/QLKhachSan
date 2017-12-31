using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DanhSachPhongConTrongServices
    {
        #region Singleton
        private static DanhSachPhongConTrongServices _instance;

        public static DanhSachPhongConTrongServices Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DanhSachPhongConTrongServices();
                return _instance;
            }
        }

        private DanhSachPhongConTrongServices() { }
        #endregion

        private DanhSachPhongConTrongDAO data = DanhSachPhongConTrongDAO.Instance;

        public List<Phong> DanhSachPhongTheoLoaiPhong(DateTime checkIn , DateTime checkOut , string maLoaiPhong)
        {
            return data.DanhSachPhongTrongTheoLoai(checkIn , checkOut, maLoaiPhong);
        }
    }
}
