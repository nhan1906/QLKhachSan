using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Util
    {
        public enum TinhTrang
        {
            Trong, NhanPhong, QuaHan, DaDat, KhongDen, Ban, DangSua
        }

        public static string[] ColorBanner = { "#45A343", "#EE534F", "#F65C1C", "#1D89E4", "#9A29AF", "#D1B488", "#617C8D" };
        public static string[] ColorsTinhTrangPhong = { "#E8F6E9", "#FFEBED", "#FBE9E7", "#BBDEFC", "#F3E5FC", "#FBE9E7", "#CFD8DD" };
    }
}
