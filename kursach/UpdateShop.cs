using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class UpdateShop : Form
    {
        private Shop _shop;
        private readonly DataGridView _data;
        private readonly MySqlForShopsTable _mySqlForShopsTable;

        public UpdateShop(Shop shop, DataGridView dataGridView)
        {
            _mySqlForShopsTable = new MySqlForShopsTable();
            _data = dataGridView;
            _shop = shop;
            InitializeComponent();
            labelShop.Text = shop.Name;
            textBoxShopTitle.Text = shop.Name;
            textBoxShopType.Text = shop.Type;
            textBoxShopCity.Text = shop.City;
            textBoxShopAdress.Text = shop.Adress;
            textBoxShopRating.Text = shop.Rating.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var shopId = _shop.Id;
            _shop = new Shop(shopId,textBoxShopTitle.Text,textBoxShopType.Text,textBoxShopCity.Text,textBoxShopAdress.Text,Convert.ToInt32(textBoxShopRating.Text));
            _mySqlForShopsTable.UpdateShop(_shop);
            Hide();
            _mySqlForShopsTable.FillData(_data);
        }
    }
}