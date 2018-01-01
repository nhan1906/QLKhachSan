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
    public class ChiTietDatPhongService
    {
        #region Singleton
        private static ChiTietDatPhongService instance;

        public static ChiTietDatPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietDatPhongService();
                return instance;
            }
        }


        private ChiTietDatPhongService() { }
        #endregion

        private ThongKePhongDKTheoLoaiDAO thongKeDAO = ThongKePhongDKTheoLoaiDAO.Instance;
        private ChiTietDatPhongDAO data = ChiTietDatPhongDAO.Instance;

        public void HienThiDanhSachPhongTheoMaLoai(MetroListView lsvChonPhong, string maDatPhong, string maLoaiPhong)
        {
            List<int> maPhongs = data.DanhSachPhongDaDatTheoLoai(maDatPhong, maLoaiPhong);
            foreach(int maPhong in maPhongs)
                lsvChonPhong.Items.Add(maPhong.ToString());
        }
        

        public bool ThemChiTietDatPhong(Phong phong ,string maDatPhong)
        {
            return data.ThemPhongDatPhong(phong, maDatPhong);
        }


        public void HienThiDataGridView(DataGridView dtgv , string maDatPhong)
        {
            dtgv.DataSource = thongKeDAO.LayDanhSachDKTheoLoai(maDatPhong);
        }


    }
}
