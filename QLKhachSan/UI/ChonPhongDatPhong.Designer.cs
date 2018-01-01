namespace UI
{
    partial class ChonPhongDatPhong
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
            this.lsvChonPhong = new MetroFramework.Controls.MetroListView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvChonPhong
            // 
            this.lsvChonPhong.CheckBoxes = true;
            this.lsvChonPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lsvChonPhong.FullRowSelect = true;
            this.lsvChonPhong.Location = new System.Drawing.Point(23, 86);
            this.lsvChonPhong.Name = "lsvChonPhong";
            this.lsvChonPhong.OwnerDraw = true;
            this.lsvChonPhong.Size = new System.Drawing.Size(361, 274);
            this.lsvChonPhong.TabIndex = 0;
            this.lsvChonPhong.UseCompatibleStateImageBehavior = false;
            this.lsvChonPhong.UseSelectable = true;
            this.lsvChonPhong.View = System.Windows.Forms.View.List;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(390, 331);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(82, 29);
            this.btnCapNhat.TabIndex = 104;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // ChonPhongDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 383);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lsvChonPhong);
            this.Name = "ChonPhongDatPhong";
            this.Text = "ChonPhongDatPhong";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lsvChonPhong;
        private System.Windows.Forms.Button btnCapNhat;
    }
}