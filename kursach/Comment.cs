using System;

namespace kursach
{
    class Comment
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public int ShopId { get; set; }
        public DateTime Date { get; set; }
        public string CommentContent { get; set; }


        public Comment(int userId, string userLogin,int shopId, string commentContent)
        {
            UserId = userId;
            Date = DateTime.Now;
            UserLogin = userLogin;
            ShopId = shopId;
            CommentContent = commentContent;
        }
    }
}