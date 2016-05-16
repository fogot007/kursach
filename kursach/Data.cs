using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    internal static class Data
    {
        public static DataGridView DataGridViewFav { get; set; }

        public static DataGridView DataGridViewShops { get; set; }

        public static DataGridView DataGridViewUsers { get; set; }

        public static string Login { get; set; }


        public static int UserId { get; set; }

        public static string ShopName { get; set; }

        public static int ShopId { get; set; }

        public static void UpdateUsers()
        {
            using (var c = new MySqlConnection(
                "server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                c.Open();
                using (var a = new MySqlDataAdapter(
                    "SELECT user_id, user_login, group_id FROM users", c))
                {
                    var t = new DataTable();
                    a.Fill(t);
                    DataGridViewUsers.DataSource = t;
                }
                c.Close();
            }
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = @"Delete",
                Text = "-",
                Name = "btnDelete",
                UseColumnTextForButtonValue = true
            };
            DataGridViewUsers.Columns.Add(deleteButtonColumn);
        }

        public static void UpdateFavourites()
        {
            using (var c = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                c.Open();
                using (
                    var a =
                        new MySqlDataAdapter(
                            "SELECT shop_id,shop_name FROM favourites WHERE user_id = " + UserId + ";", c)
                    )
                {
                    var data = new DataTable();
                    a.Fill(data);
                    DataGridViewFav.DataSource = data;
                }
            }

            if (DataGridViewFav.ColumnCount < 3)
            {
                var buttonColumnMore = new DataGridViewButtonColumn
                {
                    HeaderText = @"More",
                    Text = "...",
                    Name = "btnMore",
                    UseColumnTextForButtonValue = true
                };
                var buttonColumnDelete = new DataGridViewButtonColumn
                {
                    HeaderText = @"Delete",
                    Text = "Delete",
                    Name = "btnDelete",
                    UseColumnTextForButtonValue = true
                };

                DataGridViewFav.Columns.Add(buttonColumnMore);
                DataGridViewFav.Columns.Add(buttonColumnDelete);
                DataGridViewFav.Columns[0].Visible = false;
            }
        }

        public static void FillDataUsr()
        {
            using (var c = new MySqlConnection(
                "server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                c.Open();
                using (var a = new MySqlDataAdapter(
                    "SELECT * FROM shops", c))
                {
                    var t = new DataTable();
                    a.Fill(t);
                    DataGridViewShops.DataSource = t;
                }
                c.Close();
            }
            var buttonColumn1 = new DataGridViewButtonColumn
            {
                HeaderText = @"More",
                Text = "...",
                Name = "btnMore",
                UseColumnTextForButtonValue = true
            };
            var buttonColumn2 = new DataGridViewButtonColumn
            {
                HeaderText = @"To Favourites",
                Text = "+",
                Name = "btnFav",
                UseColumnTextForButtonValue = true
            };
            DataGridViewShops.Columns[1].HeaderText = @"Title";
            DataGridViewShops.Columns[2].HeaderText = @"Type";
            DataGridViewShops.Columns[5].HeaderText = @"Rating";
            DataGridViewShops.Columns.Add(buttonColumn1);
            DataGridViewShops.Columns.Add(buttonColumn2);
            DataGridViewShops.Columns[0].Visible = false;
            DataGridViewShops.Columns[3].Visible = false;
            DataGridViewShops.Columns[4].Visible = false;
        }

        public static void FillDataAdmin()
        {
            using (var c = new MySqlConnection(
                "server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                c.Open();
                using (var a = new MySqlDataAdapter(
                    "SELECT * FROM shops", c))
                {
                    var t = new DataTable();
                    a.Fill(t);
                    DataGridViewShops.DataSource = t;
                }
                c.Close();
            }
            var buttonColumnChange = new DataGridViewButtonColumn
            {
                HeaderText = @"Change",
                Text = "*",
                Name = "btnChange",
                UseColumnTextForButtonValue = true
            };
            DataGridViewShops.Columns.Add(buttonColumnChange);
        }
    }
}