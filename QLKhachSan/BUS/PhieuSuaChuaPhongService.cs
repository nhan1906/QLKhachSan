using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using MetroFramework.Controls;

namespace BUS
{
    public class PhieuSuaChuaPhongService
    {
        #region Singleton
        private static PhieuSuaChuaPhongService instance;

        public static PhieuSuaChuaPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuSuaChuaPhongService();
                return instance;
            }
        }


        private PhieuSuaChuaPhongService() { }
        #endregion

        private PhieuSuaChuaDAO data = PhieuSuaChuaDAO.Instance;
        private PhongDAO phongData = PhongDAO.Instance;

        public void ThemPhieuSuaChuaPhong(PhieuSuaChua phieuSuaChua , PopupNotifier notify)
        {
            if (data.ThemPhieuSuaChua(phieuSuaChua))
            {
                phongData.CapNhatTrangThaiPhong("Đang sửa", phieuSuaChua.MaPhong);
                notify.TitleText = "Đã cập nhật trạng thái sửa phòng " + phieuSuaChua.MaPhong;
                notify.Popup();
            }
        }

        public void CapNhatChiPhiSuaPhong(MetroTextBox txtChiPhiSuaPhong, int maPhong , PopupNotifier notify)
        {
            float tongTienSC = (float) Convert.ToDouble(txtChiPhiSuaPhong.Text);
            if(data.CapNhatPhieuSuaChua(tongTienSC, maPhong))
            {
                phongData.CapNhatTrangThaiPhong("Trống", maPhong);
                notify.TitleText = "Đã sửa phòng " + maPhong + " thành công";
                notify.Popup();
            }
        }
    }
}
