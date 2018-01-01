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
        private ChiTietDatPhongService chiTietDatPhongService = ChiTietDatPhongService.Instance;
        private FormatViewServices formatView = FormatViewServices.Instance;

        private List<Button> chonPhongs = new List<Button>();
        string maDatPhong;
        PhieuDatPhong phieuDatPhong = null;

        public ThongBaoDatPhongThanhCong(string maDatPhong)
        {
            InitializeComponent();
            formatView.FormatDataGridView(dtgvDat);
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

            HienThiView();
        }

        private void HienThiView()
        {
            for(int i = 0; i< 5; i++)
            {
                dtgvDat.Controls.Clear();
            }

            chiTietDatPhongService.HienThiDataGridView(dtgvDat, maDatPhong);
            int rowIndex = 0;
            foreach(DataGridViewRow row in dtgvDat.Rows)
            {
                Button button = new Button();
                button.Text = "Chọn phòng";
                button.Location = new Point(150, 50 + rowIndex * 30 + 3);
                button.Tag = rowIndex;
                dtgvDat.Controls.Add(button);
                button.Click += ChonPhongTheoLoai;
                rowIndex++;
            }

        }

        private void ChonPhongTheoLoai(object sender, EventArgs e)
        {
            int index = (int)((Button)sender).Tag;
            string maLoaiPhong = dtgvDat.Rows[index].Cells[0].Value.ToString();
            ChonPhongDatPhong f = new ChonPhongDatPhong(maDatPhong, maLoaiPhong);
            f.ShowDialog();

        }

        private void btnHuyDatPhong_Click(object sender, EventArgs e)
        {
            phieuDatPhongService.HuyPhieuDatPhong(maDatPhong);
        }
    }
}
