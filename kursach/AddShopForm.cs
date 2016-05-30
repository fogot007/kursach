using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class AddShopForm : Form
    {
        private Shop _shop;
        private readonly MySqlForShopsTable _mySqlForShopsTable;
        private readonly DataGridView _data;

        public AddShopForm(DataGridView dataGridView)
        {
            _mySqlForShopsTable = new MySqlForShopsTable();
            _data = dataGridView;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _shop = new Shop(shopTitle.Text,shopType.Text,shopCity.Text,shopAdress.Text,Convert.ToInt32(shopRating.Text));
            _mySqlForShopsTable.AddShop(_shop);
            Hide();
            _mySqlForShopsTable.FillData(_data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}