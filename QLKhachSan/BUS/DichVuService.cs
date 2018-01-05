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
    public class DichVuService
    {
        #region Singleton
        private static DichVuService instance;

        public static DichVuService Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuService();
                return instance;
            }
        }


        private DichVuService() { }
        #endregion

        private NhomDichVuDAO nhomDVData = NhomDichVuDAO.Instance;
        private DichVuDAO data = DichVuDAO.Instance;

        public void HienThiLenFlowLayoutPanel(FlowLayoutPanel flpNhom , FlowLayoutPanel flpDV)
        {
            flpNhom.Controls.Clear();
            foreach(NhomDichVu item in nhomDVData.LayDanhSachNhomDichVu())
            {
                Button btnNhomDV = new Button();
                btnNhomDV.Text = item.TenLoaiDV;
                btnNhomDV.Click += BtnNhomDV_Click;
                btnNhomDV.Tag = flpDV;
                flpNhom.Controls.Add(btnNhomDV);
                if (item.TenLoaiDV == "Nước giải khát")
                    btnNhomDV.PerformClick();
            }
        }

        private void BtnNhomDV_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            FlowLayoutPanel flpDV = (FlowLayoutPanel)btn.Tag;
            HienThiDichVuTheoNhom(btn, flpDV);
        }

        public void HienThiDichVuTheoNhom(Button btn , FlowLayoutPanel flpDV)
        {
            flpDV.Controls.Clear();
            foreach (DichVu dv in data.LayDanhSachDichVuTheoNhom(btn.Text))
            {
                Button btnDV = new Button();
                btnDV.Text = dv.TenDV;
                btnDV.Tag = dv;
                flpDV.Controls.Add(btnDV);
            }
        }
    }
}
