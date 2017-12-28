using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChatLuong
    {
        private string tenChatLuong;
        private string ghiChu;
        

        public string TenChatLuong
        {
            get
            {
                return tenChatLuong;
            }

            set
            {
                tenChatLuong = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public ChatLuong() { }

        public ChatLuong(DataRow row)
        {
            TenChatLuong = row["tenChatLuong"].ToString();
            GhiChu = row["ghiChu"].ToString();
        }
    }
}
