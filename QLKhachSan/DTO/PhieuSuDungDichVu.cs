using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuSuDungDichVu
    {
        private string maSDDV;
        private string maDV;
        private int soLuong;
        private DateTime thoiGianNhan;

        public PhieuSuDungDichVu() { }

        public PhieuSuDungDichVu(DataRow row)
        {
            maSDDV = row["maSDDV"].ToString();
            maDV = row["maDV"].ToString();
            soLuong = (int)row["soLuong"];
            thoiGianNhan = (DateTime)row["thoigianNhan"];
        }

        public string MaSDDV
        {
            get
            {
                return maSDDV;
            }

            set
            {
                maSDDV = value;
            }
        }

        public string MaDV
        {
            get
            {
                return maDV;
            }

            set
            {
                maDV = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public DateTime ThoiGianNhan
        {
            get
            {
                return thoiGianNhan;
            }

            set
            {
                thoiGianNhan = value;
            }
        }
    }
}
