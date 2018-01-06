namespace UI
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBar = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSoDoPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.flpQuanLy = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuanLyPhong = new System.Windows.Forms.Button();
            this.btnQuanLyLoaiPhong = new System.Windows.Forms.Button();
            this.btnQuanLyTang = new System.Windows.Forms.Button();
            this.btnQLDichVu = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuyDinh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.notify = new Tulpep.NotificationWindow.PopupNotifier();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.pnBar.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.flpQuanLy.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnBar.Controls.Add(this.metroLabel1);
            this.pnBar.Controls.Add(this.btnUser);
            this.pnBar.Controls.Add(this.btnPower);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.Location = new System.Drawing.Point(0, 0);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(800, 30);
            this.pnBar.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.metroLabel1.Location = new System.Drawing.Point(10, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Khách sạn Đại Nam";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Image = global::UI.Properties.Resources.user;
            this.btnUser.Location = new System.Drawing.Point(747, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(22, 23);
            this.btnUser.TabIndex = 4;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnPower
            // 
            this.btnPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Image = global::UI.Properties.Resources.power;
            this.btnPower.Location = new System.Drawing.Point(775, 4);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(22, 23);
            this.btnPower.TabIndex = 3;
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.flpMenu.Controls.Add(this.btnSoDoPhong);
            this.flpMenu.Controls.Add(this.btnDatPhong);
            this.flpMenu.Controls.Add(this.btnQuanLy);
            this.flpMenu.Controls.Add(this.flpQuanLy);
            this.flpMenu.Controls.Add(this.btnDanhMuc);
            this.flpMenu.Controls.Add(this.flowLayoutPanel1);
            this.flpMenu.Controls.Add(this.btnKhachHang);
            this.flpMenu.Controls.Add(this.btnQLTaiKhoan);
            this.flpMenu.Controls.Add(this.btnQuanLyNhanVien);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Location = new System.Drawing.Point(0, 30);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(150, 570);
            this.flpMenu.TabIndex = 3;
            // 
            // btnSoDoPhong
            // 
            this.btnSoDoPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSoDoPhong.FlatAppearance.BorderSize = 0;
            this.btnSoDoPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoDoPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoDoPhong.Location = new System.Drawing.Point(3, 3);
            this.btnSoDoPhong.Name = "btnSoDoPhong";
            this.btnSoDoPhong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSoDoPhong.Size = new System.Drawing.Size(144, 31);
            this.btnSoDoPhong.TabIndex = 4;
            this.btnSoDoPhong.Text = "Sơ đồ phòng";
            this.btnSoDoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoDoPhong.UseVisualStyleBackColor = true;
            this.btnSoDoPhong.Click += new System.EventHandler(this.btnSoDoPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.btnDatPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(3, 40);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDatPhong.Size = new System.Drawing.Size(144, 31);
            this.btnDatPhong.TabIndex = 5;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.Location = new System.Drawing.Point(3, 77);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(144, 31);
            this.btnQuanLy.TabIndex = 6;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // flpQuanLy
            // 
            this.flpQuanLy.Controls.Add(this.btnQuanLyPhong);
            this.flpQuanLy.Controls.Add(this.btnQuanLyLoaiPhong);
            this.flpQuanLy.Controls.Add(this.btnQuanLyTang);
            this.flpQuanLy.Controls.Add(this.btnQLDichVu);
            this.flpQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpQuanLy.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQuanLy.Location = new System.Drawing.Point(3, 114);
            this.flpQuanLy.Name = "flpQuanLy";
            this.flpQuanLy.Size = new System.Drawing.Size(144, 149);
            this.flpQuanLy.TabIndex = 0;
            this.flpQuanLy.Visible = false;
            // 
            // btnQuanLyPhong
            // 
            this.btnQuanLyPhong.BackColor = System.Drawing.Color.Gray;
            this.btnQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyPhong.FlatAppearance.BorderSize = 0;
            this.btnQuanLyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyPhong.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyPhong.Location = new System.Drawing.Point(25, 3);
            this.btnQuanLyPhong.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnQuanLyPhong.Name = "btnQuanLyPhong";
            this.btnQuanLyPhong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLyPhong.Size = new System.Drawing.Size(116, 31);
            this.btnQuanLyPhong.TabIndex = 19;
            this.btnQuanLyPhong.Text = "Phòng";
            this.btnQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyPhong.UseVisualStyleBackColor = false;
            this.btnQuanLyPhong.Click += new System.EventHandler(this.btnQuanLyPhong_Click);
            // 
            // btnQuanLyLoaiPhong
            // 
            this.btnQuanLyLoaiPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyLoaiPhong.FlatAppearance.BorderSize = 0;
            this.btnQuanLyLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLoaiPhong.Location = new System.Drawing.Point(25, 40);
            this.btnQuanLyLoaiPhong.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnQuanLyLoaiPhong.Name = "btnQuanLyLoaiPhong";
            this.btnQuanLyLoaiPhong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLyLoaiPhong.Size = new System.Drawing.Size(116, 31);
            this.btnQuanLyLoaiPhong.TabIndex = 20;
            this.btnQuanLyLoaiPhong.Text = "Loại phòng";
            this.btnQuanLyLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyLoaiPhong.UseVisualStyleBackColor = true;
            this.btnQuanLyLoaiPhong.Click += new System.EventHandler(this.btnQuanLyLoaiPhong_Click);
            // 
            // btnQuanLyTang
            // 
            this.btnQuanLyTang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyTang.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTang.Location = new System.Drawing.Point(25, 77);
            this.btnQuanLyTang.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnQuanLyTang.Name = "btnQuanLyTang";
            this.btnQuanLyTang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLyTang.Size = new System.Drawing.Size(116, 31);
            this.btnQuanLyTang.TabIndex = 21;
            this.btnQuanLyTang.Text = "Tầng";
            this.btnQuanLyTang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTang.UseVisualStyleBackColor = true;
            this.btnQuanLyTang.Click += new System.EventHandler(this.btnQuanLyTang_Click);
            // 
            // btnQLDichVu
            // 
            this.btnQLDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQLDichVu.FlatAppearance.BorderSize = 0;
            this.btnQLDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDichVu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDichVu.Location = new System.Drawing.Point(25, 114);
            this.btnQLDichVu.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnQLDichVu.Name = "btnQLDichVu";
            this.btnQLDichVu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLDichVu.Size = new System.Drawing.Size(116, 31);
            this.btnQLDichVu.TabIndex = 22;
            this.btnQLDichVu.Text = "Dịch vụ";
            this.btnQLDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDichVu.UseVisualStyleBackColor = true;
            this.btnQLDichVu.Click += new System.EventHandler(this.btnQLDichVu_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Location = new System.Drawing.Point(3, 269);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(144, 31);
            this.btnDanhMuc.TabIndex = 23;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnQuyDinh);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 306);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 149);
            this.flowLayoutPanel1.TabIndex = 24;
            this.flowLayoutPanel1.Visible = false;
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.BackColor = System.Drawing.Color.Gray;
            this.btnQuyDinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuyDinh.FlatAppearance.BorderSize = 0;
            this.btnQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyDinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyDinh.ForeColor = System.Drawing.Color.White;
            this.btnQuyDinh.Location = new System.Drawing.Point(25, 3);
            this.btnQuyDinh.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuyDinh.Size = new System.Drawing.Size(116, 31);
            this.btnQuyDinh.TabIndex = 19;
            this.btnQuyDinh.Text = "Phòng";
            this.btnQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuyDinh.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 40);
            this.button3.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(116, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Loại phòng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 77);
            this.button4.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(116, 31);
            this.button4.TabIndex = 21;
            this.button4.Text = "Tầng";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(25, 114);
            this.button5.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(116, 31);
            this.button5.TabIndex = 22;
            this.button5.Text = "Dịch vụ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Location = new System.Drawing.Point(3, 461);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(144, 31);
            this.btnKhachHang.TabIndex = 24;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnQLTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(3, 498);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(144, 31);
            this.btnQLTaiKhoan.TabIndex = 25;
            this.btnQLTaiKhoan.Text = "Tài khoản";
            this.btnQLTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(150, 30);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(650, 570);
            this.pnContainer.TabIndex = 4;
            // 
            // notify
            // 
            this.notify.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            this.notify.ContentText = null;
            this.notify.Image = null;
            this.notify.IsRightToLeft = false;
            this.notify.OptionsMenu = null;
            this.notify.Size = new System.Drawing.Size(400, 100);
            this.notify.TitleFont = new System.Drawing.Font("Segoe UI", 11.25F);
            this.notify.TitleText = null;
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(3, 535);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(144, 31);
            this.btnQuanLyNhanVien.TabIndex = 26;
            this.btnQuanLyNhanVien.Text = "Nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.pnBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.pnBar.ResumeLayout(false);
            this.pnBar.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.flpQuanLy.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnSoDoPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.FlowLayoutPanel flpQuanLy;
        private System.Windows.Forms.Button btnQuanLyPhong;
        private System.Windows.Forms.Button btnQuanLyLoaiPhong;
        private System.Windows.Forms.Button btnQuanLyTang;
        private System.Windows.Forms.Button btnQLDichVu;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnQuyDinh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnContainer;
        private Tulpep.NotificationWindow.PopupNotifier notify;
        private System.Windows.Forms.Button btnUser;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
    }
}

