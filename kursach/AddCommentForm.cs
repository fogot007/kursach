using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class AddCommentForm : Form
    {
        private readonly Shop _shop;
        private readonly User _user;
        private readonly MySqlForCommentsTable _mySqlForCommentsTable;
        public AddCommentForm(Shop shop, User user)
        {
            _mySqlForCommentsTable = new MySqlForCommentsTable();
            _shop = shop;
            _user = user;
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            _mySqlForCommentsTable.AddComment(new Comment(_user.UserId,_user.UserLogin,_shop.Id,textBoxComment.Text));
            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
