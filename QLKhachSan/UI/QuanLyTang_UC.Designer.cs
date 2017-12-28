namespace UI
{
    partial class QuanLyTang_UC
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
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnThaoTac = new System.Windows.Forms.Panel();
            this.txtTangThu = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.dtgvTang = new System.Windows.Forms.DataGridView();
            this.pnTruocSau = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.pnThaoTac.SuspendLayout();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTang)).BeginInit();
            this.pnTruocSau.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRight
            // 
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(630, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(20, 570);
            this.pnRight.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(20, 570);
            this.pnLeft.TabIndex = 2;
            // 
            // pnThaoTac
            // 
            this.pnThaoTac.Controls.Add(this.txtTangThu);
            this.pnThaoTac.Controls.Add(this.btnAdd);
            this.pnThaoTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThaoTac.Location = new System.Drawing.Point(20, 0);
            this.pnThaoTac.Name = "pnThaoTac";
            this.pnThaoTac.Size = new System.Drawing.Size(610, 50);
            this.pnThaoTac.TabIndex = 3;
            // 
            // txtTangThu
            // 
            // 
            // 
            // 
            this.txtTangThu.CustomButton.Image = null;
            this.txtTangThu.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txtTangThu.CustomButton.Name = "";
            this.txtTangThu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTangThu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTangThu.CustomButton.TabIndex = 1;
            this.txtTangThu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTangThu.CustomButton.UseSelectable = true;
            this.txtTangThu.CustomButton.Visible = false;
            this.txtTangThu.Lines = new string[0];
            this.txtTangThu.Location = new System.Drawing.Point(207, 15);
            this.txtTangThu.MaxLength = 32767;
            this.txtTangThu.Name = "txtTangThu";
            this.txtTangThu.PasswordChar = '\0';
            this.txtTangThu.PromptText = "Nhập tầng thứ";
            this.txtTangThu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTangThu.SelectedText = "";
            this.txtTangThu.SelectionLength = 0;
            this.txtTangThu.SelectionStart = 0;
            this.txtTangThu.ShortcutsEnabled = true;
            this.txtTangThu.Size = new System.Drawing.Size(294, 23);
            this.txtTangThu.TabIndex = 1;
            this.txtTangThu.UseSelectable = true;
            this.txtTangThu.Visible = false;
            this.txtTangThu.WaterMark = "Nhập tầng thứ";
            this.txtTangThu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTangThu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::UI.Properties.Resources.add_fff;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(507, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm tầng";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 20);
            this.panel1.TabIndex = 4;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.dtgvTang);
            this.pnContainer.Controls.Add(this.pnTruocSau);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(20, 50);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(610, 500);
            this.pnContainer.TabIndex = 5;
            // 
            // dtgvTang
            // 
            this.dtgvTang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTang.Location = new System.Drawing.Point(0, 0);
            this.dtgvTang.Name = "dtgvTang";
            this.dtgvTang.Size = new System.Drawing.Size(610, 400);
            this.dtgvTang.TabIndex = 1;
            this.dtgvTang.SelectionChanged += new System.EventHandler(this.dtgvTang_SelectionChanged);
            // 
            // pnTruocSau
            // 
            this.pnTruocSau.Controls.Add(this.btnCapNhat);
            this.pnTruocSau.Controls.Add(this.btnHuy);
            this.pnTruocSau.Controls.Add(this.btnSau);
            this.pnTruocSau.Controls.Add(this.btnTruoc);
            this.pnTruocSau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTruocSau.Location = new System.Drawing.Point(0, 400);
            this.pnTruocSau.Name = "pnTruocSau";
            this.pnTruocSau.Size = new System.Drawing.Size(610, 100);
            this.pnTruocSau.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.Color.Black;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(300, 16);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.Black;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(219, 16);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            // 
            // btnSau
            // 
            this.btnSau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSau.BackColor = System.Drawing.Color.Black;
            this.btnSau.FlatAppearance.BorderSize = 0;
            this.btnSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSau.ForeColor = System.Drawing.Color.White;
            this.btnSau.Location = new System.Drawing.Point(516, 16);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 1;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruoc.BackColor = System.Drawing.Color.Black;
            this.btnTruoc.FlatAppearance.BorderSize = 0;
            this.btnTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruoc.ForeColor = System.Drawing.Color.White;
            this.btnTruoc.Location = new System.Drawing.Point(435, 16);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc.TabIndex = 0;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // QuanLyTang_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnThaoTac);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnRight);
            this.Name = "QuanLyTang_UC";
            this.Size = new System.Drawing.Size(650, 570);
            this.pnThaoTac.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTang)).EndInit();
            this.pnTruocSau.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnThaoTac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvTang;
        private System.Windows.Forms.Panel pnTruocSau;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private MetroFramework.Controls.MetroTextBox txtTangThu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuy;
    }
}
