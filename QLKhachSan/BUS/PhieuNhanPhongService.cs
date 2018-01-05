using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace BUS
{
    public class PhieuNhanPhongService
    {
        #region Singleton
        private static PhieuNhanPhongService instance;

        public static PhieuNhanPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhanPhongService();
                return instance;
            }
        }


        private PhieuNhanPhongService() { }
        #endregion

        private PhieuNhanPhongDAO data = PhieuNhanPhongDAO.Instance;
        private PhongDAO phongData = PhongDAO.Instance;
        private KhachHangOPhongDAO khData = KhachHangOPhongDAO.Instance;
        private LoaiHoatDongDAO loaiHDData = LoaiHoatDongDAO.Instance;
        private ChiTietHoatDongDAO ctHDData = ChiTietHoatDongDAO.Instance;
        private PhieuDatCocTienPhongDAO phieuDatCocData = PhieuDatCocTienPhongDAO.Instance;

        public void ThemPhieuDatPhong(PhieuNhanPhong phieuNhanPhong, MetroListView lsvKhachHang, PopupNotifier notify , NhanVien nhanVien)
        {
            //Thêm phiếu nhận phòng , update phòng sang trang thái N'Nhận phòng'// Thêm khách hàng
            if (data.ThemPhieuNhanPhong(phieuNhanPhong))
            {
                //Cập nhật trạng thái phòng
                foreach (ListViewItem item in lsvKhachHang.Items)
                {
                    //lấy mã khách hàng ra
                    string maKH = item.SubItems[0].Text;
                    KhachHangOPhong kh = new KhachHangOPhong();
                    kh.MaNhanPhong = phieuNhanPhong.MaNhanPhong;
                    kh.MaPhong = phieuNhanPhong.MaPhong;
                    kh.MaKH = maKH;
                    khData.ThemKhachHangVaoPhong(kh);
                }

                ChiTietHoatDong ctHD = new ChiTietHoatDong();
                ctHD.MaHD = phieuNhanPhong.MaHD;
                ctHD.MaLQ = phieuNhanPhong.MaNhanPhong;
                ctHD.IdLoaiHoatDong = loaiHDData.LayMaCuaLoaiHoatDong("Nhận phòng");
                ctHDData.ThemChiTietHoatDong(ctHD);
                if(phieuNhanPhong.DatCoc != 0)
                {
                    PhieuDatCocTienPhong phieu = new PhieuDatCocTienPhong();
                    phieu.SoTien = phieuNhanPhong.DatCoc;
                    phieu.MaPhong = phieuNhanPhong.MaPhong;
                    phieu.ThoiGianNhan = DateTime.Now;
                    phieu.MaNV = nhanVien.MaNV;
                    //Thêm phiếu đặt cọc
                    phieuDatCocData.ThemPhieuDatCocTienPhong(phieu);
                    phieu = phieuDatCocData.LayMaVuaDatDoc();

                    // thêm hoạt động đặt cọc
                    ctHD.MaLQ = phieu.MaDC;
                    ctHD.IdLoaiHoatDong = loaiHDData.LayMaCuaLoaiHoatDong("Đặt cọc");
                    ctHDData.ThemChiTietHoatDong(ctHD);

                }

                phongData.CapNhatTrangThaiPhong("Nhận phòng", phieuNhanPhong.MaPhong);
                phongData.CapNhatMaHDHienTai(phieuNhanPhong.MaHD , phieuNhanPhong.MaPhong);
                notify.TitleText = "Nhận phòng thành công.";
                notify.Popup();
            }
        }
    }
}
