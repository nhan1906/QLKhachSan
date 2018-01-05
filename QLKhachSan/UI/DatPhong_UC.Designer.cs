namespace UI
{
    partial class DatPhong_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.checkOut = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.checkIn = new MetroFramework.Controls.MetroDateTime();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxtYeuCauKhac = new System.Windows.Forms.RichTextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtMaDatPhong = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtSoDienThoai = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtgvTinhTrang = new System.Windows.Forms.DataGridView();
            this.pnChonPhong = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrang)).BeginInit();
            this.pnChonPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorTime
            // 
            this.errorTime.ContainerControl = this;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(630, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 570);
            this.panel1.TabIndex = 105;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 570);
            this.panel3.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKiemTra);
            this.panel2.Controls.Add(this.checkOut);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.checkIn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 70);
            this.panel2.TabIndex = 107;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnKiemTra.FlatAppearance.BorderSize = 0;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.ForeColor = System.Drawing.Color.White;
            this.btnKiemTra.Location = new System.Drawing.Point(492, 21);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(82, 29);
            this.btnKiemTra.TabIndex = 3;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // checkOut
            // 
            this.checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkOut.Location = new System.Drawing.Point(322, 21);
            this.checkOut.MinimumSize = new System.Drawing.Size(0, 29);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(130, 29);
            this.checkOut.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 104;
            this.metroLabel1.Text = "Ngày nhận";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(256, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 103;
            this.metroLabel2.Text = "Ngày trả";
            // 
            // checkIn
            // 
            this.checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkIn.Location = new System.Drawing.Point(103, 21);
            this.checkIn.MinimumSize = new System.Drawing.Size(0, 29);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(127, 29);
            this.checkIn.TabIndex = 1;
            this.checkIn.ValueChanged += new System.EventHandler(this.checkIn_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(20, 550);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(610, 20);
            this.panel5.TabIndex = 109;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtxtYeuCauKhac);
            this.panel4.Controls.Add(this.btnDatPhong);
            this.panel4.Controls.Add(this.metroLabel5);
            this.panel4.Controls.Add(this.metroLabel6);
            this.panel4.Controls.Add(this.metroLabel7);
            this.panel4.Controls.Add(this.metroLabel8);
            this.panel4.Controls.Add(this.metroLabel3);
            this.panel4.Controls.Add(this.metroLabel10);
            this.panel4.Controls.Add(this.txtMaDatPhong);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.txtSoDienThoai);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(20, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 480);
            this.panel4.TabIndex = 110;
            // 
            // rtxtYeuCauKhac
            // 
            this.rtxtYeuCauKhac.Location = new System.Drawing.Point(110, 205);
            this.rtxtYeuCauKhac.Name = "rtxtYeuCauKhac";
            this.rtxtYeuCauKhac.Size = new System.Drawing.Size(211, 59);
            this.rtxtYeuCauKhac.TabIndex = 7;
            this.rtxtYeuCauKhac.Text = "";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(239, 289);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(82, 29);
            this.btnDatPhong.TabIndex = 103;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(49, 100);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Họ tên";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(133, 12);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(152, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Thông tin khách hàng";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 59);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Mã đặt phòng";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(11, 135);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Số điện thoại";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 205);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Yêu cầu khác";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(56, 170);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Email";
            // 
            // txtMaDatPhong
            // 
            this.txtMaDatPhong.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtMaDatPhong.CustomButton.Image = null;
            this.txtMaDatPhong.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtMaDatPhong.CustomButton.Name = "";
            this.txtMaDatPhong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaDatPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaDatPhong.CustomButton.TabIndex = 1;
            this.txtMaDatPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaDatPhong.CustomButton.UseSelectable = true;
            this.txtMaDatPhong.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMaDatPhong.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtMaDatPhong.ForeColor = System.Drawing.Color.White;
            this.txtMaDatPhong.Lines = new string[] {
        "3097685"};
            this.txtMaDatPhong.Location = new System.Drawing.Point(110, 59);
            this.txtMaDatPhong.MaxLength = 32767;
            this.txtMaDatPhong.Name = "txtMaDatPhong";
            this.txtMaDatPhong.PasswordChar = '\0';
            this.txtMaDatPhong.ReadOnly = true;
            this.txtMaDatPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaDatPhong.SelectedText = "";
            this.txtMaDatPhong.SelectionLength = 0;
            this.txtMaDatPhong.SelectionStart = 0;
            this.txtMaDatPhong.ShortcutsEnabled = true;
            this.txtMaDatPhong.ShowButton = true;
            this.txtMaDatPhong.Size = new System.Drawing.Size(211, 23);
            this.txtMaDatPhong.TabIndex = 10;
            this.txtMaDatPhong.Text = "3097685";
            this.txtMaDatPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaDatPhong.UseCustomBackColor = true;
            this.txtMaDatPhong.UseCustomForeColor = true;
            this.txtMaDatPhong.UseSelectable = true;
            this.txtMaDatPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaDatPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaDatPhong.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtMaDatPhong_ButtonClick);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(110, 100);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Họ tên";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(211, 23);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Họ tên";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSoDienThoai
            // 
            // 
            // 
            // 
            this.txtSoDienThoai.CustomButton.Image = null;
            this.txtSoDienThoai.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtSoDienThoai.CustomButton.Name = "";
            this.txtSoDienThoai.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoDienThoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoDienThoai.CustomButton.TabIndex = 1;
            this.txtSoDienThoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoDienThoai.CustomButton.UseSelectable = true;
            this.txtSoDienThoai.CustomButton.Visible = false;
            this.txtSoDienThoai.Lines = new string[0];
            this.txtSoDienThoai.Location = new System.Drawing.Point(110, 135);
            this.txtSoDienThoai.MaxLength = 32767;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.PromptText = "Số điện thoại";
            this.txtSoDienThoai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.SelectionLength = 0;
            this.txtSoDienThoai.SelectionStart = 0;
            this.txtSoDienThoai.ShortcutsEnabled = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(211, 23);
            this.txtSoDienThoai.TabIndex = 5;
            this.txtSoDienThoai.UseSelectable = true;
            this.txtSoDienThoai.WaterMark = "Số điện thoại";
            this.txtSoDienThoai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoDienThoai.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(110, 170);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(211, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Email";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtgvTinhTrang);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(370, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 480);
            this.panel6.TabIndex = 111;
            // 
            // dtgvTinhTrang
            // 
            this.dtgvTinhTrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTinhTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTinhTrang.Location = new System.Drawing.Point(0, 0);
            this.dtgvTinhTrang.Name = "dtgvTinhTrang";
            this.dtgvTinhTrang.RowTemplate.Height = 90;
            this.dtgvTinhTrang.Size = new System.Drawing.Size(260, 480);
            this.dtgvTinhTrang.TabIndex = 0;
            // 
            // pnChonPhong
            // 
            this.pnChonPhong.Controls.Add(this.panel6);
            this.pnChonPhong.Controls.Add(this.panel4);
            this.pnChonPhong.Controls.Add(this.panel5);
            this.pnChonPhong.Controls.Add(this.panel2);
            this.pnChonPhong.Controls.Add(this.panel3);
            this.pnChonPhong.Controls.Add(this.panel1);
            this.pnChonPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChonPhong.Location = new System.Drawing.Point(0, 0);
            this.pnChonPhong.Name = "pnChonPhong";
            this.pnChonPhong.Size = new System.Drawing.Size(650, 570);
            this.pnChonPhong.TabIndex = 0;
            // 
            // DatPhong_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnChonPhong);
            this.Name = "DatPhong_UC";
            this.Size = new System.Drawing.Size(650, 570);
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrang)).EndInit();
            this.pnChonPhong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorTime;
        private System.Windows.Forms.Panel pnChonPhong;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dtgvTinhTrang;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtMaDatPhong;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtSoDienThoai;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKiemTra;
        private MetroFramework.Controls.MetroDateTime checkOut;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime checkIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.RichTextBox rtxtYeuCauKhac;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
