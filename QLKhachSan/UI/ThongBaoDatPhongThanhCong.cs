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
    public partial class ThongBaoDatPhongThanhCong : MetroForm
    {

        private PhieuDatPhongService phieuDatPhongService = PhieuDatPhongService.Instance;
        string maDatPhong;
        PhieuDatPhong phieuDatPhong = null;

        public ThongBaoDatPhongThanhCong(string maDatPhong)
        {
            InitializeComponent();
            this.maDatPhong = maDatPhong;
            phieuDatPhong = phieuDatPhongService.LayChiTietPhieuDat(maDatPhong);
            CapNhatThongTinBang(phieuDatPhong);
        }

        private void CapNhatThongTinBang(PhieuDatPhong phieuDatPhong)
        {
            lbNgayDen.Text = "NGÀY ĐẾN: " + phieuDatPhong.NgayDen.Value.ToString();
            lbNgayDi.Text = "NGÀY ĐI: " + phieuDatPhong.NgayDi.Value.ToString();
            lbSoDem.Text = "SỐ ĐÊM: " + (phieuDatPhong.NgayDi - phieuDatPhong.NgayDen).Value.Days;

            lbTen.Text = "HỌ TÊN: " + phieuDatPhong.TenNguoiDat;
            lbSdt.Text = "ĐIỆN THOẠI: " + phieuDatPhong.SdtNguoiDat;
            lbEmail.Text = "THƯ ĐIỆN TỬ: " + phieuDatPhong.EmailNguoiDat;
            lbTYeuCauKhac.Text = "" + phieuDatPhong.YeuCauKhac;
        }
    }
}
