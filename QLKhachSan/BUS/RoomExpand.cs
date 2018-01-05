using DAO;
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

        private int widthLabel, iconSize;
        private Rectangle rMain1, rMain2, rLoaiPhong, rSoPhong, rIcon, rNuaTren, rNuaDuoi, rTren, rGiua, rDuoi, rIconClean;

        
        private Phong phong;

        public RoomExpand(Phong phong)
        {
            //Dữ liệu phòng 
            this.Phong = phong;

            //Thông số 
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
            rIconClean = new Rectangle(Width - 15, 5, 10, 10);
            
            this.Paint += RoomExpand_Paint;
        }
        
        public Phong Phong
        {
            get
            {
                return phong;
            }

            set
            {
                phong = value;
            }
        }
        
        private void RoomExpand_Paint(object sender, PaintEventArgs e)
        {

            if (phong.TenTinhTrangPhong == "Trống")
            {
                VeCoBan(0, e);
                //Vẽ icon
                e.Graphics.DrawImage(Properties.Resources.tick_fff, rIcon);
            }
            else if (phong.TenTinhTrangPhong == "Đã đặt")
            {
                VeCoBan(3, e);
                //Vẽ icon
                e.Graphics.DrawImage(Properties.Resources.calendar_check, rIcon);
            }
            else if (phong.TenTinhTrangPhong == "Nhận phòng")
            {

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                SolidBrush whiteBrush = new SolidBrush(ColorTranslator.FromHtml("#F45644"));
                VeCoBan(1, e);
                //Vẽ icon
                PhieuNhanPhong phieuNhanPhong = PhieuNhanPhongDAO.Instance.LayPhieuNhanPhongTheoMaPhong(phong.MaPhong);
                KhachHang khachHang = KhachHangDAO.Instance.LayKhachHangBangMaKH(KhachHangOPhongDAO.Instance.LayMaKHThuNhatCuaPhong(phieuNhanPhong.MaNhanPhong));
                //Vẽ tên phòng
                e.Graphics.DrawString(phieuNhanPhong.CheckIn.ToShortDateString(), new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel), whiteBrush, rTren, stringFormat);
                e.Graphics.DrawString(khachHang.TenKhachHang, new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel), whiteBrush, rGiua, stringFormat);
                e.Graphics.DrawImage(Properties.Resources.bed, rIcon);
            }
            else if (phong.TenTinhTrangPhong == "Quá hạn")
            {
                VeCoBan(2, e);
                //Vẽ icon
                e.Graphics.DrawImage(Properties.Resources.timer, rIcon);
            }
            else if (phong.TenTinhTrangPhong == "Không đến")
            {
                VeCoBan(4, e);
                //Vẽ icon
                e.Graphics.DrawImage(Properties.Resources.calendar_cancel, rIcon);
            }
            else if (phong.TenTinhTrangPhong == "Đang sửa")
            {
                VeCoBan(6, e);
                //Vẽ icon
                e.Graphics.DrawImage(Properties.Resources.tick_fff, rIcon);
            }

            if(phong.Ban == 2)
            {
                e.Graphics.DrawImage(Properties.Resources.bed, rIconClean);
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
            e.Graphics.DrawString(phong.MaPhong.ToString(), new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel), whiteBrush, rSoPhong, stringFormat);


            //Vẽ loại phòng
            e.Graphics.DrawString(phong.MaLoaiPhong, new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel), whiteBrush, rLoaiPhong, stringFormat);

        }
    }
}
