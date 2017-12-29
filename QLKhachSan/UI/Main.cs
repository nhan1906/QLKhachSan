using BUS;
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
    public partial class Main : Form
    {

        #region Singleton
        private static Main instance;

        public static Main Instance
        {
            get
            {
                if (instance == null)
                    instance = new Main();
                return instance;
            }
        }
        

        #endregion

        public Panel PanelContainer
        {
            get
            {
                return pnContainer;
            }
            set
            {
                pnContainer = value;
            }
        }

        public Main()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            btnSoDoPhong_Click(btnSoDoPhong ,new EventArgs());
            
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Escape)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            SetClickButton(sender);
            if (!pnContainer.Controls.ContainsKey("SoDoPhong_UC"))
            {
                SoDoPhong_UC uc = SoDoPhong_UC.Instance;
                uc.Dock = DockStyle.Fill;
                pnContainer.Controls.Add(uc);
            }
            pnContainer.Controls["SoDoPhong_UC"].BringToFront();
        }

        private void SetClickButton(object sender)
        {
            foreach (Control control in flpMenu.Controls)
            {
                if(control is Button)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }
            Button buttonClick = (Button)sender;
            buttonClick.BackColor = ColorTranslator.FromHtml("#512DA8");
            buttonClick.ForeColor = Color.White;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            SetClickButton(sender);
            if (!pnContainer.Controls.ContainsKey("DatPhong_UC"))
            {
                DatPhong_UC uc = DatPhong_UC.Instance;
                uc.Dock = DockStyle.Fill;
                pnContainer.Controls.Add(uc);
            }
            pnContainer.Controls["DatPhong_UC"].BringToFront();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            SetClickButton(sender);
            if (flpQuanLy.Visible == true)
                flpQuanLy.Visible = false;
            else
                flpQuanLy.Visible = true;
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            SetClickButtonLevel2(sender);
            if (!pnContainer.Controls.ContainsKey("QuanLyPhong_UC"))
            {
                QuanLyPhong_UC uc = QuanLyPhong_UC.Instance;
                uc.Dock = DockStyle.Fill;
                uc.Sender(pnContainer);
                pnContainer.Controls.Add(uc);
            }
            pnContainer.Controls["QuanLyPhong_UC"].BringToFront();
        }

        private void SetClickButtonLevel2(object sender)
        {
            foreach (Control control in flpQuanLy.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }
            Button buttonClick = (Button)sender;
            buttonClick.BackColor = Color.Gray;
            buttonClick.ForeColor = Color.White; ;
        }

        private void btnQuanLyLoaiPhong_Click(object sender, EventArgs e)
        {
            SetClickButtonLevel2(sender);
            if (!pnContainer.Controls.ContainsKey("QuanLyLoaiPhong_UC"))
            {
                QuanLyLoaiPhong_UC uc = QuanLyLoaiPhong_UC.Instance;
                uc.Dock = DockStyle.Fill;
                uc.Sender(pnContainer);
                pnContainer.Controls.Add(uc);
            }
            pnContainer.Controls["QuanLyLoaiPhong_UC"].BringToFront();
        }

        private void btnQuanLyTang_Click(object sender, EventArgs e)
        {
            SetClickButtonLevel2(sender);
            if (!pnContainer.Controls.ContainsKey("QuanLyTang_UC"))
            {
                QuanLyTang_UC uc = QuanLyTang_UC.Instance;
                uc.Dock = DockStyle.Fill;
                uc.Sender(pnContainer);
                pnContainer.Controls.Add(uc);
            }
            pnContainer.Controls["QuanLyTang_UC"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetClickButtonLevel2(sender);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            SetClickButton(sender);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SetClickButton(sender);
        }
    }
}
