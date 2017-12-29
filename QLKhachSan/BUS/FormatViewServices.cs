using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class FormatViewServices
    {
        #region Singleton
        private static FormatViewServices _instance;

        public static FormatViewServices Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormatViewServices();
                return _instance;
            }
        }

        private FormatViewServices() { }
        #endregion

        public void FormatDataGridView(DataGridView dtgv)
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();

            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Padding = new Padding(10, 6, 0, 6);
            dataGridViewCellStyle1.Font = new Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.Font = new Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv.GridColor = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dtgv.ReadOnly = true;
            dtgv.RowTemplate.Height = 100;
            //
            dtgv.RowHeadersVisible = false;


            dtgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dtgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dtgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dtgv.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            dtgv.BorderStyle = BorderStyle.None;
            dtgv.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            dtgv.GridColor = ColorTranslator.FromHtml("#4CAF50");
            dtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F6F6F6");
            dtgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#7A7A7A");
            dtgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#A5D6A7");
            dtgv.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#000000");

            //chẳng lẻ
            dtgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E8E8E8");
            //
            dtgv.EnableHeadersVisualStyles = false;
            dtgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#4CAF50");
            dtgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            dtgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            //Không cho chỉnh sửa xóa
            dtgv.AllowUserToAddRows = false;
            dtgv.AllowUserToDeleteRows = false;
            dtgv.AllowUserToResizeColumns = false;
            dtgv.AllowUserToResizeRows = false;
            dtgv.MultiSelect = false;
            dtgv.ReadOnly = true;
            //
            dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgv.ColumnHeadersHeight = 50;
            
        }

        public void FormatLabelTang(Label label1, Bitmap img)
        {
            label1.Image = img;
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(430, 473);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 100);
            label1.Font = new Font("Cambria", 10.75f, FontStyle.Bold);
            label1.TabIndex = 108;
            label1.Text = "Tầng 1";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
    }
}
