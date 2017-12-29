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
            List<Phong> phongs = data.LayDanhSachTatCaPhong();
            flp.Controls.Clear();
            foreach(Phong phong in phongs)
            {
                RoomExpand room = new RoomExpand();
                flp.Controls.Add(room);
            }
        }

        public bool ThemPhong(Phong phong)
        {
            return data.ThemPhong(phong);
        }

        public void ThayDoiMaPhong(Label lbMaPhong, ComboBox cmbTang)
        {
            Tang tang = (Tang)cmbTang.SelectedItem;
            int phongTiep = data.LayPhongTiepTheoCuaTang(tang.TangThu);
            int maPhong = tang.TangThu * 100 + phongTiep + 1;
            lbMaPhong.Text = maPhong.ToString();
        }
        
        public void LocDanhSachPhong(ComboBox cmbTang , ComboBox cmbLoaiPhong , ComboBox cmbTinhTrangPhong, FlowLayoutPanel flp)
        {
            if(cmbTang.SelectedItem == null || cmbLoaiPhong.SelectedItem == null || cmbTinhTrangPhong.SelectedItem == null)
            {
                return;
            }

            Tang tang = (Tang)cmbTang.SelectedItem;
            LoaiPhong loaiPhong = (LoaiPhong)cmbLoaiPhong.SelectedItem;
            TinhTrangPhong tinhTrangPhong = (TinhTrangPhong)cmbTinhTrangPhong.SelectedItem;

            string tangThu = tang.TangThu.ToString();
            string maLoaiPhong = loaiPhong.MaLoaiPhong;
            string tenTinhTrangPhong = tinhTrangPhong.TenTinhTrangPhong;
            if (tang.TenTang.Equals("---Tất cả---"))
                tangThu = "%";
            if (loaiPhong.MaLoaiPhong.Equals("---Tất cả---"))
                maLoaiPhong = "%";
            if (tinhTrangPhong.TenTinhTrangPhong.Equals("---Tất cả---"))
                tenTinhTrangPhong = "%";
            List<Phong> phongs = data.LocDanhSachPhong(maLoaiPhong, tangThu, tenTinhTrangPhong);
            flp.Controls.Clear();
            foreach (Phong phong in phongs)
            {
                RoomExpand room = new RoomExpand();
                flp.Controls.Add(room);
            }
        }
    }
}
