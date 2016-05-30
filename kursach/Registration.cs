using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace kursach
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            MySqlForUsersTable = new MySqlForUsersTable();
        }

        private MySqlForUsersTable MySqlForUsersTable { get; }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonBackToLogin_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            Hide();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var md5Hash = MD5.Create();
            var password = MyMd5.GetMd5Hash(md5Hash, textBox2.Text);
            var confirmPass = MyMd5.GetMd5Hash(md5Hash, textBox3.Text);
            var dbLogin = MySqlForUsersTable.SelectLogin(login);
            if (dbLogin.Length >= login.Length)
                label1.Text = @"user with the same login is already exist";
            else
            {
                if (password.Equals(confirmPass))
                    MySqlForUsersTable.PushUser(login, password, 2);
            }
        }
    }
}