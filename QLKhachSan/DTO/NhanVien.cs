using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private int idNV;
        private string maNV;
        private string maLL;
        private string thuocPhongBan;
        private SoYeuLiLich lyLich;

        public NhanVien() { }

        public NhanVien(DataRow row)
        {
            idNV = (int)row["idNV"];
            maNV = row["maNV"].ToString();
            maLL = row["maLL"].ToString();

            DataTable dataMaLL = DataProvider.Instance.ExecuteQuery("select * from SoYeuLiLich where maLL = N'" + maLL + "'");
            LyLich = new SoYeuLiLich(dataMaLL.Rows[0]);
        }

        public int IdNV
        {
            get
            {
                return idNV;
            }

            set
            {
                idNV = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }

        public string MaLL
        {
            get
            {
                return maLL;
            }

            set
            {
                maLL = value;
            }
        }

        public string ThuocPhongBan
        {
            get
            {
                return thuocPhongBan;
            }

            set
            {
                thuocPhongBan = value;
            }
        }

        public SoYeuLiLich LyLich
        {
            get
            {
                return lyLich;
            }

            set
            {
                lyLich = value;
            }
        }
    }
}
