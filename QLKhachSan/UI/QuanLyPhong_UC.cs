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
    public partial class QuanLyPhong_UC : UserControl
    {

        private static QuanLyPhong_UC instance;

        private PhongService phongService = PhongService.Instance;
        private TangService tangService = TangService.Instance;
        private LoaiPhongService loaiPhongService = LoaiPhongService.Instance;
        private TinhTrangPhongService tinhTrangPhongSerive = TinhTrangPhongService.Instance;
        private ContextMenu contextMenu = new ContextMenu();


        public delegate void SendMessage(Panel Message);
        public SendMessage Sender;
        private Panel pnContaner;

        public static QuanLyPhong_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuanLyPhong_UC();
                return instance;
            }
        }

        private void GetMessage(Panel Message)
        {
            pnContaner = Message;
        }

        public QuanLyPhong_UC()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            contextMenu.MenuItems.Add("Sửa phòng", SuaPhong);
            CatDatRoom();
            tangService.HienThiComboBoxAll(cmbTang);
            loaiPhongService.HienThiComboBoxAll(cmbLoaiPhong);
            tinhTrangPhongSerive.HienThiComboBoxAll(cmbTinhTrangPhong);
        }

        private void SuaPhong(object sender, EventArgs e)
        {
            RoomExpand room = (RoomExpand)contextMenu.Tag;
            SuaPhong f = new SuaPhong(310);
            f.ShowDialog();
        }

        private void CatDatRoom()
        {
            phongService.HienThiDanhSachPhong(flpPhong);
            foreach (RoomExpand room in flpPhong.Controls)
            {
                room.MouseClick += Room_MouseClick;
            }
        }

        private void Room_MouseClick(object sender, MouseEventArgs e)
        {
            RoomExpand room = (RoomExpand)sender;

            if (e.Button == MouseButtons.Right)
            {
                contextMenu.Show(room, new Point(e.X, e.Y));
                contextMenu.Tag = room;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemPhong f = new ThemPhong();
            f.ShowDialog();
            phongService.HienThiDanhSachPhong(flpPhong);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Tang tang = (Tang)cmbTang.SelectedItem;
            LoaiPhong loaiPhong = (LoaiPhong)cmbLoaiPhong.SelectedItem;
            TinhTrangPhong tinhTrangPhong = (TinhTrangPhong)cmbTinhTrangPhong.SelectedItem;
            cmbTang.SelectedIndex = cmbTang.Items.Count - 1;
            cmbLoaiPhong.SelectedIndex = cmbLoaiPhong.Items.Count - 1;
            cmbTinhTrangPhong.SelectedIndex = cmbTinhTrangPhong.Items.Count - 1;
        }

        private void cmbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lọc theo Tầng
            CaiDatRoomLoc();

        }

        private void cmbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lọc theo loại phòng
            CaiDatRoomLoc();
        }

        private void cmbTinhTrangPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lọc theo tình trạng phòng
            CaiDatRoomLoc();
        }

        private void CaiDatRoomLoc()
        {
            phongService.LocDanhSachPhong(cmbTang, cmbLoaiPhong, cmbTinhTrangPhong, flpPhong);
            foreach (RoomExpand room in flpPhong.Controls)
            {
                room.MouseClick += Room_MouseClick;
            }
        }
        
    }
}
