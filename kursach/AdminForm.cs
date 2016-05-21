using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class AdminForm : BaseForm
    {
        public AdminForm()
        {
            InitializeComponent();
            Data.DataGridViewShops = dataGridViewShops;
            Data.DataGridViewUsers = dataGridViewUsers;
            Data.FillDataAdmin();
            Data.UpdateUsers();
        }


        private void dataGridViewShops_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Data.ShopName = dataGridViewShops[2, e.RowIndex].Value.ToString();
            Data.ShopId = int.Parse(dataGridViewShops[1, e.RowIndex].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                var shop = new UpdateShop(dataGridViewShops[2, e.RowIndex].Value.ToString(),
                    dataGridViewShops[3, e.RowIndex].Value.ToString(), dataGridViewShops[4, e.RowIndex].Value.ToString(),
                    dataGridViewShops[5, e.RowIndex].Value.ToString(), dataGridViewShops[6, e.RowIndex].Value.ToString());
                shop.Show();
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var value = searchString.Text;
            if (radioButtonFav.Checked)
                Selected(dataGridViewUsers, value);
            else if (radioButtonShops.Checked)
                Selected(dataGridViewShops, value);
            else
            {
                Selected(dataGridViewShops, value);
                Selected(dataGridViewUsers, value);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridViewShops.ColumnCount; i++)
                for (var j = 0; j < dataGridViewShops.RowCount; j++)
                    dataGridViewShops.Rows[j].Selected = false;
            for (var i = 0; i < dataGridViewUsers.ColumnCount; i++)
                for (var j = 0; j < dataGridViewUsers.RowCount; j++)
                    dataGridViewUsers.Rows[j].Selected = false;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addUser = new AddUserForm();
            addUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var data = dataGridViewShops.Enabled ? dataGridViewShops : dataGridViewUsers;
            for (var i = 0; i < data.RowCount; i++)
                if (data.Rows[i].Selected)
                {
                    Data.DeleteRow(int.Parse(data[i, 0].Value.ToString()), i);
                    break;
                }
        }
    }
}