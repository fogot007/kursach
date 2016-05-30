using System.Data;
using MySql.Data.MySqlClient;

namespace kursach
{
    class MySqlForCommentsTable:MySql
    {
        public DataTable GetComments(int shopId)
        {
            DataTable commnets = new DataTable();
            using (Connection)
            {
                Connection.Open();
                Command = new MySqlCommand("SELECT * FROM comments WHERE shop_id = @Id;",Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@Id", shopId);
                using (Adapter = new MySqlDataAdapter(Command))
                {
                    Adapter.Fill(commnets);
                }
            }
            return commnets;
        }

        public void AddComment(Comment comment)
        {
            using (Connection)
            {
                Connection.Open();
                using (Command = new MySqlCommand("INSERT INTO comments VALUES(NULL,@UserId,@UserLogin,@ShopId,@Comment,@Date)",Connection))
                {
                    Command.Prepare();
                    Command.Parameters.AddWithValue("@UserId",comment.UserId);
                    Command.Parameters.AddWithValue("@UserLogin",comment.UserLogin);
                    Command.Parameters.AddWithValue("@ShopId", comment.ShopId);
                    Command.Parameters.AddWithValue("@Comment", comment.CommentContent);
                    Command.Parameters.AddWithValue("@Date",comment.Date);
                    Command.ExecuteNonQuery();
                }
            }
        }
    }
}
