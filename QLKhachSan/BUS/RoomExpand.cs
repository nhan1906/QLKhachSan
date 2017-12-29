using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BUS.Util;

namespace BUS
{
    public class RoomExpand : Control
    {
        public RoomExpand()
        {
            this.Width = 230;
            this.Height = 70;
            widthLabel = 50;
            iconSize = 10;
            rMain1 = new Rectangle(0, 0, widthLabel, Height);
            rMain2 = new Rectangle(widthLabel, 0, Width - widthLabel, Height);
            rLoaiPhong = new Rectangle(0, 0, widthLabel, Height / 3);
            rSoPhong = new Rectangle(0, Height / 3, widthLabel, Height / 3);
            rIcon = new Rectangle(widthLabel / 2 - iconSize / 2, 5 * Height / 6 - iconSize / 2, iconSize, iconSize);
            rNuaTren = new Rectangle(widthLabel, 0, Width - widthLabel, Height / 2);
            rNuaTren = new Rectangle(widthLabel, Height / 2, Width - widthLabel, Height / 2);
            rTren = new Rectangle(widthLabel, 0, Width - widthLabel, Height / 3);
            rGiua = new Rectangle(widthLabel, Height / 3, Width - widthLabel, Height / 3);
            rDuoi = new Rectangle(widthLabel, 2 * Height / 3, Width - widthLabel, Height / 3);
            TinhTrang = TinhTrang.Trong;
            this.Paint += RoomExpand_Paint;
        }


        private TinhTrang tinhTrang;
        private int widthLabel, iconSize;
        private Rectangle rMain1, rMain2, rLoaiPhong, rSoPhong, rIcon, rNuaTren, rNuaDuoi, rTren, rGiua, rDuoi;
        private Phong phong;

        public RoomExpand(Phong phong)
        {
            

        }

        public TinhTrang TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }

        private void RoomExpand_Paint(object sender, PaintEventArgs e)
        {

            switch (TinhTrang)
            {
                case TinhTrang.Trong:
                    VeCoBan(0, e);
                    //Vẽ icon
                    e.Graphics.DrawImage(Properties.Resources.tick_fff, rIcon);
                    break;
                case TinhTrang.NhanPhong:
                    VeCoBan(1, e);
                    //Vẽ icon
                    e.Graphics.DrawImage(Properties.Resources.bed, rIcon);
                    break;
                case TinhTrang.QuaHan:
                    VeCoBan(2, e);
                    //Vẽ icon
                    e.Graphics.DrawImage(Properties.Resources.timer, rIcon);
                    break;
                case TinhTrang.DaDat:
                    VeCoBan(3, e);
                    //Vẽ icon
                    e.Graphics.DrawImage(Properties.Resources.calendar_check, rIcon);
                    break;
                case TinhTrang.KhongDen:
                    VeCoBan(4, e);
                    //Vẽ icon
                    e.Graphics.DrawImage(Properties.Resources.calendar_cancel, rIcon);
                    break;
                case TinhTrang.Ban:
                    VeCoBan(5, e);
                    //Vẽ icon
                    e.Graphics.DrawImage(Properties.Resources.timer, rIcon);
                    break;
                case TinhTrang.DangSua:
                    VeCoBan(6, e);
                    //Vẽ icon
                    e.Graphics.DrawImage(Properties.Resources.tick_fff, rIcon);
                    break;
            }

        }

        public void VeCoBan(int i, PaintEventArgs e)
        {
            SolidBrush background = new SolidBrush(ColorTranslator.FromHtml(ColorsTinhTrangPhong[i]));
            SolidBrush bannerBackground = new SolidBrush(ColorTranslator.FromHtml(ColorBanner[i]));
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            SolidBrush whiteBrush = new SolidBrush(ColorTranslator.FromHtml("#FFFFFF"));


            e.Graphics.FillRectangle(bannerBackground, rMain1);
            e.Graphics.FillRectangle(background, rMain2);


            //Vẽ tên phòng
            e.Graphics.DrawString("301", new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel), whiteBrush, rSoPhong, stringFormat);


            //Vẽ loại phòng
            e.Graphics.DrawString("VS11", new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel), whiteBrush, rLoaiPhong, stringFormat);

        }
    }
}
