namespace UI
{
    partial class SuaPhong
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
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbMaPhong = new MetroFramework.Controls.MetroLabel();
            this.notify = new Tulpep.NotificationWindow.PopupNotifier();
            this.SuspendLayout();
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(168, 81);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(258, 29);
            this.dtEnd.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(34, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Dự kiến hoàn thành";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(168, 126);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(258, 68);
            this.rtxtGhiChu.TabIndex = 14;
            this.rtxtGhiChu.Text = "";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(104, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Ghi chú";
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
            this.btnClose.Location = new System.Drawing.Point(353, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 32);
            this.btnClose.TabIndex = 16;
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
            this.btnCapNhat.Location = new System.Drawing.Point(256, 200);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 32);
            this.btnCapNhat.TabIndex = 15;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbMaPhong.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbMaPhong.Location = new System.Drawing.Point(168, 25);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(42, 25);
            this.lbMaPhong.TabIndex = 17;
            this.lbMaPhong.Text = "301";
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
            // SuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 274);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.rtxtGhiChu);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtEnd);
            this.Name = "SuaPhong";
            this.Text = "Sửa phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCapNhat;
        private MetroFramework.Controls.MetroLabel lbMaPhong;
        private Tulpep.NotificationWindow.PopupNotifier notify;
    }
}