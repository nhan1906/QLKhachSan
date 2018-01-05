namespace UI
{
    partial class CapNhatSuaPhong
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
            this.components = new System.ComponentModel.Container();
            this.lbMaPhong = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtChiPhiSuaPhong = new MetroFramework.Controls.MetroTextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.notify = new Tulpep.NotificationWindow.PopupNotifier();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbMaPhong.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbMaPhong.Location = new System.Drawing.Point(237, 25);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(42, 25);
            this.lbMaPhong.TabIndex = 24;
            this.lbMaPhong.Text = "301";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Chi phí sửa chữa";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::UI.Properties.Resources.back_fff;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(380, 126);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 32);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Trở về";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btnCapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(106)))), ((int)(((byte)(170)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = global::UI.Properties.Resources.save_fff;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(283, 126);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 32);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtChiPhiSuaPhong
            // 
            // 
            // 
            // 
            this.txtChiPhiSuaPhong.CustomButton.Image = null;
            this.txtChiPhiSuaPhong.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtChiPhiSuaPhong.CustomButton.Name = "";
            this.txtChiPhiSuaPhong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChiPhiSuaPhong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChiPhiSuaPhong.CustomButton.TabIndex = 1;
            this.txtChiPhiSuaPhong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChiPhiSuaPhong.CustomButton.UseSelectable = true;
            this.txtChiPhiSuaPhong.CustomButton.Visible = false;
            this.txtChiPhiSuaPhong.DisplayIcon = true;
            this.txtChiPhiSuaPhong.Icon = global::UI.Properties.Resources.vnd;
            this.txtChiPhiSuaPhong.IconRight = true;
            this.txtChiPhiSuaPhong.Lines = new string[0];
            this.txtChiPhiSuaPhong.Location = new System.Drawing.Point(145, 76);
            this.txtChiPhiSuaPhong.MaxLength = 32767;
            this.txtChiPhiSuaPhong.Name = "txtChiPhiSuaPhong";
            this.txtChiPhiSuaPhong.PasswordChar = '\0';
            this.txtChiPhiSuaPhong.PromptText = "Nhập vào chi phí đã sữa";
            this.txtChiPhiSuaPhong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChiPhiSuaPhong.SelectedText = "";
            this.txtChiPhiSuaPhong.SelectionLength = 0;
            this.txtChiPhiSuaPhong.SelectionStart = 0;
            this.txtChiPhiSuaPhong.ShortcutsEnabled = true;
            this.txtChiPhiSuaPhong.Size = new System.Drawing.Size(308, 23);
            this.txtChiPhiSuaPhong.TabIndex = 25;
            this.txtChiPhiSuaPhong.UseSelectable = true;
            this.txtChiPhiSuaPhong.WaterMark = "Nhập vào chi phí đã sữa";
            this.txtChiPhiSuaPhong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChiPhiSuaPhong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChiPhiSuaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo);
            // 
            // error
            // 
            this.error.ContainerControl = this;
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
            // CapNhatSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 352);
            this.Controls.Add(this.txtChiPhiSuaPhong);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CapNhatSuaPhong";
            this.Text = "Hoàn tất sửa phòng";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbMaPhong;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCapNhat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtChiPhiSuaPhong;
        private System.Windows.Forms.ErrorProvider error;
        private Tulpep.NotificationWindow.PopupNotifier notify;
    }
}