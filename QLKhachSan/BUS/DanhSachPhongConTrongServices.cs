using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

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

        private PhieuDatPhongDAO phieuDatPhongDAO = PhieuDatPhongDAO.Instance;
        private ChiTietDatPhongDAO chiTietDatPhongDAO = ChiTietDatPhongDAO.Instance;

        public int LaySoPhongDaDatTheoLoai(string maDatPhong, string maLoaiPhong)
        {
            return chiTietDatPhongDAO.LaySoPhongDaDat(maDatPhong, maLoaiPhong);
        }

        public void HienThiDanhSachPhongTheoMaLoai(MetroListView lsvChonPhong, string maDatPhong, string maLoaiPhong)
        {
            PhieuDatPhong phieuDatPhong = phieuDatPhongDAO.LayPhieuDatPhongTheoMa(maDatPhong);
            List<Phong> phongs = data.DanhSachPhongTrongTheoLoai((DateTime)phieuDatPhong.NgayDen , (DateTime)phieuDatPhong.NgayDi , maLoaiPhong);
            foreach (Phong phong in phongs)
                lsvChonPhong.Items.Add(phong.MaPhong.ToString());
            phongs = chiTietDatPhongDAO.DanhSachPhongDaDat(maDatPhong, maLoaiPhong);
            foreach (Phong phong in phongs)
            {
                ListViewItem item = new ListViewItem();
                item.Checked = true;
                item.Text = phong.MaPhong.ToString();
                lsvChonPhong.Items.Add(item);
            }
        }

        public void HienThiDanhSachPhongTheoMaLoai(MetroListView lsvChonPhong, string maLoaiPhong, DateTime checkIn , DateTime checkOut)
        {

            List<Phong> phongs = data.DanhSachPhongTrongTheoLoai(checkIn, checkOut, maLoaiPhong);
            foreach (Phong phong in phongs)
                lsvChonPhong.Items.Add(phong.MaPhong.ToString());
        }

        private DanhSachPhongConTrongDAO data = DanhSachPhongConTrongDAO.Instance;

        public List<Phong> DanhSachPhongTheoLoaiPhong(int soPhong ,DateTime checkIn , DateTime checkOut , string maLoaiPhong)
        {
            return data.DanhSachPhongTrongTheoLoai(soPhong ,checkIn , checkOut, maLoaiPhong);
        }
    }
}
