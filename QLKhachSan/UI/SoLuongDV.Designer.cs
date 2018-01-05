namespace UI
{
    partial class SoLuongDV
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSoLuong = new MetroFramework.Controls.MetroTextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(12, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Số lượng";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.CustomButton.Image = null;
            this.txtSoLuong.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtSoLuong.CustomButton.Name = "";
            this.txtSoLuong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoLuong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoLuong.CustomButton.TabIndex = 1;
            this.txtSoLuong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoLuong.CustomButton.UseSelectable = true;
            this.txtSoLuong.CustomButton.Visible = false;
            this.txtSoLuong.Lines = new string[] {
        "1"};
            this.txtSoLuong.Location = new System.Drawing.Point(99, 38);
            this.txtSoLuong.MaxLength = 32767;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.SelectionLength = 0;
            this.txtSoLuong.SelectionStart = 0;
            this.txtSoLuong.ShortcutsEnabled = true;
            this.txtSoLuong.Size = new System.Drawing.Size(156, 23);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.UseSelectable = true;
            this.txtSoLuong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoLuong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(195, 77);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 30);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(99, 77);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 30);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.BackColor = System.Drawing.Color.White;
            this.lbDonVi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.ForeColor = System.Drawing.Color.Black;
            this.lbDonVi.Location = new System.Drawing.Point(213, 40);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDonVi.Size = new System.Drawing.Size(40, 17);
            this.lbDonVi.TabIndex = 0;
            this.lbDonVi.Text = "Chiếc";
            // 
            // SoLuongDV
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(309, 144);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoLuongDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoLuongDV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSoLuong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lbDonVi;
    }
}