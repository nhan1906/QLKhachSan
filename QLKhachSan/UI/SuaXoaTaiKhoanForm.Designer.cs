namespace UI
{
    partial class SuaXoaTaiKhoanForm
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
            this.btnCapMK = new System.Windows.Forms.Button();
            this.btnXoaMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCapMK
            // 
            this.btnCapMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnCapMK.FlatAppearance.BorderSize = 0;
            this.btnCapMK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnCapMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnCapMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapMK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapMK.ForeColor = System.Drawing.Color.White;
            this.btnCapMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapMK.Location = new System.Drawing.Point(24, 79);
            this.btnCapMK.Name = "btnCapMK";
            this.btnCapMK.Size = new System.Drawing.Size(139, 32);
            this.btnCapMK.TabIndex = 9;
            this.btnCapMK.Text = "Cấp lại mật khẩu";
            this.btnCapMK.UseVisualStyleBackColor = false;
            this.btnCapMK.Click += new System.EventHandler(this.btnCapMK_Click);
            // 
            // btnXoaMK
            // 
            this.btnXoaMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.btnXoaMK.FlatAppearance.BorderSize = 0;
            this.btnXoaMK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnXoaMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(154)))), ((int)(((byte)(163)))));
            this.btnXoaMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMK.ForeColor = System.Drawing.Color.White;
            this.btnXoaMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMK.Location = new System.Drawing.Point(169, 79);
            this.btnXoaMK.Name = "btnXoaMK";
            this.btnXoaMK.Size = new System.Drawing.Size(128, 32);
            this.btnXoaMK.TabIndex = 10;
            this.btnXoaMK.Text = "Xóa tài khoản";
            this.btnXoaMK.UseVisualStyleBackColor = false;
            this.btnXoaMK.Click += new System.EventHandler(this.btnXoaMK_Click);
            // 
            // SuaXoaTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 162);
            this.Controls.Add(this.btnCapMK);
            this.Controls.Add(this.btnXoaMK);
            this.Name = "SuaXoaTaiKhoanForm";
            this.Text = "Chọn thao tác";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapMK;
        private System.Windows.Forms.Button btnXoaMK;
    }
}