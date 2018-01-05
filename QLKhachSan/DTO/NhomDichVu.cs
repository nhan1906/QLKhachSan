using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomDichVu
    {

        private string tenLoaiDV;

        public NhomDichVu() { }

        public NhomDichVu(DataRow row)
        {
            tenLoaiDV = row["tenLoaiDV"].ToString();
        }

        public string TenLoaiDV
        {
            get
            {
                return tenLoaiDV;
            }

            set
            {
                tenLoaiDV = value;
            }
        }
    }
}
