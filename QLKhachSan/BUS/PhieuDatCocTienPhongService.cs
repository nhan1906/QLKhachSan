using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MetroFramework.Controls;

namespace BUS
{
    public class PhieuDatCocTienPhongService
    {
        #region Singleton
        private static PhieuDatCocTienPhongService instance;

        public static PhieuDatCocTienPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDatCocTienPhongService();
                return instance;
            }
        }


        private PhieuDatCocTienPhongService() { }
        #endregion

        private PhieuDatCocTienPhongDAO data = PhieuDatCocTienPhongDAO.Instance;

        public void HienthiTongTienDaDatCocPhongDangSuDung(Phong phong, MetroTextBox txtDatCoc)
        {
            float tongTienDatCoc = data.TongtienDatCocTheoMaHD(phong.MaHDHienTai);
            txtDatCoc.Text = tongTienDatCoc.ToString();
        }
    }
}
