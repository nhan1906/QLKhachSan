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
    public partial class QuanLyTaiKhoan_UC : UserControl
    {

        private static QuanLyTaiKhoan_UC instance;
        private FormatViewServices formatView = FormatViewServices.Instance;
        private AccountService accountService = AccountService.Instance;
        private Account accountHT;
        public QuanLyTaiKhoan_UC(Account accountHT)
        {
            InitializeComponent();
            instance = this;
            this.accountHT = accountHT;
            formatView.FormatDataGridView(dtgvTaiKhoan);
            dtgvTaiKhoan.DoubleClick += DtgvTaiKhoan_DoubleClick;
            CapNhat();
        }

        private void DtgvTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvTaiKhoan.SelectedRows.Count == 0)
                return;
            Account account = new Account();
            account.Username = dtgvTaiKhoan.SelectedRows[0].Cells["username"].Value.ToString();
            account.Phanquyen =(int) dtgvTaiKhoan.SelectedRows[0].Cells["phanQuyen"].Value;
            SuaXoaTaiKhoanForm f = new SuaXoaTaiKhoanForm(account , accountHT);
            f.ShowDialog();
            CapNhat();
        }

        public static QuanLyTaiKhoan_UC Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuanLyTaiKhoan_UC(null);
                return instance;
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemTaiKhoanForm f = new ThemTaiKhoanForm();
            f.ShowDialog();
            CapNhat();
        }

        public void CapNhat()
        {
            accountService.HienThiTatCaTaiKhoanLenDtgv(dtgvTaiKhoan);
            accountService.DrawDtgv(dtgvTaiKhoan);
        }
    }
}
