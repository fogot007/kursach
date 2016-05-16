using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class More : Form
    {
        public More(string shopName, string shopType, string shopCity, string shopAdress, string shopRating)
        {
            InitializeComponent();
            shopTitle.Text = shopName;
            this.shopType.Text = shopType;
            this.shopCity.Text = shopCity;
            this.shopAdress.Text = shopAdress;
            this.shopRating.Text = shopRating;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            Hide();
        }
    }
}