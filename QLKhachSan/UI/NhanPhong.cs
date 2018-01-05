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
    public partial class NhanPhong : MetroForm
    {

        private Phong phong = null;
        private LoaiPhongService loaiPhongService = LoaiPhongService.Instance;
        private PhieuDatPhongService phieuDatPhongService = PhieuDatPhongService.Instance;
        private LoaiGiuongService loaiGiuongService = LoaiGiuongService.Instance;
        private KhachHangService khachHangServide = KhachHangService.Instance;
        private PhongService phongService = PhongService.Instance;

        private PhieuNhanPhongService phieuNhanPhongService = PhieuNhanPhongService.Instance;

        private NhanVien nhanVien;

        public NhanPhong(Phong phong , NhanVien nhanVien)
        {
            InitializeComponent();

            //
            checkOut.Value = DateTime.Now.AddDays(1);

            this.phong = phong;
            this.nhanVien = nhanVien;
            LoaiPhong loaiPhong = loaiPhongService.LayLoaiPhongBangMa(phong.MaLoaiPhong);
            nmSoNguoi.Minimum = Convert.ToInt32(phong.MaLoaiPhong.ToCharArray()[3].ToString());
            nmSoNguoi.Maximum = loaiPhong.SoNguoiToiDa;

            lbMaPhong.Text = phong.MaPhong.ToString();
            loaiPhongService.HienThiComboBox(cmbLoaiPhong);
            cmbLoaiPhong.SelectedIndex = cmbLoaiPhong.FindString(loaiPhong.MaLoaiPhong);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn hủy nhận phòng không", "Thông báo", MessageBoxButtons.OK);
        }
        

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (phieuDatPhongService.PhongKhongTheDat(phong.MaPhong, DateTime.Now , checkOut.Value))
            {
                lbMaPhong.Text = phong.MaPhong + " Không thể đặt";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ChonPhongDatPhong f = new ChonPhongDatPhong(this , phong.MaLoaiPhong, DateTime.Now, checkOut.Value);
            f.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nmSoNguoi.Value) == lsvKhachHang.Items.Count)
                return;
            ThemKhachHang f = new ThemKhachHang(this);
            f.ShowDialog();
        }

        public void GetValueFormKhachHang(string maKH)
        {
            lbMaPhong.Text = maKH;
            khachHangServide.ThemKhachHangVaoDSDK(lsvKhachHang ,maKH);
        }

        public void ThayDoiPhong(int maPhong)
        {
            lbMaPhong.Text = maPhong.ToString();
            phong = phongService.LayPhongBangMaPhong(maPhong);
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (lsvKhachHang.Items.Count != (int)nmSoNguoi.Value)
            {
                notify.TitleText = "Nhập đầy đủ khách";
                notify.Popup();
                return;
            }
            PhieuNhanPhong phieuNhanPhong = new PhieuNhanPhong();
            phieuNhanPhong.SoNguoi = (int)nmSoNguoi.Value;
            phieuNhanPhong.SoTreEm = (int)nmTreEm.Value;
            phieuNhanPhong.MaHD = GenerateIdHD();
            phieuNhanPhong.CheckIn = DateTime.Now;
            phieuNhanPhong.CheckOut = checkOut.Value;
            phieuNhanPhong.MaPhong = phong.MaPhong;
            phieuNhanPhong.MaNhanPhong = GenerateId();
            phieuNhanPhong.DatCoc = (float) Convert.ToDouble(txtDatCoc.Text.ToString());
            phieuNhanPhongService.ThemPhieuDatPhong(phieuNhanPhong, lsvKhachHang, notify ,nhanVien);
        }

        private string GenerateId()
        {
            string maNhanPhong = null;
            while (true)
            {
                maNhanPhong = ConvertToBase(DateTime.Now.Ticks, 36).Substring(6).ToUpper();
                if (!phieuDatPhongService.KiemTraDaTonTaiMa(maNhanPhong))
                    break;
            }
            //throw new NotImplementedException(); // ca ma nhan phong va ma dat phong
            return maNhanPhong;
        }

        private string GenerateIdHD()
        {
            string maHD = null;
            while (true)
            {
                maHD = ConvertToBase(DateTime.Now.Ticks, 36).Substring(6).ToUpper();
                if (!ChiTietHoatDongService.Instance.KiemTraDaTonTaiMa(maHD))
                    break;
            }
            //throw new NotImplementedException(); // ca ma nhan phong va ma dat phong
            return maHD;
        }

        private static String ConvertToBase(long num, int nbase)
        {
            String chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // check if we can convert to another base
            if (nbase < 2 || nbase > chars.Length)
                return "";

            long r;
            String newNumber = "";

            // in r we have the offset of the char that was converted to the new base
            while (num >= nbase)
            {
                r = num % nbase;
                newNumber = chars[(int)r] + newNumber;
                num = num / nbase;
            }
            // the last number to convert
            newNumber = chars[(int)num] + newNumber;

            return newNumber.ToLower();
        }
    }
}
