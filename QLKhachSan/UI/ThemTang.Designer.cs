namespace UI
{
    partial class ThemTang
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
            this.autoGenerateLink = new MetroFramework.Controls.MetroLink();
            this.btnSave = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTangThu = new MetroFramework.Controls.MetroTextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // autoGenerateLink
            // 
            this.autoGenerateLink.Location = new System.Drawing.Point(111, 117);
            this.autoGenerateLink.Name = "autoGenerateLink";
            this.autoGenerateLink.Size = new System.Drawing.Size(75, 23);
            this.autoGenerateLink.TabIndex = 13;
            this.autoGenerateLink.Text = "Tạo tự động";
            this.autoGenerateLink.UseSelectable = true;
            this.autoGenerateLink.Click += new System.EventHandler(this.autoGenerateLink_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::UI.Properties.Resources.save_fff;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(354, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(28, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Tầng thứ";
            // 
            // txtTangThu
            // 
            // 
            // 
            // 
            this.txtTangThu.CustomButton.Image = null;
            this.txtTangThu.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.txtTangThu.CustomButton.Name = "";
            this.txtTangThu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTangThu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTangThu.CustomButton.TabIndex = 1;
            this.txtTangThu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTangThu.CustomButton.UseSelectable = true;
            this.txtTangThu.CustomButton.Visible = false;
            this.txtTangThu.Lines = new string[0];
            this.txtTangThu.Location = new System.Drawing.Point(111, 88);
            this.txtTangThu.MaxLength = 32767;
            this.txtTangThu.Name = "txtTangThu";
            this.txtTangThu.PasswordChar = '\0';
            this.txtTangThu.PromptText = "Nhập tầng thứ... (bắt buộc)";
            this.txtTangThu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTangThu.SelectedText = "";
            this.txtTangThu.SelectionLength = 0;
            this.txtTangThu.SelectionStart = 0;
            this.txtTangThu.ShortcutsEnabled = true;
            this.txtTangThu.Size = new System.Drawing.Size(304, 23);
            this.txtTangThu.TabIndex = 10;
            this.txtTangThu.UseSelectable = true;
            this.txtTangThu.WaterMark = "Nhập tầng thứ... (bắt buộc)";
            this.txtTangThu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTangThu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTangThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTangThu_KeyPress);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // ThemTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 201);
            this.Controls.Add(this.autoGenerateLink);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtTangThu);
            this.Name = "ThemTang";
            this.Text = "Thêm tầng";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink autoGenerateLink;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTangThu;
        private System.Windows.Forms.ErrorProvider error;
    }
}