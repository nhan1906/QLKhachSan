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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.dtgvTang = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnThaoTac.SuspendLayout();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTang)).BeginInit();
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
            this.pnThaoTac.Controls.Add(this.btnAdd);
            this.pnThaoTac.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThaoTac.Location = new System.Drawing.Point(20, 0);
            this.pnThaoTac.Name = "pnThaoTac";
            this.pnThaoTac.Size = new System.Drawing.Size(610, 50);
            this.pnThaoTac.TabIndex = 3;
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
            this.dtgvTang.Size = new System.Drawing.Size(610, 500);
            this.dtgvTang.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnThaoTac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.DataGridView dtgvTang;
        private System.Windows.Forms.Button btnAdd;
    }
}
