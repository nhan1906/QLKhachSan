using MetroFramework.Controls;
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
    public class TangService
    {
        #region Singleton
        private static TangService instance;

        public static TangService Instance
        {
            get
            {
                if (instance == null)
                    instance = new TangService();
                return instance;
            }
        }

        private TangService() { }

        #endregion

        private TangDAO data = TangDAO.Instance;

        public void HienThiDataGridView(BindingSource binding, int trangThu , int soPhanTuTrang)
        {
            binding.DataSource = data.LayDanhSachTang(trangThu , soPhanTuTrang);
        }

        public void LayTangTiepTheo(MetroTextBox txtTangThu)
        {
            int i = data.LayTangTiepTheo();
            txtTangThu.Text = i.ToString();
        }

        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = data.LayDanhSachTang();
            cmb.DisplayMember = "tenTang";
        }

        public int ThemTang(Tang tang)
        {
            if (data.TangThuDaTonTai(tang.TangThu))
            {
                //Hiển thị lỗi errorProvider đã tồn tại 2
                return 2;
            }

            if (data.ThemTang(tang))
            {
                //Hiển thị thông báo đã thêm thành công 1
                return 1;
            }
            else
            {
                //Hiển thị thông báo thêm thất bại
                return 0;
            }
        }

        public void XoaTang(Tang tang)
        {
            if(tang.SoPhong != 0)
            {
                //Hiển thị thống báo không thể xóa tầng. Bạn phải xóa tất cả các phòng
            }

            //Xóa tầng
            if (data.XoaTang(tang))
            {
                //Hiển thị thông báo đã thêm thành công
            }
            else
            {
                //Hiển thị thông báo thêm thất bại
            }
        }

        public void SuaTang(Tang tang)
        {
            if (data.TangThuDaTonTai(tang.TangThu))
            {
                //Hiển thị lỗi errorProvider đã tồn tại
            }

            if (data.SuaTang(tang))
            {
                //Hiển thị thông báo đã thêm thành công
            }
            else
            {
                //Hiển thị thông báo thêm thất bại
            }
        }

        public int SoTang()
        {
            return data.LaySoTang();
        }
    }
}
