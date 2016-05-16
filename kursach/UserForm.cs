using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public partial class UserForm : BaseForm
    {
        public UserForm()
        {
            InitializeComponent();
            Data.FillDataUsr();
            Data.UpdateFavourites();
        }


        private void dataGridViewShops_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Data.ShopName = dataGridViewShops[3, e.RowIndex].Value.ToString();
            Data.ShopId = int.Parse(dataGridViewShops[2, e.RowIndex].Value.ToString());
            switch (e.ColumnIndex)
            {
                case 0:
                    var more = new More(dataGridViewShops[3, e.RowIndex].Value.ToString(),
                        dataGridViewShops[4, e.RowIndex].Value.ToString(),
                        dataGridViewShops[5, e.RowIndex].Value.ToString(),
                        dataGridViewShops[6, e.RowIndex].Value.ToString(),
                        dataGridViewShops[7, e.RowIndex].Value.ToString());
                    more.Show();
                    break;
                case 1:
                    if (Containts(dataGridViewLeftPanel, Data.ShopId)) return;
                    using (var c = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;")
                        )
                    {
                        c.Open();
                        using (
                            var cmd =
                                new MySqlCommand(
                                    "INSERT INTO favourites(id,user_id,shop_id,shop_name) VALUES(NULL,@UserId,@ShopId,@ShopName)",
                                    c))
                        {
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@UserId", Data.UserId);
                            cmd.Parameters.AddWithValue("@ShopName", Data.ShopName);
                            cmd.Parameters.AddWithValue("@ShopId", Data.ShopId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Data.UpdateFavourites();
                    break;
            }
        }

        private void closeLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Login();
            Hide();
            login.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var value = searchString.Text;
            var data = radioButtonFav.Checked ? dataGridViewLeftPanel : dataGridViewShops;
            for (var i = 0; i < data.ColumnCount; i++)
                for (var j = 0; j < data.RowCount; j++)
                    if (data[i, j].Value.ToString().Contains(value))
                    {
                        data.Rows[j].Selected = true;
                    }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridViewShops.ColumnCount; i++)
                for (var j = 0; j < dataGridViewShops.RowCount; j++)
                    dataGridViewShops.Rows[j].Selected = false;
            for (var i = 0; i < dataGridViewLeftPanel.ColumnCount; i++)
                for (var j = 0; j < dataGridViewLeftPanel.RowCount; j++)
                    dataGridViewLeftPanel.Rows[j].Selected = false;
        }

        private void dataGridViewLeftPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Data.ShopName = dataGridViewLeftPanel[3, e.RowIndex].Value.ToString();
            Data.ShopId = int.Parse(dataGridViewLeftPanel[2, e.RowIndex].Value.ToString());
            if (e.ColumnIndex == 1)
            {
                using (var c = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;")
                    )
                {
                    c.Open();
                    using (
                        var cmd =
                            new MySqlCommand(
                                "DELETE FROM favourites WHERE shop_id = @ShopId LIMIT 1",
                                c))
                    {
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@ShopId", Data.ShopId);
                        cmd.ExecuteNonQuery();
                    }
                }
                dataGridViewLeftPanel.Rows.RemoveAt(e.RowIndex);
            }
            else if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var indx = FindIndexOfRow(dataGridViewLeftPanel[2, e.RowIndex].Value);
                if (indx == -1) return;
                var more = new More(dataGridViewShops[3, indx].Value.ToString(),
                    dataGridViewShops[4, indx].Value.ToString(), dataGridViewShops[5, indx].Value.ToString(),
                    dataGridViewShops[6, indx].Value.ToString(), dataGridViewShops[7, indx].Value.ToString());
                more.Show();
            }
        }

        private int FindIndexOfRow(object value)
        {
            for (var i = 0; i < dataGridViewShops.RowCount; i++)
                if (dataGridViewShops.Rows[i].Cells[2].Value != null)
                    if (dataGridViewShops.Rows[i].Cells[2].Value.Equals(value))
                        return i;
            return -1;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.UpdateFavourites();
        }

        private void searchString_Enter_1(object sender, EventArgs e)
        {
        }
    }
}