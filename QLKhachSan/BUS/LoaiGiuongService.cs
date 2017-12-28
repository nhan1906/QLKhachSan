using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace BUS
{
    public class LoaiGiuongService
    {
        #region Singleton
        private static LoaiGiuongService instance;

        public static LoaiGiuongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiGiuongService();
                return instance;
            }
        }

        private LoaiGiuongService() { }

        #endregion

        private LoaiGiuongDAO data = LoaiGiuongDAO.Instance;

        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = data.LayDanhSachLoaiGiuong();
            cmb.DisplayMember = "tenLoaiGiuong";
        }

        public void ThayDoiSoNguoiToiThieu(ComboBox cmb , NumericUpDown nmNguoiToiDa)
        {
            LoaiGiuong loaiGiuong = (LoaiGiuong)cmb.SelectedItem;
            nmNguoiToiDa.Minimum = loaiGiuong.SoNguoi;
        }

        public void ThayDoiMa(MetroComboBox cmbChatLuong, MetroComboBox cmbLoaiGiuong, MetroLabel maLoaiPhongLB)
        {
            ChatLuong chatLuong = (ChatLuong)cmbChatLuong.SelectedItem;
            LoaiGiuong loaiGiuong = (LoaiGiuong)cmbLoaiGiuong.SelectedItem;
            string maLoaiPhong = chatLuong.TenChatLuong.ToCharArray()[0].ToString() + loaiGiuong.TenLoaiGiuong.ToCharArray()[0].ToString() + loaiGiuong.SoGiuong + loaiGiuong.SoNguoi;
            maLoaiPhongLB.Text = maLoaiPhong;
        }
    }
}
