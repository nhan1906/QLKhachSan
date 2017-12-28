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
        private int maTinhTrangPhong;
        private string tenTinhTrangPhong;

        public TinhTrangPhong(DataRow row)
        {
            MaTinhTrangPhong = (int)row["maTinhTrangPhong"];
            TenTinhTrangPhong = row["tenTinhTrangPhong"].ToString();
        }

        public int MaTinhTrangPhong
        {
            get
            {
                return maTinhTrangPhong;
            }

            set
            {
                maTinhTrangPhong = value;
            }
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
