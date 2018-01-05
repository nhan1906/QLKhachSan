using BUS;
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
    public partial class ChonPhongDatPhong : MetroForm
    {
        string maDatPhong, maLoaiPhong;
        private NhanPhong fNhanPhong;
        int count = 0;
        private ChiTietDatPhongService chiTietDatPhongService = ChiTietDatPhongService.Instance;
        private DanhSachPhongConTrongServices dsPhongConTronService = DanhSachPhongConTrongServices.Instance;
        public ChonPhongDatPhong(string maDatPhong , string maLoaiPhong)
        {
            InitializeComponent();
            this.maDatPhong = maDatPhong;
            this.maLoaiPhong = maLoaiPhong;
            count = dsPhongConTronService.LaySoPhongDaDatTheoLoai(maDatPhong , maLoaiPhong);
            HienThiListView();
            
            
        }

        public ChonPhongDatPhong(NhanPhong f , string maLoaiPhong, DateTime checkIn , DateTime checkOut)
        {
            InitializeComponent();
            this.fNhanPhong = f;
            lsvChonPhong.DoubleClick += LsvChonPhong_DoubleClick;
            HienThiListView(maLoaiPhong, checkIn , checkOut);

        }

        private void LsvChonPhong_DoubleClick(object sender, EventArgs e)
        {
            if (lsvChonPhong.SelectedItems.Count == 0)
                return;
            int maPhong = Convert.ToInt32(lsvChonPhong.SelectedItems[0].SubItems[0].Text);
            fNhanPhong.ThayDoiPhong(maPhong);
            this.Close();
        }

        private void HienThiListView(string maLoaiPhong, DateTime checkIn, DateTime checkOut)
        {
            dsPhongConTronService.HienThiDanhSachPhongTheoMaLoai(lsvChonPhong , maLoaiPhong, checkIn, checkOut);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int numberCheck = 0;
            foreach(ListViewItem item in lsvChonPhong.Items)
            {
                if (item.Checked == true)
                    numberCheck++;
            }
            if(numberCheck != count)
            {
                MessageBox.Show("Vui lòng chỉ chọn đủ " + count + " phòng", "Thông báo", MessageBoxButtons.OK);
            }

            //Cập nhật lại mã phòng vff
        }

        private void HienThiListView()
        {
            dsPhongConTronService.HienThiDanhSachPhongTheoMaLoai(lsvChonPhong, maDatPhong, maLoaiPhong);
        }
    }
}
