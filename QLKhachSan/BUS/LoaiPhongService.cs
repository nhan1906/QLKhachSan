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
