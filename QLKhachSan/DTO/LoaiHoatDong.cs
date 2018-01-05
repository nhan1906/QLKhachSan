using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHoatDong
    {
        private int idLoaiHoatDong;
        private string tenLoaiHoatDong;

        public LoaiHoatDong()
        {

        }

        public LoaiHoatDong(DataRow row)
        {
            idLoaiHoatDong = (int)row["idLoaiHoatDong"];
            tenLoaiHoatDong = row["tenLoaiHoatDong"].ToString();
        }

        public int IdLoaiHoatDong
        {
            get
            {
                return idLoaiHoatDong;
            }

            set
            {
                idLoaiHoatDong = value;
            }
        }

        public string TenLoaiHoatDong
        {
            get
            {
                return tenLoaiHoatDong;
            }

            set
            {
                tenLoaiHoatDong = value;
            }
        }
    }
}
