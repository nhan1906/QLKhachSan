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
    public class TinhTrangPhongService
    {
        #region Singleton
        private static TinhTrangPhongService instance;

        public static TinhTrangPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new TinhTrangPhongService();
                return instance;
            }
        }

        private TinhTrangPhongService() { }

        #endregion

        private TinhTrangPhongDAO data = TinhTrangPhongDAO.Instance;

        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = data.DanhSachTinhTrangPhong();
            cmb.DisplayMember = "tenTinhTrangPhong";
        }

        public void HienThiComboBoxAll(MetroComboBox cmb)
        {
            List<TinhTrangPhong> list = data.DanhSachTinhTrangPhong();
            TinhTrangPhong tinhTrang = new TinhTrangPhong();
            tinhTrang.TenTinhTrangPhong = "---Tất cả---";
            list.Add(tinhTrang);
            cmb.DataSource = list;
            cmb.DisplayMember = "tenTinhTrangPhong";
            cmb.SelectedIndex = cmb.Items.Count - 1;
        }
    }
}
