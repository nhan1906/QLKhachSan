using BUS;
using DTO;
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
        private PhieuSuaChuaPhongService suaPhongService = PhieuSuaChuaPhongService.Instance;
        private int maPhong;
        public SuaPhong(int maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            dtEnd.Value = DateTime.Now;
            lbMaPhong.Text = maPhong.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            PhieuSuaChua phieuSuaChua = new PhieuSuaChua();
            phieuSuaChua.MaPhong = maPhong;
            phieuSuaChua.NgayBatDau = DateTime.Now;
            phieuSuaChua.NgayDuKienKT = dtEnd.Value;
            phieuSuaChua.GhiChu = rtxtGhiChu.Text;

            suaPhongService.ThemPhieuSuaChuaPhong(phieuSuaChua, notify);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
