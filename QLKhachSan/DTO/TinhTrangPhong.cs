using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrangPhong
    {
        private string tenTinhTrangPhong;

        public TinhTrangPhong(DataRow row)
        {
            TenTinhTrangPhong = row["tenTinhTrangPhong"].ToString();
        }

        public TinhTrangPhong()
        {

        }

        public string TenTinhTrangPhong
        {
            get
            {
                return tenTinhTrangPhong;
            }

            set
            {
                tenTinhTrangPhong = value;
            }
        }
    }
}
