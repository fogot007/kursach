using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kursach
{
    public partial class UserForm : Form
    {
        private User _user;
        private readonly DataSet _dataSetFavorites;
        private readonly Xml _xml;
        private readonly MySqlForShopsTable _mySqlForShopsTable;
        private Shop _shop;

        public UserForm(User user)
        {
            _user = user;
            _mySqlForShopsTable = new MySqlForShopsTable();
            _xml = new Xml();
            InitializeComponent();
            _dataSetFavorites = new DataSet();
            dataGridViewFavorites.DataSource = _dataSetFavorites;
            _mySqlForShopsTable.FillData(dataGridViewShops);
            _xml.FillDataFavorites(_dataSetFavorites, dataGridViewFavorites);
            UserFormConfig();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewShops.CurrentRow == null) return;
            if (SearchMatches(dataGridViewShops.CurrentRow.Cells[0].Value.ToString())) return;
            var row = _dataSetFavorites.Tables[0].NewRow();
            for (int i = 0; i < dataGridViewShops.ColumnCount; i++)
            {
                row[i] = dataGridViewShops.CurrentRow.Cells[i].Value;
            }
            _dataSetFavorites.Tables[0].Rows.Add(row);
            _xml.SaveFavorites(_dataSetFavorites);
        }

        private void UpdateInfoBarShops()
        {
            shopTitle.Text = _shop.Name = dataGridViewShops.CurrentRow?.Cells[1].Value.ToString();
            _shop.Id = Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[0].Value.ToString());
            shopId.Text = _shop.Id.ToString();
            shopType.Text = _shop.Type = dataGridViewShops.CurrentRow?.Cells[2].Value.ToString();
            shopCity.Text = _shop.City = dataGridViewShops.CurrentRow?.Cells[3].Value.ToString();
            shopAdress.Text = _shop.Adress = dataGridViewShops.CurrentRow?.Cells[4].Value.ToString();
            _shop.Rating = Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[5].Value.ToString());
            shopRating.Text = _shop.Rating.ToString();
        }

        private void UpdateInfoBarFavorites()
        {
            try
            {
                shopTitle.Text = _shop.Name = dataGridViewFavorites.CurrentRow?.Cells[1].Value.ToString();
                _shop.Id = Convert.ToInt32(dataGridViewFavorites.CurrentRow?.Cells[0].Value.ToString());
                shopId.Text = _shop.Id.ToString();
                shopType.Text = _shop.Type = dataGridViewFavorites.CurrentRow?.Cells[2].Value.ToString();
                shopCity.Text = _shop.City = dataGridViewFavorites.CurrentRow?.Cells[3].Value.ToString();
                shopAdress.Text = _shop.Adress = dataGridViewFavorites.CurrentRow?.Cells[4].Value.ToString();
                _shop.Rating = Convert.ToInt32(dataGridViewFavorites.CurrentRow?.Cells[5].Value.ToString());
                shopRating.Text = _shop.Rating.ToString();
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        private void dataGridViewShops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateInfoBarShops();
        }

        private void buttonSaveFavorites_Click(object sender, EventArgs e)
        {
            _xml.SaveFavorites(_dataSetFavorites);
        }

        private static void ClearDataSet(DataSet dataSet)
        {
            dataSet.Clear();
        }

        private void buttonDeleteFromFavorites_Click(object sender, EventArgs e)
        {
            if (dataGridViewFavorites.CurrentRow == null) return;
            var row = dataGridViewFavorites.CurrentRow.Index;
            if (dataGridViewFavorites.RowCount == 1)
            {
                for (int i = 0; i < dataGridViewFavorites.ColumnCount; i++)
                {
                    dataGridViewFavorites.Rows[row].Cells[i].Value = "";
                }
            }
            else
            {
                _dataSetFavorites.Tables[0].Rows.RemoveAt(row);
            }
            _xml.SaveFavorites(_dataSetFavorites);
            ClearDataSet(_dataSetFavorites);
            _xml.FillDataFavorites(_dataSetFavorites, dataGridViewFavorites);
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private bool SearchMatches(string str)
        {
            for (int i = 0; i < dataGridViewFavorites.RowCount; i++)
                if (str.Equals(dataGridViewFavorites.Rows[i].Cells[0].Value.ToString()))
                    return true;
            return false;
        }

        private void dataGridViewFavorites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateInfoBarFavorites();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabStatus())
            {
                button1.Enabled = false;
                buttonSaveFavorites.Enabled = true;
                buttonDeleteFromFavorites.Enabled = true;
            }
            else
            {
                buttonSaveFavorites.Enabled = false;
                buttonDeleteFromFavorites.Enabled = false;
                button1.Enabled = true;
            }
        }

        private bool TabStatus()
        {
            return tabControl.SelectedIndex != 0; // false = Shops  true = Users 
        }

        private void UserFormConfig()
        {
            buttonSaveFavorites.Enabled = false;
            buttonDeleteFromFavorites.Enabled = false;
            dataGridViewShops.Columns[0].Visible = false;
            dataGridViewShops.Columns[2].Visible = false;
            dataGridViewShops.Columns[3].Visible = false;
            dataGridViewShops.Columns[4].Visible = false;
            dataGridViewFavorites.Columns[0].Visible = false;
            dataGridViewFavorites.Columns[2].Visible = false;
            dataGridViewFavorites.Columns[3].Visible = false;
            dataGridViewFavorites.Columns[4].Visible = false;
            _shop = new Shop(Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[0].Value.ToString()),
                dataGridViewShops.CurrentRow?.Cells[1].Value.ToString(),
                dataGridViewShops.CurrentRow?.Cells[2].Value.ToString(),
                dataGridViewShops.CurrentRow?.Cells[3].Value.ToString(),
                dataGridViewShops.CurrentRow?.Cells[4].Value.ToString(),
                Convert.ToInt32(dataGridViewShops.CurrentRow?.Cells[5].Value.ToString()));
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDataSet(_dataSetFavorites);
            _xml.FillDataFavorites(_dataSetFavorites, dataGridViewFavorites);
            _mySqlForShopsTable.FillData(dataGridViewShops);
        }

        private void buttonViewComments_Click(object sender, EventArgs e)
        {
            var commentsForm = new CommentsForm(_shop);
            commentsForm.Show();
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            var addComment = new AddCommentForm(_shop, _user);
            addComment.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var value = textBoxSearch.Text;
            SearchContent(TabStatus() ? dataGridViewFavorites : dataGridViewShops, value);
        }

        private void SearchContent(DataGridView dataGridView, string value)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    if (dataGridView[j, i].Value.ToString().Contains(value))
                        dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.BurlyWood;
        }

//        private void dataGridViewFavorites_SelectionChanged(object sender, EventArgs e)
//        {
//            UpdateInfoBarFavorites();
//        }
//
//        private void dataGridViewShops_SelectionChanged(object sender, EventArgs e)
//        {
//            UpdateInfoBarShops();
//        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new Login();
            _user = new User();
            loginForm.Show();
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (Text == @"Search...")
                Text = "";
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (Text == "")
            {
                Text = @"Search...";
            }
        }
    }
}