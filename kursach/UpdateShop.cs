using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursach
{
    public partial class UpdateShop : Form
    {
        public UpdateShop(string shopName, string shopType, string shopCity, string shopAdress, string shopRating)
        {
            InitializeComponent();
            labelShop.Text = shopName;
            textBoxShopTitle.Text = shopName;
            textBoxShopType.Text = shopType;
            textBoxShopCity.Text = shopCity;
            textBoxShopAdress.Text = shopAdress;
            textBoxShopRating.Text = shopRating;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (
                var connection = new MySqlConnection("server=localhost;uid=root;pwd=1111;database=Shops;"))
            {
                connection.Open();
                using (
                    var cmd =
                        new MySqlCommand(
                            "UPDATE shops SET shop_name = @ShopName, shop_type = @ShopType, shop_city = @ShopCity, shop_adress = @ShopAdress, shop_rating = @ShopRating WHERE shop_id = @ShopId  LIMIT 1",
                            connection))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ShopName", textBoxShopTitle.Text);
                    cmd.Parameters.AddWithValue("@ShopType", textBoxShopType.Text);
                    cmd.Parameters.AddWithValue("@ShopCity", textBoxShopCity.Text);
                    cmd.Parameters.AddWithValue("@ShopAdress", textBoxShopAdress.Text);
                    cmd.Parameters.AddWithValue("@ShopRating", int.Parse(textBoxShopRating.Text));
                    cmd.Parameters.AddWithValue("@ShopId", Data.ShopId);
                    cmd.ExecuteNonQuery();
                }
            }
            Hide();
            Data.FillDataAdmin();
        }
    }
}