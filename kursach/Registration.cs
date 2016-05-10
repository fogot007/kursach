using kursach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var md5Hash = MD5.Create();
            var password = MyMd5.GetMd5Hash(md5Hash, textBox2.Text);
            var confirmPass = MyMd5.GetMd5Hash(md5Hash ,textBox3.Text);
            StringBuilder dbLogin = new StringBuilder();
            using (
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                connection.Open();
                using (
                    MySqlCommand cmd =
                        new MySqlCommand(
                            "SELECT user_login FROM users WHERE user_login = @login;",
                            connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dbLogin.Append(reader.GetString(0));
                        }
                    }
                }

                if (dbLogin.Length >= login.Length)
                {
                    label1.Text = @"user with the same login is already exist";
                }
                else
                {
                    if (password == confirmPass)
                    {
                        using (
                            MySqlCommand cmd =
                                new MySqlCommand(
                                    "INSERT INTO users(user_login,user_password,group_id) VALUES(@login,@password,@groupId)",
                                    connection))
                        {
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@login", login);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@groupId", 2);
                            cmd.ExecuteNonQuery();
                            label1.Text = @"succes";
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}