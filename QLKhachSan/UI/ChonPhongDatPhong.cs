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
