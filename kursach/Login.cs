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

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;
            StringBuilder dbLogin = new StringBuilder();
            StringBuilder dbPassword = new StringBuilder();
            StringBuilder dbGroup = new StringBuilder();
            using (
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                connection.Open();
                using (
                    MySqlCommand cmd =
                        new MySqlCommand(
                            "SELECT user_login, user_password, group_id FROM users WHERE user_login = @login Limit 1;",
                            connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dbLogin.Append(reader.GetString(0));
                            dbPassword.Append(reader.GetString(1));
                            dbGroup.Append(reader.GetString(2));
                        }
                    }
                }
                connection.Close();
                using (MD5 md5Hash = MD5.Create())
                {
                    if (MyMd5.VerifyMd5Hash(md5Hash, password, dbPassword.ToString()))
                    {
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var register = new Registration();
            register.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nonUserForm = new NonUserForm();
            nonUserForm.Show();
            Hide();
        }
    }
}