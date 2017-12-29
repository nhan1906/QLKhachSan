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
    public class LoaiPhongService
    {
        #region Singleton
        private static LoaiPhongService instance;

        public static LoaiPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiPhongService();
                return instance;
            }
        }

        private LoaiPhongService() { }

        #endregion

        private LoaiPhongDAO data = LoaiPhongDAO.Instance;

        public void HienThiComboBox(MetroComboBox cmbLoaiPhong)
        {
            cmbLoaiPhong.DataSource = data.LayDanhSachLoaiPhong();
            cmbLoaiPhong.DisplayMember = "maLoaiPhong";
        }
        
        public void HienThiComboBoxAll(MetroComboBox cmbLoaiPhong)
        {
            List<LoaiPhong> list = data.LayDanhSachLoaiPhong();
            LoaiPhong loaiPhong = new LoaiPhong();
            loaiPhong.MaLoaiPhong = "---Tất cả---";
            loaiPhong.SoNguoiToiDa = -1;
            list.Add(loaiPhong);
            cmbLoaiPhong.DataSource = list;
            cmbLoaiPhong.DisplayMember = "maLoaiPhong";
            cmbLoaiPhong.SelectedIndex = cmbLoaiPhong.Items.Count - 1;
        }

        public void HienThiDataGridView(DataGridView dtgv)
        {
            dtgv.DataSource = data.LayDanhSachLoaiPhong();
        }

        public int ThemLoaiPhong(LoaiPhong loaiPhong)
        {
            if (data.KiemTraTonTaiCua(loaiPhong))
            {
                return 2;
            }
            if (data.ThemLoaiPhong(loaiPhong))
            {
                return 1;
            }
            return 0;
        }
    }
}
