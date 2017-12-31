using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DatPhongService
    {
        #region Singleton
        private static DatPhongService instance;

        public static DatPhongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatPhongService();
                return instance;
            }
        }


        private DatPhongService() { }
        #endregion
        

        public void DrawingDataGridView(DataGridView dtgv)
        {

            dtgv.RowTemplate.Height = 90;
            dtgv.Columns[0].HeaderText = "Hình mô tả";
            dtgv.Columns[1].HeaderText = "Mã";
            dtgv.Columns[2].HeaderText = "Tên loại phòng";
            dtgv.Columns[3].HeaderText = "Giá (VNĐ)";
            dtgv.Columns[4].HeaderText = "Tổng";
            dtgv.Columns[5].HeaderText = "Đặt";
            dtgv.Columns[6].HeaderText = "Còn";
            dtgv.Columns[7].HeaderText = "Thao tác";
            dtgv.Columns[0].Width = 120;
            dtgv.Columns[1].Width = 80;
            dtgv.Columns[2].Width = 150;
            dtgv.Columns[3].Width = 90;
            dtgv.Columns[4].Width = 60;
            dtgv.Columns[5].Width = 50;
            dtgv.Columns[6].Width = 50;
            dtgv.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
