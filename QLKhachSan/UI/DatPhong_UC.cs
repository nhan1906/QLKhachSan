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
using MetroFramework.Controls;

namespace UI
{
    public partial class DatPhong_UC : UserControl
    {

        bool isFirst = false;
        BangHienTrangPhongDatService bangHienTrangPhongService = BangHienTrangPhongDatService.Instance;
        FormatViewServices formatViewService = FormatViewServices.Instance;
        DatPhongService datPhongService = DatPhongService.Instance;
        DanhSachPhongConTrongServices danhSachPhongConTrongService = DanhSachPhongConTrongServices.Instance;

        BindingSource bindingList = new BindingSource();
        List<BangHienTrangPhongDat> bangHienTrangList = new List<BangHienTrangPhongDat>();
        List<ComboBox> cmbChonSLList = new List<ComboBox>();
        
        List<int> numberIndex = new List<int>();
        ChiTietDatPhongService chiTietDatPhongService = ChiTietDatPhongService.Instance;
        private PhieuDatPhongService phieuDatPhongService = PhieuDatPhongService.Instance;

        private static DatPhong_UC instance;

        public DatPhong_UC()
        {
            InitializeComponent();
            checkIn.MinDate = DateTime.Now;
            formatViewService.FormatDataGridView(dtgvTinhTrang);
            dtgvTinhTrang.DataSource = bindingList;
            bindingList.DataSource = bangHienTrangList;
            HienThiView();
            GenerateId();
        }

        private void GenerateId()
        {
            string maDatPhong = null;
            while(true){
                maDatPhong = ConvertToBase(DateTime.Now.Ticks, 36).Substring(6).ToUpper();
                if (!phieuDatPhongService.KiemTraDaTonTaiMa(maDatPhong))
                    break;
            }
            txtMaDatPhong.Text = maDatPhong;
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
        public static DatPhong_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatPhong_UC();
                return instance;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            errorTime.SetError(checkOut, "");
            if (checkOut.Value <= checkIn.Value)
            {
                errorTime.SetError(checkOut, "Sai");
                return;
            }
            HienThiView();
        }


        private void HienThiView()
        {
            bangHienTrangList.Clear();
            cmbChonSLList.Clear();
            for(int i = 0;i < 5; i++)
            {

                dtgvTinhTrang.Controls.Clear();
            }


            numberIndex.Clear();

            bangHienTrangPhongService.HienThiDataGridView(bindingList, checkIn.Value, checkOut.Value);
            if (!isFirst)
            {

                datPhongService.DrawingDataGridView(dtgvTinhTrang);
                isFirst = true;
            }
            int widthcmb = 400;
            int index = 0;
            foreach(DataGridViewRow row in dtgvTinhTrang.Rows)
            {
                

                int conPhong = (int)row.Cells[6].Value;
                numberIndex.Add(conPhong);
                string maLoaiPhong = row.Cells[1].Value.ToString();
                if (conPhong == 0)
                {
                    row.Cells[7].Value = "Hết phòng";
                }
                else
                {
                    MetroComboBox cmb = new MetroComboBox();
                    for (int i = 0; i <= conPhong; i++)
                    {
                        cmb.Items.Add(i);
                    }
                    cmb.Location = new Point(610, 50 + 90 *index  + 45 - 15);
                    dtgvTinhTrang.Controls.Add(cmb);
                    cmb.Tag = index;
                    if (cmb.Items.Count == 0)
                        return;
                    cmb.SelectedIndex = 0;
                    cmb.Click += Cmb_SelectedIndexChanged;
                    cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
                    cmbChonSLList.Add(cmb);
                }
                index++;
            }
            dtgvTinhTrang.Refresh();
            
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = (int)((ComboBox)sender).Tag;
            XoaChonDtgv();
            dtgvTinhTrang.Rows[rowIndex].Selected = true;
        }

        public void XoaChonDtgv()
        {
            foreach (DataGridViewRow row in dtgvTinhTrang.Rows)
            {
                row.Selected = false;
            }
        }

        private void checkIn_ValueChanged(object sender, EventArgs e)
        {
            if (checkIn.Value > checkOut.Value)
                checkOut.Value = checkIn.Value.AddDays(1);
            checkOut.MinDate = checkIn.Value;
        }

        private void txtMaDatPhong_ButtonClick(object sender, EventArgs e)
        {
            GenerateId();
        }

        //Thong tin khach dat

        public bool ValidatingInfoKhachhang()
        {
            bool isNotError = true;

            //Kiểm tra tính hợp lệ của tên
            if (txtName.Text == "")
            {
                isNotError = false;
                error.SetError(txtName, "Bắt buộc");
            }

            //Kiểm tra tính hợp lệ của số điện thoại
            if (txtSoDienThoai.Text == "")
            {
                isNotError = false;
                error.SetError(txtSoDienThoai, "Bắt buộc");
            }

            //Kiểm tra tính hợp lệ của email
            if (txtEmail.Text == "")
            {
                isNotError = false;
                error.SetError(txtEmail, "Bắt buộc");
            }
            else
            {
                if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    isNotError = false;
                    error.SetError(txtEmail, "Sai format");
                }
            }

            return isNotError;
        }

        public void SetDefaultErrorProvider()
        {
            error.SetError(txtName, "");
            error.SetError(txtSoDienThoai, "");
            error.SetError(txtEmail, "");
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            SetDefaultErrorProvider();
            if (ValidatingInfoKhachhang() && DaChonPhongChua())
            {

                string tenKhachHang = txtName.Text.Trim().ToUpperInvariant();
                string soDienThoai = txtSoDienThoai.Text;
                string email = txtEmail.Text;
                string maDatPhong = txtMaDatPhong.Text;
                DateTime ngayDen = checkIn.Value;
                DateTime ngayDi = checkOut.Value;

                //Tạo phiếu
                PhieuDatPhong phieuDatPhong = new PhieuDatPhong();
                phieuDatPhong.MaDatPhong = maDatPhong;
                phieuDatPhong.TenNguoiDat = tenKhachHang;
                phieuDatPhong.SdtNguoiDat = soDienThoai;
                phieuDatPhong.EmailNguoiDat = email;
                phieuDatPhong.YeuCauKhac = rtxtYeuCauKhac.Text;
                phieuDatPhong.NgayDen = ngayDen;
                phieuDatPhong.NgayDi = ngayDi;
                if (phieuDatPhongService.ThemPhieuDatPhong(phieuDatPhong))
                {
                    foreach(ComboBox cmbChonPhong in cmbChonSLList)
                    {
                        int soPhong = cmbChonPhong.SelectedIndex;
                        if (soPhong == 0)
                            continue;
                        int indexRow = (int)cmbChonPhong.Tag;
                        string maLoaiPhong = dtgvTinhTrang.Rows[indexRow].Cells[1].Value.ToString();
                        List<Phong> phongTheoLoai = danhSachPhongConTrongService.DanhSachPhongTheoLoaiPhong(soPhong ,ngayDen, ngayDi, maLoaiPhong);
                        foreach (Phong phong in phongTheoLoai)
                        {
                            chiTietDatPhongService.ThemChiTietDatPhong(phong, maDatPhong);
                        }
                    }

                    ThongBaoDatPhongThanhCong f = new ThongBaoDatPhongThanhCong(maDatPhong);
                    f.ShowDialog();
                    LoadTrang();
                }

            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(sender, e);
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool DaChonPhongChua()
        {
            foreach(ComboBox cmb in cmbChonSLList)
            {
                if (cmb.SelectedIndex != 0)
                    return true;
            }
            MessageBox.Show("Vui long chon phong truoc khi dat", "Thong bao", MessageBoxButtons.OK);
            return false;
        }

        private void LoadTrang()
        {
            HienThiView();
            GenerateId();
            txtEmail.Text = "";
            txtName.Text = "";
            txtSoDienThoai.Text = "";
            rtxtYeuCauKhac.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
