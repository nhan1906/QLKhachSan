using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SuaPhong : MetroForm
    {
        

        public SuaPhong(int maPhong)
        {
            InitializeComponent();
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now.AddDays(1);
            lbMaPhong.Text = maPhong.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
