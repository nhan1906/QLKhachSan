using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace UI
{
    public partial class NhanPhong_UC : UserControl
    {

        private DichVuService dichVuService = DichVuService.Instance;

        private static NhanPhong_UC instance;
        public delegate void SendMessage(Panel Message);
        public SendMessage Sender;
        private Panel pnContaner;
        private Phong phong;
        private void GetMessage(Panel Message)
        {
            pnContaner = Message;
        }
        public static NhanPhong_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanPhong_UC(null);
                return instance;
            }
        }


        public NhanPhong_UC(Phong phong)
        {
            InitializeComponent();
            instance = this;
            this.phong = phong;
            Sender = new SendMessage(GetMessage);
            CapNhat();
        }

        public void CapNhat()
        {
            dichVuService.HienThiLenFlowLayoutPanel(flowPanelNhomDV , flpDichVu);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            DichVu dichVu = (DichVu)((Button)sender).Tag;
            SoLuongDV f = new SoLuongDV(dichVu);
            f.ShowDialog();
        }

        private void flpDichVu_ControlAdded(object sender, ControlEventArgs e)
        {
            Button dv = (Button) e.Control;
            dv.Click += Btn_Click;
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            ChuyenPhongForm f = new ChuyenPhongForm(phong);
            f.ShowDialog();
        }
    }
}
