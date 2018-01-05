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
    public partial class DichVu_UC : UserControl
    {
        #region Singleton
        private static DichVu_UC instance;

        public static DichVu_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVu_UC();
                return instance;
            }
        }
        #endregion 

        public DichVu_UC()
        {
            InitializeComponent();
        }
    }
}
