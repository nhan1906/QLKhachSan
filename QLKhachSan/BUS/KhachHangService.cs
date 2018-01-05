using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class KhachHangService
    {
        #region Singleton
        private static KhachHangService instance;

        public static KhachHangService Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangService();
                return instance;
            }
        }

        private KhachHangService() { }

        #endregion

        private KhachHangDAO data = KhachHangDAO.Instance;

        public void HienThiComboBoxCountry(ComboBox cmb)
        {
            cmb.DataSource = CountryDAO.GetCountryList();
            cmb.SelectedIndex = cmb.FindString("Vietnam");
        }

        public void HienThiDataGridView(BindingSource bindingList)
        {
            bindingList.DataSource = data.LayDanhSachKhachHang();
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            return data.ThemKhachHang(khachHang);
        }

        public bool KiemTraDaTonTaiKhachHang(string text)
        {
            return data.KiemTraDaTonTaiKhachHang(text);
        }

        public void HienThiDanhSachKhachHangTheoSoGT(BindingSource bindingList , string text)
        {
            bindingList.DataSource = data.LayDanhSachKhachHangTheoSoGT(text);
        }

        public void ThemKhachHangVaoDSDK(ListView lsvKhachHang, string maKH)
        {
            KhachHang khachHang = data.LayKhachHangBangMaKH(maKH);
            foreach(ListViewItem pt in lsvKhachHang.Items)
            {
                if (pt.Text.Equals(khachHang.MaKhachHang))
                {
                    MessageBox.Show("Da ton tai khach hang. Vui long chon lai", "Thong bao", MessageBoxButtons.OK);
                    return;
                }
            }
            ListViewItem item = new ListViewItem(khachHang.MaKhachHang);
            item.SubItems.Add(khachHang.HoKhachHang + " " + khachHang.TenKhachHang);
            item.SubItems.Add(khachHang.Cmnd);
            item.SubItems.Add(khachHang.SoDienThoai);
            item.SubItems.Add(khachHang.DiaChi);
            lsvKhachHang.Items.Add(item);
        }
    }
}
