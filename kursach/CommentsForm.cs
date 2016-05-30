using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kursach
{
    public partial class CommentsForm : Form
    {
        private readonly MySqlForCommentsTable _mySqlForCommentsTable;
        private readonly Shop _shop;

        public CommentsForm(Shop shop)
        {
            _shop = shop;
            _mySqlForCommentsTable = new MySqlForCommentsTable();
            InitializeComponent();
            CommentFormInitialize();
            
        }

        private void CommentFormInitialize()
        {
            DataTable dataTable = _mySqlForCommentsTable.GetComments(_shop.Id);
            if (dataTable.Rows.Count < 1)
            {
                label1.Visible = false;
                labelShop.Text = @"This shop has no comments";
            }
            else
            {
                var labelLocation = new Point(6,30);
                var groupBoxLocation = new Point(12,40);
                Size groupBoxSize = new Size(280,60);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    var groupBox = new GroupBox
                    {
                        Text = @"User " +  dataTable.Rows[i][2] + @":",
                        Size = groupBoxSize,
                        Location = new Point(groupBoxLocation.X, groupBoxLocation.Y),
                    };
                    Controls.Add(groupBox);
                    var label = new Label
                    {
                        Location = labelLocation,
                        Text = dataTable.Rows[i][4].ToString(),
                        AutoSize = true
                    };
                    groupBox.Controls.Add(label);
                    groupBoxLocation = new Point(groupBoxLocation.X, groupBoxLocation.Y + 60);
                }
            }
        }
    }
}