using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKePhongDKTheoLoai
    {
        private string maLoaiPhong;
        private string dsPhong;

        public ThongKePhongDKTheoLoai() { }

        public ThongKePhongDKTheoLoai(DataRow row)
        {
            MaLoaiPhong = row["maLoaiPhong"].ToString();
            DsPhong = row["dsPhong"].ToString();
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

        public string DsPhong
        {
            get
            {
                return dsPhong;
            }

            set
            {
                dsPhong = value;
            }
        }
    }
}
