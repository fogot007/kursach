using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class UpdateUser : Form
    {
        private readonly DataGridView _data;
        private readonly MySqlForUsersTable _mySqlForUsersTable;
        private readonly User _user;

        public UpdateUser(User user, DataGridView dataGridView)
        {
            _user = user;
            _mySqlForUsersTable = new MySqlForUsersTable();
            _data = dataGridView;
            InitializeComponent();
            textBoxLogin.Text = _user.UserLogin;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            _user.UserLogin = textBoxLogin.Text;
            _mySqlForUsersTable.UpdateUser(_user, checkBoxToAdmin.Checked);
            Hide();
            _mySqlForUsersTable.FillDataUsers(_data);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}