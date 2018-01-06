using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuPhuThuDAO
    {
        #region Singleton
        private static PhieuPhuThuDAO instance;

        public static PhieuPhuThuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuPhuThuDAO();
                return instance;
            }
        }

        private PhieuPhuThuDAO() { }

        #endregion


        private DataProvider provider = DataProvider.Instance;

        public bool ThemPhieuPhuThu(PhieuPhuThu phieuPhuThu)
        {
            return provider.ExecuteNonQuery("insert into PhieuPhuThu (tienPhuThu , nguyenNhan)values(" + phieuPhuThu.TienPhuThu + " , N'" + phieuPhuThu.NguyenNhan + "')") > 0;
        }

    }
}
