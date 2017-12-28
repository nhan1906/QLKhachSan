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
            this.btnPower = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.quanLyTang_UC1 = new UI.QuanLyTang_UC();
            this.pnBar.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnBar.Controls.Add(this.btnPower);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBar.Location = new System.Drawing.Point(0, 0);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(800, 30);
            this.pnBar.TabIndex = 2;
            // 
            // btnPower
            // 
            this.btnPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Image = global::UI.Properties.Resources.power;
            this.btnPower.Location = new System.Drawing.Point(751, 4);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(46, 23);
            this.btnPower.TabIndex = 3;
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 30);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(150, 570);
            this.pnMenu.TabIndex = 3;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.quanLyTang_UC1);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(150, 30);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(650, 570);
            this.pnContainer.TabIndex = 4;
            // 
            // quanLyTang_UC1
            // 
            this.quanLyTang_UC1.BackColor = System.Drawing.Color.White;
            this.quanLyTang_UC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyTang_UC1.Location = new System.Drawing.Point(0, 0);
            this.quanLyTang_UC1.Name = "quanLyTang_UC1";
            this.quanLyTang_UC1.Size = new System.Drawing.Size(650, 570);
            this.quanLyTang_UC1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.pnBar.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnContainer;
        private QuanLyTang_UC quanLyTang_UC1;
    }
}

