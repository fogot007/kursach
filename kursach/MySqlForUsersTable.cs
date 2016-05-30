using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public class MySqlForUsersTable : MySql
    {
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

        public string SelectLogin(string login)
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
                    return dbLogin.ToString();
                }
            }
        }

        public User GetLogin(string login)
        {
            var dbLogin = new StringBuilder();
            var dbPassword = new StringBuilder();
            var dbGroup = new StringBuilder();
            var dbUserId = new StringBuilder();
            using (Connection)
            {
                Connection.Open();
                using (
                    var cmd =
                        new MySqlCommand("SELECT * FROM users WHERE user_login = @login Limit 1;", Connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dbUserId.Append(reader.GetString(0));
                            dbLogin.Append(reader.GetString(1));
                            dbPassword.Append(reader.GetString(2));
                            dbGroup.Append(reader.GetString(3));
                        }
                    }
                }
            }
            return new User(int.Parse(dbGroup.ToString()), dbLogin.ToString(), int.Parse(dbUserId.ToString()),
                dbPassword.ToString());
        }

        public void DeleteUser(int userId)
        {
            using (Connection)
            {
                Connection.Open();
                using (
                    var cmd =
                        new MySqlCommand(
                            "DELETE FROM users WHERE user_id = @Id LIMIT 1",
                            Connection))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void FillDataUsers(DataGridView data)
        {
            using (Connection)
            {
                Connection.Open();
                using (var a = new MySqlDataAdapter(
                    "SELECT user_id, user_login, group_id FROM users", Connection))
                {
                    var t = new DataTable();
                    a.Fill(t);
                    data.DataSource = t;
                }
            }
        }

        public void UpdateUser(User user, bool checkBoxToAdmin)
        {
            var group = user.GroupId;
            if (checkBoxToAdmin)
            {
                group = 1;
            }

            using (
                var connection = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                connection.Open();
                using (
                    var cmd =
                        new MySqlCommand(
                            "UPDATE users SET user_login = @Login, group_id = @Group WHERE user_id = @UserId",
                            connection))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Login", user.UserLogin);
                    cmd.Parameters.AddWithValue("@Group", group);
                    cmd.Parameters.AddWithValue("@UserId", user.UserId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddUser(User user, bool checkBoxToAdmin)
        {
            if (checkBoxToAdmin)
                user.GroupId = 1;
            var md5Hash = MD5.Create();
            var password = MyMd5.GetMd5Hash(md5Hash, user.UserPassword);
            var dbLogin = new StringBuilder();
            using (Connection)
            {
                Connection.Open();
                using (
                    var cmd =
                        new MySqlCommand(
                            "SELECT user_login FROM users WHERE user_login = @login;",
                            Connection))
                {
                    cmd.Parameters.AddWithValue("@login", user.UserLogin);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dbLogin.Append(reader.GetString(0));
                        }
                    }
                }

                if (dbLogin.Length >= user.UserLogin.Length)
                {
                    return;
                }
                using (
                    var cmd =
                        new MySqlCommand(
                            "INSERT INTO users(user_login,user_password,group_id) VALUES(@login,@password,@groupId)",
                            Connection))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@login", user.UserLogin);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@groupId", user.GroupId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataBase()
        {
            var t = new DataTable("User");
            using (Connection)
            {
                Connection.Open();
                using (var a = new MySqlDataAdapter(
                    "SELECT * FROM users", Connection))
                {
                    a.Fill(t);
                }
            }
            return t;
        }

        public void ExportData(DataSet dataSet)
        {
            User user = new User();
            using (Connection)
            {
                Connection.Open();
                using (
                    MySqlCommand cmd =
                        new MySqlCommand(
                            "INSERT INTO users(user_id ,user_login,user_password,group_id) VALUES(@userId,@login,@password,@groupId) ON DUPLICATE KEY UPDATE group_id=@groupId",
                            Connection))
                {
                    for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
                    {
                        user.UserId = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
                        user.UserLogin = dataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                        user.UserPassword = dataSet.Tables[0].Rows[i].ItemArray[2].ToString();
                        user.GroupId = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[3].ToString());
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@userId", user.UserId);
                        cmd.Parameters.AddWithValue("@login", user.UserLogin);
                        cmd.Parameters.AddWithValue("@password", user.UserPassword);
                        cmd.Parameters.AddWithValue("@groupId", user.GroupId);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
            }
        }
    }
}