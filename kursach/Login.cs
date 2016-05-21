using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;
            var dbLogin = new StringBuilder();
            var dbPassword = new StringBuilder();
            var dbGroup = new StringBuilder();
            var dbUserId = new StringBuilder();
            using (
                var connection = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                connection.Open();
                using (
                    var cmd =
                        new MySqlCommand(
                            "SELECT user_id ,user_login, user_password, group_id FROM users WHERE user_login = @login Limit 1;",
                            connection))
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
                connection.Close();
                Data.UserId = int.Parse(dbUserId.ToString());
                using (var md5Hash = MD5.Create())
                {
                    if (!MyMd5.VerifyMd5Hash(md5Hash, password, dbPassword.ToString())) return;
                    switch (dbGroup.ToString())
                    {
                        case "1":
                        {
                            var adminForm = new AdminForm();
                            adminForm.Show();
                            break;
                        }
                        case "2":
                        {
                            var userForm = new UserForm();
                            userForm.Show();
                            break;
                        }
                    }
                    Hide();
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var register = new Registration();
            register.Show();
            Hide();
        }

        private void TryButton_Click(object sender, EventArgs e)
        {
            var nonUserForm = new BaseForm();
            nonUserForm.Show();
            Hide();
        }
    }
}