using BUS;
using DTO;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ThemKhachHang : MetroForm
    {

        private KhachHangService khachHangService = KhachHangService.Instance;
        private BindingSource bindingList = new BindingSource();
        private FormatViewServices formatView = FormatViewServices.Instance;
        private NhanPhong f;

        public ThemKhachHang(NhanPhong f)
        {
            InitializeComponent();
            InitView();
            this.f = f;
            formatView.FormatDataGridView(dtgvKhachHang);
            dtgvKhachHang.DataSource = bindingList;
            khachHangService.HienThiDataGridView(bindingList);
            khachHangService.HienThiComboBoxCountry(cmbCountry);

        }

        private void InitView()
        {
            txtSdt.KeyPress += TxtSdt_KeyPress;
            txtCMND.KeyPress += TxtCMND_KeyPress;
            txtNgayCapSGT.Mask = "##/##/####";
            txtNgaySinh.Mask = "##/##/####";
            txtTamTruDen.Mask = "##/##/####";
            txtTamTruTu.Mask = "##/##/####";
            txtThoiHanVisa.Mask = "##/##/####";
        }

        private void TxtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCMND.Text.Length == 0)
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) &&!Char.IsLetter(e.KeyChar))
                    e.Handled = true;
                return;
            }
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtSdt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!ValidateThongTin())
            {
                KhachHang khachHang = new KhachHang();
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                khachHang.TenKhachHang = myTI.ToTitleCase(FormatString(txtHoTen.Text));
                khachHang.Cmnd = txtCMND.Text;
                khachHang.HoKhachHang = myTI.ToTitleCase(FormatString(txtHo.Text));
                khachHang.SoDienThoai = txtSdt.Text;
                khachHang.DiaChi = txtDiaChi.Text;
                khachHang.Email = txtEmail.Text;

                if (txtNgaySinh.Text == "  /  /")
                    txtNgaySinh.Text = null;
                else
                {
                    DateTime rs;
                    CultureInfo ci = new CultureInfo("en-IE");
                    if (DateTime.TryParseExact(txtNgaySinh.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
                    {
                        khachHang.NgaySinh = rs;
                    }
                }

                if (txtNgayCapSGT.Text == "  /  /")
                    txtNgayCapSGT.Text = null;
                else
                {
                    DateTime rs;
                    CultureInfo ci = new CultureInfo("en-IE");
                    if (DateTime.TryParseExact(txtNgayCapSGT.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
                    {
                        khachHang.NgayCapCMND = rs;
                    }
                }

                if (txtTamTruDen.Text == "  /  /")
                    txtTamTruDen.Text = null;
                else
                {
                    DateTime rs;
                    CultureInfo ci = new CultureInfo("en-IE");
                    if (DateTime.TryParseExact(txtTamTruDen.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
                    {
                        khachHang.TamTruDen = rs;
                    }
                }


                if (txtTamTruTu.Text == "  /  /")
                    txtTamTruTu.Text = null;
                else
                {
                    DateTime rs;
                    CultureInfo ci = new CultureInfo("en-IE");
                    if (DateTime.TryParseExact(txtTamTruTu.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
                    {
                        khachHang.TamTruTu = rs;
                    }
                }


                if (txtThoiHanVisa.Text == "  /  /")
                    txtThoiHanVisa.Text = null;
                else
                {
                    DateTime rs;
                    CultureInfo ci = new CultureInfo("en-IE");
                    if (DateTime.TryParseExact(txtThoiHanVisa.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
                    {
                        khachHang.ThoiHanViSa = rs;
                    }
                }
                khachHang.NgheNghiep = txtNgheNghiep.Text;
                khachHang.GhiChu = txtGhiChu.Text;
                khachHang.QuocTich = cmbCountry.SelectedItem.ToString();
                khachHang.SoVisa = txtSoViSa.Text;
                khachHangService.ThemKhachHang(khachHang);
                ResetView();
            }
        }
        private void ResetView()
        {
            txtCMND.Text = "";
            txtHoTen.Text = "";
            txtHo.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtNgheNghiep.Text = "";
            txtSoViSa.Text = "";
            txtGhiChu.Text = "";
            txtSdt.Text = "";
            txtThoiHanVisa.Text = "  /  /";
            txtTamTruTu.Text = "  /  /";
            txtTamTruDen.Text = "  /  /";
            txtNgaySinh.Text = "  /  /";
            txtNgayCapSGT.Text = "  /  /";
        }
        
        private string FormatString(string line)
        {
            string newLine = null;
            foreach(string word in line.Trim().Split(' '))
            {
                if (word == "")
                    continue;
                newLine += word.Trim() + " ";
            }
            return newLine.Trim().ToUpper();
        }

        private bool CheckCMNDPassport(string cmnd)
        {
            return false;
        }

        private bool ValidateThongTin()
        {
            bool isError = false;
            SetDefaultError();
            //Các trường nào không được để trống 1 tên kH, 2 số giấy tờ 
            if (txtCMND.Text == "")
            {
                error.SetError(txtCMND, "Bắt buộc");
                isError = true;
            }
            if (txtHo.Text == "")
            {
                error.SetError(txtHo, "Bắt buộc");
                isError = true;
            }
            if (txtHoTen.Text == "")
            {
                error.SetError(txtHoTen, "Bắt buộc");
                isError = true;
            }
            if(txtEmail.Text != "")
            {
                if(IsValidEmail(txtEmail.Text))
                {
                    error.SetError(txtEmail, "Sai email");
                    isError = true;
                }
            }
            
            return isError;
        }

        private void SetDefaultError()
        {
            error.SetError(txtHoTen, "");
            error.SetError(txtCMND, "");
            error.SetError(txtEmail, "");
            error.SetError(txtHo, "");
        }

        private void txtNgayCapSGT_Validating(object sender, CancelEventArgs e)
        {
            CheckNhapNgay(sender, e);
        }

        private void txtNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            CheckNhapNgay(sender, e);
        }

        private void txtTamTruDen_Validating(object sender, CancelEventArgs e)
        {
            CheckNhapNgay(sender, e);
        }

        private void txtTamTruTu_Validating(object sender, CancelEventArgs e)
        {
            CheckNhapNgay(sender, e);
        }

        private void txtThoiHanVisa_Validating(object sender, CancelEventArgs e)
        {
            CheckNhapNgay(sender, e);
        }

        private void CheckNhapNgay(object sender, CancelEventArgs e)
        {
            MaskedTextBox txt = (MaskedTextBox)sender;
            DateTime rs;
            CultureInfo ci = new CultureInfo("en-IE");
            if (txt.Text == "  /  /")
            {
                return;
            }
            else if (!DateTime.TryParseExact(txt.Text, "dd/MM/yyyy", ci, DateTimeStyles.None, out rs))
            {
                e.Cancel = true;
            }
        }

        private void txtCMND_Leave(object sender, EventArgs e)
        {
            error.SetError(txtCMND, "");
            if (khachHangService.KiemTraDaTonTaiKhachHang(txtCMND.Text))
            {
                error.SetError(txtCMND, "Đã tồn tại");
            }
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            khachHangService.HienThiDanhSachKhachHangTheoSoGT(bindingList, txtCMND.Text);
        }

        private void dtgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            f.GetValueFormKhachHang(dtgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
