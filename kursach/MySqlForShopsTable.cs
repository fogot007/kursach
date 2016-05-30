using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public class MySqlForShopsTable : MySql
    {
        public void DeleteShop(int shopId)
        {
            using (Connection)
            {
                Connection.Open();
                using (Command = new MySqlCommand("DELETE FROM shops WHERE shop_id = @Id LIMIT 1",
                    Connection))
                {
                    Command.Prepare();
                    Command.Parameters.AddWithValue("@Id", shopId);
                    Command.ExecuteNonQuery();
                }
            }
        }

        public void FillData(DataGridView data)
        {
            using (Connection)
            {
                Connection.Open();
                using (Adapter = new MySqlDataAdapter(
                    "SELECT * FROM shops", Connection))
                {
                    DataTable t = new DataTable();
                    Adapter.Fill(t);
                    data.DataSource = t;
                }
            }
        }

        public void AddShop(Shop shop)
        {
            var dbTitle = new StringBuilder();
            using (Connection)
            {
                Connection.Open();
                using (
                    Command =
                        new MySqlCommand(
                            "SELECT shop_name FROM shops WHERE shop_name = @title;",
                            Connection))
                {
                    Command.Parameters.AddWithValue("@title", Connection);
                    using (var reader = Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dbTitle.Append(reader.GetString(0));
                        }
                    }
                }

                if (dbTitle.Length > shop.Name.Length)
                {
                    return;
                }
                using (
                    Command =
                        new MySqlCommand(
                            "INSERT INTO shops VALUES(NULL,@name,@type,@city,@address,@rating)",
                            Connection))
                {
                    Command.Prepare();
                    Command.Parameters.AddWithValue("@name", shop.Name);
                    Command.Parameters.AddWithValue("@type", shop.Type);
                    Command.Parameters.AddWithValue("@city", shop.City);
                    Command.Parameters.AddWithValue("@address", shop.Adress);
                    Command.Parameters.AddWithValue("@rating", shop.Rating);
                    Command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateShop(Shop shop)
        {
            using (
                Connection)
            {
                Connection.Open();
                using (
                    Command =
                        new MySqlCommand(
                            "UPDATE shops SET shop_name = @ShopName, shop_type = @ShopType, shop_city = @ShopCity, shop_adress = @ShopAddress, shop_rating = @ShopRating WHERE shop_id = @CurrentShop.ShopId  LIMIT 1",
                            Connection))
                {
                    Command.Prepare();
                    Command.Parameters.AddWithValue("@ShopName", shop.Name);
                    Command.Parameters.AddWithValue("@ShopType", shop.Type);
                    Command.Parameters.AddWithValue("@ShopCity", shop.City);
                    Command.Parameters.AddWithValue("@ShopAddress", shop.Adress);
                    Command.Parameters.AddWithValue("@ShopRating", shop.Rating);
                    Command.Parameters.AddWithValue("@CurrentShop.ShopId", shop.Id);
                    Command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataBase()
        {
            var dataTable = new DataTable("Shop");
            using (Connection)
            {
                Connection.Open();
                using (var adapter = new MySqlDataAdapter(
                    "SELECT * FROM shops", Connection))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public void ExportData(DataSet dataSet)
        {
            var shop = new Shop();
            using (Connection)
            {
                Connection.Open();
                using (
                    Command =
                        new MySqlCommand(
                            "INSERT INTO shops(shop_id ,shop_name,shop_type,shop_city,shop_adress,shop_rating) VALUES(@Id,@Name,@Type,@City,@Address,@Rating) ON DUPLICATE KEY UPDATE shop_name=@Name,shop_type=@Type,shop_city=@City,shop_adress=@Address,shop_rating=@Rating",
                            Connection))
                {
                    for (var i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
                    {
                        shop.Id = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[0].ToString());
                        shop.Name = dataSet.Tables[0].Rows[i].ItemArray[1].ToString();
                        shop.Type = dataSet.Tables[0].Rows[i].ItemArray[2].ToString();
                        shop.City = dataSet.Tables[0].Rows[i].ItemArray[3].ToString();
                        shop.Adress = dataSet.Tables[0].Rows[i].ItemArray[4].ToString();
                        shop.Rating = Convert.ToInt32(dataSet.Tables[0].Rows[i].ItemArray[5].ToString());
                        Command.Prepare();
                        Command.Parameters.AddWithValue("@Id", shop.Id);
                        Command.Parameters.AddWithValue("@Name", shop.Name);
                        Command.Parameters.AddWithValue("@Type", shop.Type);
                        Command.Parameters.AddWithValue("@City", shop.City);
                        Command.Parameters.AddWithValue("@Address", shop.Adress);
                        Command.Parameters.AddWithValue("@Rating", shop.Rating);
                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                    }
                }
            }
        }
    }
}