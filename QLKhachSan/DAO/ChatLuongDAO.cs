using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChatLuongDAO
    {
        #region Singleton
        private static ChatLuongDAO instance;

        public static ChatLuongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChatLuongDAO();
                return instance;
            }
        }

        private ChatLuongDAO() { }

        #endregion

        private DataProvider provider = DataProvider.Instance;


        public List<ChatLuong> LayDanhSachChatLuong()
        {
            List<ChatLuong> list = new List<ChatLuong>();
            DataTable data = provider.ExecuteQuery("Select * from ChatLuong");
            foreach(DataRow row in data.Rows)
            {
                list.Add(new ChatLuong(row));
            }
            return list;
        }
    }
}
