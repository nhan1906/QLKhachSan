using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using DTO;

namespace BUS
{
    public class ChatLuongService
    {
        #region Singleton
        private static ChatLuongService instance;

        public static ChatLuongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChatLuongService();
                return instance;
            }
        }

        private ChatLuongService() { }

        #endregion

        private ChatLuongDAO data = ChatLuongDAO.Instance;

        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = data.LayDanhSachChatLuong();
            cmb.DisplayMember = "tenChatLuong";
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
