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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progress.Increment(1);
            if (progress.Value == 100)
            {
                timer.Stop();
                this.Hide();
                Main main = Main.Instance;
                main.ShowDialog();
                this.Close();
            }
        }
    }
}
