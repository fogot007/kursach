using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.DataGridViewSelectionMode;

namespace kursach
{
    public partial class UserForm : Form
    {
        private readonly DataSet _ds;
        private MySqlDataAdapter _adapter;
        private MySqlCommandBuilder _commandBuilder;
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
        private string sql = "SELECT * FROM users";
        public UserForm()
        {
            InitializeComponent();
            FillData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = _ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            _ds.Tables[0].Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // удаляем выделенные строки из dataGridView1
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                _adapter = new MySqlDataAdapter(sql, connection);
                _commandBuilder = new MySqlCommandBuilder(_adapter);
                _adapter.InsertCommand = new MySqlCommand("Update", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                _adapter.InsertCommand.Parameters.Add(new MySqlParameter("@name", MySqlDbType.VarChar, 50, "Name"));
                _adapter.InsertCommand.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32, 0, "Age"));

                MySqlParameter parameter = _adapter.InsertCommand.Parameters.Add("@Id", MySqlDbType.Int32, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                _adapter.Update(_ds);
            }
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
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Get all rows entered on each press of Enter.
            var collection = this.dataGridView1.Rows;
            string output = "";
            foreach (DataGridViewRow row in collection)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        output += cell.Value.ToString() + " ";
                    }
                }
            }
            // Display.
            this.Text = output;
        }
    }
}
