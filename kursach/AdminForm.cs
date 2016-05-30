using System;
using System.Data;
using System.Windows.Forms;

namespace kursach
{
    public partial class AdminForm : Form
    {
        private readonly MySqlForUsersTable _mySqlForUsersTable;
        private readonly MySqlForShopsTable _mySqlForShopsTable;
        private readonly Xml _xml;
        private Shop _shop;
        private User _user;
        private User _currentUser;

        public AdminForm(User user)
        {
            _xml = new Xml();
            InitializeComponent();
            _user = user;
            _mySqlForUsersTable = new MySqlForUsersTable();
            _mySqlForShopsTable = new MySqlForShopsTable();
            _mySqlForShopsTable.FillData(dataGridViewShops);
            _mySqlForUsersTable.FillDataUsers(dataGridViewUsers);
            AdminElementsConfig();
            UpdateInfoBarShops();
            UpdateInfoBarUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TabStatus())
            {
                var addUser = new AddUserForm(dataGridViewUsers);
                addUser.Show();
            }
            else
            {
                var addShop = new AddShopForm(dataGridViewShops);
                addShop.Show();
            }
        }

        private void dataGridViewShops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateInfoBarShops();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateInfoBarUsers();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabStatus())
            {
                groupBoxShops.Visible = false;
                groupBoxUsers.Visible = true;
            }
            else
            {
                groupBoxShops.Visible = true;
                groupBoxUsers.Visible = false;
            }
        }

        private bool TabStatus()
        {
            return tabControl.SelectedIndex != 0; // false = Shops  true = Users 
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mySqlForUsersTable.FillDataUsers(dataGridViewUsers);
            _mySqlForShopsTable.FillData(dataGridViewShops);
        }

        private void AdminElementsConfig()
        {
            dataGridViewShops.Columns[0].Visible = false;
            dataGridViewShops.Columns[2].Visible = false;
            dataGridViewShops.Columns[3].Visible = false;
            dataGridViewShops.Columns[4].Visible = false;
            dataGridViewShops.Columns[2].Visible = false;
            dataGridViewUsers.Columns[0].Visible = false;
            groupBoxUsers.Visible = false;
            _shop = new Shop(Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[0].Value.ToString()),
                dataGridViewShops.CurrentRow?.Cells[1].Value.ToString(),
                dataGridViewShops.CurrentRow?.Cells[2].Value.ToString(),
                dataGridViewShops.CurrentRow?.Cells[3].Value.ToString(),
                dataGridViewShops.CurrentRow?.Cells[4].Value.ToString(),
                Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[5].Value.ToString()));
            _currentUser = new User(Convert.ToInt32(dataGridViewUsers.CurrentRow?.Cells[0].Value.ToString()),
                dataGridViewUsers.CurrentRow?.Cells[0].Value.ToString(),
                Convert.ToInt32(dataGridViewUsers.CurrentRow?.Cells[2].Value.ToString()));
        }

        private void AdminForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (TabStatus())
            {
                var updateUser = new UpdateUser(_currentUser, dataGridViewUsers);
                updateUser.Show();
            }
            else
            {
                var updateShop = new UpdateShop(_shop, dataGridViewShops);
                updateShop.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (TabStatus())
            {
                _mySqlForUsersTable.DeleteUser(_currentUser.UserId);
                _mySqlForUsersTable.FillDataUsers(dataGridViewUsers);
                UpdateInfoBarUsers();
            }
            else
            {
                _mySqlForShopsTable.DeleteShop(_shop.Id);
                _mySqlForShopsTable.FillData(dataGridViewShops);
                UpdateInfoBarShops();
            }
        }

        private void UpdateInfoBarShops()
        {
            shopTitle.Text = _shop.Name = dataGridViewShops.CurrentRow?.Cells[1].Value.ToString();
            _shop.Id = Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[0].Value.ToString());
            shopId.Text = _shop.Id.ToString();
            shopType.Text = _shop.Type = dataGridViewShops.CurrentRow?.Cells[2].Value.ToString();
            shopCity.Text = _shop.City = dataGridViewShops.CurrentRow?.Cells[3].Value.ToString();
            shopAdress.Text = _shop.Adress = dataGridViewShops.CurrentRow?.Cells[4].Value.ToString();
            _shop.Rating = Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[5].Value.ToString());
            shopRating.Text = _shop.Rating.ToString();
        }

        private void UpdateInfoBarUsers()
        {
            _currentUser.UserId = Convert.ToInt32(dataGridViewUsers.CurrentRow?.Cells[0].Value.ToString());
            UserId.Text = _currentUser.UserId.ToString();
            labelUserLogin.Text = _currentUser.UserLogin = dataGridViewUsers.CurrentRow?.Cells[1].Value.ToString();
            _currentUser.GroupId = Convert.ToInt32(dataGridViewUsers.CurrentRow?.Cells[2].Value.ToString());
            Permissions.Text = _currentUser.GroupId.ToString();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable;
            if (TabStatus())
            {
                dataTable = _mySqlForUsersTable.GetDataBase();
                _xml.SaveDataBaseUsers(dataTable);
            }
            else
            {
                dataTable = _mySqlForShopsTable.GetDataBase();
                _xml.SaveDataBaseShops(dataTable);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DataSet dataSet;
            if (TabStatus())
            {
                dataSet = _xml.FillUsersFromExport();
                _mySqlForUsersTable.ExportData(dataSet);
                _mySqlForUsersTable.FillDataUsers(dataGridViewUsers);
            }
            else
            {
                dataSet = _xml.FillShopsFromExport();
                _mySqlForShopsTable.ExportData(dataSet);
                _mySqlForShopsTable.FillData(dataGridViewShops);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _user = new User();
            Hide();
            var loginForm = new Login();
            loginForm.Show();
        }

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var userForm = new UserForm(_user);
            userForm.Show();
        }
    }
}