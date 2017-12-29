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
    public partial class DatPhong_UC : UserControl
    {

        private static DatPhong_UC instance;

        public DatPhong_UC()
        {
            InitializeComponent();
        }

        public static DatPhong_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatPhong_UC();
                return instance;
            }
        }
    }
}
