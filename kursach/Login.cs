using System;
using System.Security.Cryptography;
using System.Windows.Forms;

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
            if (!(textBoxLogin.Text.Length > 3 && textBoxPassword.Text.Length > 3))
            {
                MessageBox.Show(@"Incorrect input");
                return;
            }
            MySqlForUsersTable mySqlForUsersTable = new MySqlForUsersTable();
            try
            {
                User user = mySqlForUsersTable.GetLogin(textBoxLogin.Text);
                using (var md5Hash = MD5.Create())
                {
                    if (!MyMd5.VerifyMd5Hash(md5Hash, textBoxPassword.Text, user.UserPassword)) return;
                    switch (user.GroupId)
                    {
                        case 1:
                            {
                                var adminForm = new AdminForm(user);
                                adminForm.Show();
                                break;
                            }
                        case 2:
                            {
                                var userForm = new UserForm(user);
                                userForm.Show();
                                break;
                            }
                    }
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"login or password incorrect");
            }
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var register = new Registration();
            register.Show();
            Hide();
        }
    }
}