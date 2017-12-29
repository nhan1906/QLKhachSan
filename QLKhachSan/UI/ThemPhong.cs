using BUS;
using DTO;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ThemPhong : MetroForm
    {

        private TangService tangService = TangService.Instance;
        private LoaiPhongService loaiPhongService = LoaiPhongService.Instance;
        private PhongService phongService = PhongService.Instance;

        public ThemPhong()
        {
            InitializeComponent();
            tangService.HienThiComboBox(cmbTang);
            loaiPhongService.HienThiComboBox(cmbLoaiPhong);
        }

        private void cmbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            phongService.ThayDoiMaPhong(lbMaPhong, cmbTang);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }



        private void Save()
        {
            int maPhong = Convert.ToInt32(lbMaPhong.Text);
            int phongSo = maPhong % 100;
            int tangThu = ((Tang)cmbTang.SelectedItem).TangThu;
            string maLoaiPhong = ((LoaiPhong)cmbLoaiPhong.SelectedItem).MaLoaiPhong;
            string tenTinhTrangPhong = "Trống";
            Phong phong = new Phong();
            phong.MaPhong = maPhong;
            phong.PhongSo = phongSo;
            phong.TangThu = tangThu;
            phong.MaLoaiPhong = maLoaiPhong;
            phong.TenTinhTrangPhong = tenTinhTrangPhong;
            if (phongService.ThemPhong(phong))
            {
                //Thành công
                phongService.ThayDoiMaPhong(lbMaPhong, cmbTang);
            }
        }

        private void btnSaveAndContinue_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
