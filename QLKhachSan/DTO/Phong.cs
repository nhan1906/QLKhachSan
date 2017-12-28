using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private int maPhong;
        private string maLoaiPhong;
        private int tangThu;

        public Phong() { }

        public Phong(DataRow row)
        {

        }

        public string MaLoaiPhong
        {
            get
            {
                return maLoaiPhong;
            }

            set
            {
                maLoaiPhong = value;
            }
        }

        public int TangThu
        {
            get
            {
                return tangThu;
            }

            set
            {
                tangThu = value;
            }
        }
    }
}
