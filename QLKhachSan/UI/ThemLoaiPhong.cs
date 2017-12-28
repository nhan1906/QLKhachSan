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
using MetroFramework.Controls;
using DTO;

namespace UI
{
    public partial class ThemLoaiPhong : UserControl
    {

        private ChatLuongService chatLuongService = ChatLuongService.Instance;
        private LoaiGiuongService loaiGiuongService = LoaiGiuongService.Instance;
        private LoaiPhongService loaiPhongService = LoaiPhongService.Instance;

        public ThemLoaiPhong()
        {
            InitializeComponent();
            chatLuongService.HienThiComboBox(cmbChatLuong);
            loaiGiuongService.HienThiComboBox(cmbLoaiGiuong);
        }

        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cmbLoaiGiuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbChatLuong.SelectedItem != null)
                loaiGiuongService.ThayDoiMa(cmbChatLuong, cmbLoaiGiuong, maLoaiPhongLB);
            loaiGiuongService.ThayDoiSoNguoiToiThieu(cmbLoaiGiuong, nmNguoiToiDa);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                txtGio.Text = "";
                txtDem.Text = "";
                txtNgay.Text = "";
            }
        }

        private bool Save()
        {
            if (KiemTra())
                return false;
            LoaiPhong loaiPhong = new LoaiPhong();
            loaiPhong.MaLoaiPhong = maLoaiPhongLB.Text;
            ChatLuong chatLuong = (ChatLuong)cmbChatLuong.SelectedItem;
            LoaiGiuong loaiGiuong = (LoaiGiuong)cmbLoaiGiuong.SelectedItem;
            loaiPhong.TenChatLuong = chatLuong.TenChatLuong;
            loaiPhong.TenLoaiGiuong = loaiGiuong.TenLoaiGiuong;
            loaiPhong.GiaGio = Convert.ToInt32(txtGio.Text);
            loaiPhong.GiaDem = Convert.ToInt32(txtDem.Text);
            loaiPhong.GiaNgay = Convert.ToInt32(txtNgay.Text);
            loaiPhong.SoNguoiToiDa = (int) nmNguoiToiDa.Value;
            int result = loaiPhongService.ThemLoaiPhong(loaiPhong);
            if (result == 1)
                return true;
            return false;
        }

        private bool KiemTra()
        {
            SetDefaultError();
            bool flag = false;
            if (txtNgay.Text == "")
            {
                error.SetError(txtNgay, "Bắt buộc");
                flag = true;
            }
            else
            {
                if (KiemTraMoney(txtNgay))
                {
                    flag = true;
                }
            }
            if (txtGio.Text != "")
            {
                if (KiemTraMoney(txtGio))
                {
                    flag = true;
                }
            }
            if (txtDem.Text != "")
            {
                if (KiemTraMoney(txtDem))
                {
                    flag = true;
                }
            }
            return flag;
        }

        private void SetDefaultError()
        {
            error.SetError(txtGio, "");
            error.SetError(txtDem, "");
            error.SetError(txtNgay, "");
        }

        private bool KiemTraMoney(MetroTextBox txt)
        {
            bool flag = false;
            int money = Convert.ToInt32(txt.Text);
            if (money % 10000 != 0)
            {
                error.SetError(txt, "Bội số 10000");
                flag = true;
            }
            return flag;
        }

        private void cmbChatLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLoaiGiuong.SelectedItem != null)
                chatLuongService.ThayDoiMa(cmbChatLuong, cmbLoaiGiuong, maLoaiPhongLB);
        }
    }
}
