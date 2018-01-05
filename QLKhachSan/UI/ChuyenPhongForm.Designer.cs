namespace UI
{
    partial class ChuyenPhongForm
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.lbPhong = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChuyenPhong = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(149, 102);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(23, 68);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(56, 19);
            this.lbPhong.TabIndex = 1;
            this.lbPhong.Text = "Chuyển ";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "301"};
            this.metroTextBox1.Location = new System.Drawing.Point(149, 68);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(185, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "301";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Sang";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(149, 231);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(185, 30);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnChuyenPhong
            // 
            this.btnChuyenPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnChuyenPhong.FlatAppearance.BorderSize = 0;
            this.btnChuyenPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenPhong.ForeColor = System.Drawing.Color.White;
            this.btnChuyenPhong.Location = new System.Drawing.Point(149, 195);
            this.btnChuyenPhong.Name = "btnChuyenPhong";
            this.btnChuyenPhong.Size = new System.Drawing.Size(185, 30);
            this.btnChuyenPhong.TabIndex = 5;
            this.btnChuyenPhong.Text = "Chuyển phòng";
            this.btnChuyenPhong.UseVisualStyleBackColor = false;
            this.btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Thuộc loại phòng";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(149, 146);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox2.TabIndex = 7;
            this.metroComboBox2.UseSelectable = true;
            // 
            // ChuyenPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 366);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChuyenPhong);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.lbPhong);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "ChuyenPhongForm";
            this.Text = "Chuyển phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel lbPhong;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChuyenPhong;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
    }
}