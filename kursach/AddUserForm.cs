using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class AddUserForm : Form
    {
        private readonly DataGridView _dataGridView;
        private readonly MySqlForUsersTable _mySqlForUsersTable;

        public AddUserForm(DataGridView dataGridView)
        {
            _mySqlForUsersTable = new MySqlForUsersTable();
            _dataGridView = dataGridView;
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            _mySqlForUsersTable.AddUser(new User(textBoxLogin.Text, textBoxPassword.Text), checkBoxToAdmin.Checked);
            Hide();
            _mySqlForUsersTable.FillDataUsers(_dataGridView);
        }

        private void ButtonBackToShops_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}