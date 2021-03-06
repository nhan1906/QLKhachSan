﻿using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using DTO;

namespace BUS
{
    public class ChiTietHoatDongService
    {
        #region Singleton
        private static ChiTietHoatDongService instance;

        public static ChiTietHoatDongService Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoatDongService();
                return instance;
            }
        }


        private ChiTietHoatDongService() { }
        #endregion

        private ChiTietHoatDongDAO data = ChiTietHoatDongDAO.Instance;

        public bool KiemTraDaTonTaiMa(string maHD)
        {
            return data.KiemTraMaDaTonTai(maHD);
        }
        
        public void TinhTienPhong(MetroTextBox txtTienPhong, Phong phong)
        {
            txtTienPhong.Text = data.TinhTienPhong(phong).ToString();
        }
    }
}
