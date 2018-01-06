using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace UI
{
    public partial class NhanPhong_UC : UserControl
    {

        private DichVuService dichVuService = DichVuService.Instance;
        private PhieuSuDungDichVuService phieuSuDungDichVu = PhieuSuDungDichVuService.Instance;
        private PhieuDatCocTienPhongService phieuDatCocService = PhieuDatCocTienPhongService.Instance;

        //Tính tiền ở đây
        private ChiTietHoatDongService ctHDService = ChiTietHoatDongService.Instance;

        public int sl = 0;

        private static NhanPhong_UC instance;
        public delegate void SendMessage(Panel Message);
        public SendMessage Sender;
        private Panel pnContaner;
        private Phong phong;
        private void GetMessage(Panel Message)
        {
            pnContaner = Message;
        }
        public static NhanPhong_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanPhong_UC(null);
                return instance;
            }
        }


        public NhanPhong_UC(Phong phong)
        {
            InitializeComponent();
            instance = this;
            Sender = new SendMessage(GetMessage);
            CapNhat(phong);
        }

        public void CapNhat(Phong phongMoi)
        {
            this.phong = phongMoi;
            //Cập nhật cơ bản 
            dichVuService.HienThiLenFlowLayoutPanel(flowPanelNhomDV , flpDichVu);

            // Cập nhật thông tin phòng
            lbPhong.Text = "Tầng " + phong.TangThu + " - " + phong.MaPhong + " - " + phong.LoaiPhong.TenChatLuong + " " + phong.LoaiPhong.TenLoaiGiuong;
            dichVuService.HienThiThongTinPhongDangSuDung(phong, txtTienDichVu);
            phieuDatCocService.HienthiTongTienDaDatCocPhongDangSuDung(phong, txtDatCoc);
            txtMaHoatDong.Text = phong.MaHDHienTai;

            ctHDService.TinhTienPhong(txtTienPhong , phong);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            DichVu dichVu = (DichVu)((Button)sender).Tag;
            SoLuongDV f = new SoLuongDV(dichVu);
            f.ShowDialog();
            if(sl != 0)
            {
                phieuSuDungDichVu.ThemPhieuSuDungDichVu(dichVu, sl, phong);
                sl = 0;
            }
        }

        private void flpDichVu_ControlAdded(object sender, ControlEventArgs e)
        {
            Button dv = (Button) e.Control;
            dv.Click += Btn_Click;
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            ChuyenPhongForm f = new ChuyenPhongForm(phong);
            f.ShowDialog();
        }

        private void txtPhuThu_ButtonClick(object sender, EventArgs e)
        {
            PhuThuForm f = new PhuThuForm();
            f.ShowDialog();
        }
    }
}
