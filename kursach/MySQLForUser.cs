using System.Text;
using MySql.Data.MySqlClient;

namespace kursach
{
    public class MySqlForUser : MySql
    {
        public MySqlForUser()
        {
        }

        public void PushUser(string login, string password, int groupId)
        {
            using (Connection)
            {
                Connection.Open();
                using (
                    var cmd =
                        new MySqlCommand(
                            "INSERT INTO users(user_login,user_password,group_id) VALUES(@login,@password,@groupId)",
                            Connection))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@groupId", groupId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public StringBuilder SelectLogin(string login)
        {
            var dbLogin = new StringBuilder();
            using (Connection)
            {
                Connection.Open();
                using (
                    Command =
                        new MySqlCommand(
                            "SELECT user_login FROM users WHERE user_login = @login;",
                            Connection))
                {
                    Command.Parameters.AddWithValue("@login", login);
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dbLogin.Append(reader.GetString(0));
                        }
                    }
                    return dbLogin;
                }
            }
        }

//        public 
    }
}