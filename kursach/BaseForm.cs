using System;
using System.Windows.Forms;

namespace kursach
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            searchString.Text = @"Search...";
            favouritesLabel.Text = @"Please log in Menu->Close";
        }

        protected void searchString_Enter(object sender, EventArgs e)
        {
            if (searchString.Text == @"Search...")
                searchString.Text = "";
        }

        protected void searchString_Leave(object sender, EventArgs e)
        {
            if (searchString.Text == "")
                searchString.Text = @"Search...";
        }

        protected void NonUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        protected void Selected(DataGridView data, string value)
        {
            for (var i = 0; i < data.ColumnCount; i++)
                for (var j = 0; j < data.RowCount; j++)
                    if (data[i, j].Value.ToString().Contains(value) && data[i, j].Value != null)
                        data.Rows[j].Selected = true;
        }

        protected static bool Containts(DataGridView data, int value)
        {
            for (var i = 0; i < data.RowCount; i++)
                if (data.Rows[i].Cells[2].Value != null)
                    if (int.Parse(data.Rows[i].Cells[2].Value.ToString()) == value)
                        return true;
            return false;
        }
    }
}