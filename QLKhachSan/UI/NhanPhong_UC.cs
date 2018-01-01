using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class NhanPhong_UC : UserControl
    {


        private static NhanPhong_UC instance;
        public delegate void SendMessage(Panel Message);
        public SendMessage Sender;
        private Panel pnContaner;
        private void GetMessage(Panel Message)
        {
            pnContaner = Message;
        }
        public static NhanPhong_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanPhong_UC();
                return instance;
            }
        }


        public NhanPhong_UC()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
    }
}
