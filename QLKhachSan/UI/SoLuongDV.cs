using DTO;
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
    public partial class SoLuongDV : Form
    {

        private DichVu dichvu;
        public SoLuongDV(DichVu dichvu)
        {
            InitializeComponent();
            this.dichvu = dichvu;
            lbDonVi.Text = dichvu.TenDonVi;
            
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
