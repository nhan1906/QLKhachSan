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
    public partial class SoDoPhong_UC : UserControl
    {
        
        public delegate void SendMessage(Panel Message);
        public SendMessage Sender;
        private Panel pnContaner;
        private void GetMessage(Panel Message)
        {
            pnContaner = Message;
        }
        private static SoDoPhong_UC instance;
        private PhongService phongService = PhongService.Instance;

        private ContextMenu contextMenu = new ContextMenu();
        private NhanVien info;
        public SoDoPhong_UC(NhanVien info)
        {
            InitializeComponent();
            instance = this;
            this.info = info;
            Sender = new SendMessage(GetMessage);
            MenuItem menuItemDonPhong = new MenuItem("Dọn phòng", DonDepPhong);
            MenuItem menuItemSuaPhong = new MenuItem("Sửa chữa phòng", SuaChuaPhong);
            contextMenu.MenuItems.Add(0, menuItemDonPhong);
            contextMenu.MenuItems.Add(1, menuItemSuaPhong);
            pnTatCa_Click(pnTatCa, new EventArgs());
            timer.Start();
        }

        private void SuaChuaPhong(object sender, EventArgs e)
        {
            RoomExpand room = (RoomExpand)contextMenu.Tag;
            SuaPhong f = new SuaPhong(room.Phong.MaPhong);
            f.ShowDialog();
            pnTatCa_Click(pnTatCa, new EventArgs());
        }

        private void DonDepPhong(object sender, EventArgs e)
        {

            RoomExpand room = (RoomExpand)contextMenu.Tag;
            phongService.DonDepPhong(2, room.Phong.MaPhong);//2 là code dọn phòng
            pnTatCa_Click(pnTatCa, new EventArgs());
        }

        public static SoDoPhong_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new SoDoPhong_UC(null);
                return instance;
            }
        }




        #region Event
        private void pnTatCa_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent1.Visible = true;
            phongService.HienThiDanhSachPhong(flpPhong);
            SetClickForRoom();
        }

        private void SetClickForRoom()
        {
            foreach(RoomExpand room in flpPhong.Controls)
            {
                room.MouseClick += Room_MouseClick;
            }
        }

        private void Room_MouseClick(object sender, MouseEventArgs e)
        {
            RoomExpand room = (RoomExpand)sender;
            Phong phong = room.Phong;
            if(e.Button == MouseButtons.Left)
            {
                if (phong.TenTinhTrangPhong == "Đang sửa")
                {
                    CapNhatSuaPhong fCapNhatSuaPhong = new CapNhatSuaPhong(phong.MaPhong);
                    fCapNhatSuaPhong.ShowDialog();
                    pnTatCa_Click(pnTatCa, new EventArgs());
                    return;
                }
                if (phong.TenTinhTrangPhong == "Nhận phòng")
                {
                    if (!pnContaner.Controls.ContainsKey("NhanPhong_UC"))
                    {
                        NhanPhong_UC uc = new NhanPhong_UC(phong);
                        uc.Dock = DockStyle.Fill;
                        uc.Sender(pnContaner);
                        pnContaner.Controls.Add(uc);
                    }
                    pnContaner.Controls["NhanPhong_UC"].BringToFront();
                }
                if (phong.TenTinhTrangPhong == "Trống")
                {
                    NhanPhong fNhanPhong = new NhanPhong(phong , info);
                    fNhanPhong.ShowDialog();
                    pnTatCa_Click(pnTatCa, new EventArgs());
                    return;
                }
                if (phong.TenTinhTrangPhong == "Đã đặt")
                {
                    NhanPhongDaDatTruoc fNhanPhongDatTruoc = new NhanPhongDaDatTruoc();
                    fNhanPhongDatTruoc.ShowDialog();
                    return;
                }
                
            }
            else if(e.Button == MouseButtons.Right)
            {
                contextMenu.Show(room, new Point(e.X, e.Y));
                contextMenu.Tag = room;
            }
        }

        private void pnTrong_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent2.Visible = true;
        }

        private void pnNhanPhong_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent3.Visible = true;
        }

        private void pnQuaHan_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent4.Visible = true;
        }

        private void pnDaDat_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent5.Visible = true;
        }

        private void pnKhongDen_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent6.Visible = true;
        }

        private void pnBan_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent7.Visible = true;
        }

        private void pnDangSua_Click(object sender, EventArgs e)
        {
            SetClick(sender);
            pnAccent8.Visible = true;
        }

        private void SetClick(object sender)
        {
            SetDefaultColor();
            Panel panel = (Panel)sender;
            panel.BackColor = Color.White;
        }

        private void SetDefaultColor()
        {
            pnTatCa.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            pnTrong.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            pnNhanPhong.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            pnQuaHan.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            pnDaDat.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            pnKhongDen.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            pnBan.BackColor = ColorTranslator.FromHtml("#F0F0F0");
            pnDangSua.BackColor = ColorTranslator.FromHtml("#F0F0F0");

            pnAccent1.Visible = false;
            pnAccent2.Visible = false;
            pnAccent3.Visible = false;
            pnAccent4.Visible = false;
            pnAccent5.Visible = false;
            pnAccent6.Visible = false;
            pnAccent7.Visible = false;
            pnAccent8.Visible = false;
        }
        #endregion
        #region Event Click Panel
        private void lbTatCa_Click(object sender, EventArgs e)
        {
            pnTatCa_Click(pnTatCa, e);
        }

        private void lbTrong_Click(object sender, EventArgs e)
        {
            pnTrong_Click(pnTrong, e);
        }

        private void lbNhanPhong_Click(object sender, EventArgs e)
        {
            pnNhanPhong_Click(pnNhanPhong, e);
        }

        private void lbQuaHan_Click(object sender, EventArgs e)
        {
            pnQuaHan_Click(pnQuaHan, e);
        }

        private void lbDaDat_Click(object sender, EventArgs e)
        {
            pnDaDat_Click(pnDaDat, e);
        }

        private void lbKhongDen_Click(object sender, EventArgs e)
        {
            pnKhongDen_Click(pnKhongDen, e);
        }

        private void lbBan_Click(object sender, EventArgs e)
        {
            pnBan_Click(pnBan, e);
        }

        private void lbDangSua_Click(object sender, EventArgs e)
        {
            pnDangSua_Click(pnDangSua, e);
        }

        private void lbTatCaM_Click(object sender, EventArgs e)
        {
            pnTatCa_Click(pnTatCa, e);
        }

        private void lbTrongM_Click(object sender, EventArgs e)
        {
            pnTrong_Click(pnTrong, e);
        }

        private void lbNhanPhongM_Click(object sender, EventArgs e)
        {
            pnNhanPhong_Click(pnNhanPhong, e);
        }

        private void lbQuaHanM_Click(object sender, EventArgs e)
        {
            pnQuaHan_Click(pnQuaHan, e);
        }

        private void lbDaDatM_Click(object sender, EventArgs e)
        {
            pnDaDat_Click(pnDaDat, e);
        }

        private void lbKhongDenM_Click(object sender, EventArgs e)
        {
            pnKhongDen_Click(pnKhongDen, e);
        }

        private void lbBanMain_Click(object sender, EventArgs e)
        {
            pnBan_Click(pnBan, e);
        }

        private void lbDangSuaM_Click(object sender, EventArgs e)
        {
            pnDangSua_Click(pnDangSua, e);
        }
        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            //Tạo bảng quy định
            if (DateTime.Now.TimeOfDay == new TimeSpan(12, 0 ,0))
            {

            }
            if (hour == 14 && min == 11)
            {
                phongService.CapNhatPhongDaDat();
                pnTatCa_Click(pnTatCa, new EventArgs());
            }
        }
    }
}
