using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            // 1
            // Open connection
            using (MySqlConnection c = new MySqlConnection(
                "server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                c.Open();
                // 2
                // Create new DataAdapter
                using (MySqlDataAdapter a = new MySqlDataAdapter(
                    "SELECT * FROM shops", c))
                {
                    // 3
                    // Use DataAdapter to fill DataTable
                    DataTable t = new DataTable();
                    a.Fill(t);
                    // 4
                    // Render data onto the screen
                    dataGridView1.DataSource = t;
                }
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addUser = new AddUserForm();
            addUser.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
            }
        }
    }
}