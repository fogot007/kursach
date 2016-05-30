namespace kursach
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageShops = new System.Windows.Forms.TabPage();
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.tabPageFavorites = new System.Windows.Forms.TabPage();
            this.dataGridViewFavorites = new System.Windows.Forms.DataGridView();
            this.groupBoxShops = new System.Windows.Forms.GroupBox();
            this.shopId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shopRating = new System.Windows.Forms.Label();
            this.shopAdress = new System.Windows.Forms.Label();
            this.shopCity = new System.Windows.Forms.Label();
            this.shopType = new System.Windows.Forms.Label();
            this.shopRatingLabel = new System.Windows.Forms.Label();
            this.shopAdressLabel = new System.Windows.Forms.Label();
            this.shopCityLabel = new System.Windows.Forms.Label();
            this.shopTypeLabel = new System.Windows.Forms.Label();
            this.shopTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSaveFavorites = new System.Windows.Forms.Button();
            this.buttonDeleteFromFavorites = new System.Windows.Forms.Button();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.buttonViewComments = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.tabPageFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorites)).BeginInit();
            this.groupBoxShops.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageShops);
            this.tabControl.Controls.Add(this.tabPageFavorites);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(393, 353);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageShops
            // 
            this.tabPageShops.Controls.Add(this.dataGridViewShops);
            this.tabPageShops.Location = new System.Drawing.Point(4, 22);
            this.tabPageShops.Name = "tabPageShops";
            this.tabPageShops.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShops.Size = new System.Drawing.Size(385, 327);
            this.tabPageShops.TabIndex = 0;
            this.tabPageShops.Text = "Shops";
            this.tabPageShops.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.AllowUserToAddRows = false;
            this.dataGridViewShops.AllowUserToDeleteRows = false;
            this.dataGridViewShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShops.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShops.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShops.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewShops.MultiSelect = false;
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.ReadOnly = true;
            this.dataGridViewShops.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewShops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShops.Size = new System.Drawing.Size(379, 321);
            this.dataGridViewShops.TabIndex = 0;
            this.dataGridViewShops.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShops_CellClick);
            // 
            // tabPageFavorites
            // 
            this.tabPageFavorites.Controls.Add(this.dataGridViewFavorites);
            this.tabPageFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabPageFavorites.Name = "tabPageFavorites";
            this.tabPageFavorites.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFavorites.Size = new System.Drawing.Size(385, 327);
            this.tabPageFavorites.TabIndex = 1;
            this.tabPageFavorites.Text = "Favorites";
            this.tabPageFavorites.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFavorites
            // 
            this.dataGridViewFavorites.AllowUserToAddRows = false;
            this.dataGridViewFavorites.AllowUserToDeleteRows = false;
            this.dataGridViewFavorites.AllowUserToOrderColumns = true;
            this.dataGridViewFavorites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFavorites.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFavorites.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFavorites.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFavorites.MultiSelect = false;
            this.dataGridViewFavorites.Name = "dataGridViewFavorites";
            this.dataGridViewFavorites.ReadOnly = true;
            this.dataGridViewFavorites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFavorites.Size = new System.Drawing.Size(379, 321);
            this.dataGridViewFavorites.TabIndex = 1;
            this.dataGridViewFavorites.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFavorites_CellClick);
            // 
            // groupBoxShops
            // 
            this.groupBoxShops.Controls.Add(this.shopId);
            this.groupBoxShops.Controls.Add(this.label2);
            this.groupBoxShops.Controls.Add(this.shopRating);
            this.groupBoxShops.Controls.Add(this.shopAdress);
            this.groupBoxShops.Controls.Add(this.shopCity);
            this.groupBoxShops.Controls.Add(this.shopType);
            this.groupBoxShops.Controls.Add(this.shopRatingLabel);
            this.groupBoxShops.Controls.Add(this.shopAdressLabel);
            this.groupBoxShops.Controls.Add(this.shopCityLabel);
            this.groupBoxShops.Controls.Add(this.shopTypeLabel);
            this.groupBoxShops.Controls.Add(this.shopTitle);
            this.groupBoxShops.Location = new System.Drawing.Point(399, 28);
            this.groupBoxShops.Name = "groupBoxShops";
            this.groupBoxShops.Size = new System.Drawing.Size(153, 150);
            this.groupBoxShops.TabIndex = 20;
            this.groupBoxShops.TabStop = false;
            this.groupBoxShops.Text = "Information:";
            // 
            // shopId
            // 
            this.shopId.AutoSize = true;
            this.shopId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopId.Location = new System.Drawing.Point(73, 120);
            this.shopId.Name = "shopId";
            this.shopId.Size = new System.Drawing.Size(0, 20);
            this.shopId.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id:";
            // 
            // shopRating
            // 
            this.shopRating.AutoSize = true;
            this.shopRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopRating.Location = new System.Drawing.Point(73, 101);
            this.shopRating.Name = "shopRating";
            this.shopRating.Size = new System.Drawing.Size(0, 20);
            this.shopRating.TabIndex = 18;
            // 
            // shopAdress
            // 
            this.shopAdress.AutoSize = true;
            this.shopAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopAdress.Location = new System.Drawing.Point(73, 81);
            this.shopAdress.Name = "shopAdress";
            this.shopAdress.Size = new System.Drawing.Size(0, 20);
            this.shopAdress.TabIndex = 17;
            // 
            // shopCity
            // 
            this.shopCity.AutoSize = true;
            this.shopCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopCity.Location = new System.Drawing.Point(73, 62);
            this.shopCity.Name = "shopCity";
            this.shopCity.Size = new System.Drawing.Size(0, 20);
            this.shopCity.TabIndex = 16;
            // 
            // shopType
            // 
            this.shopType.AutoSize = true;
            this.shopType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopType.Location = new System.Drawing.Point(73, 42);
            this.shopType.Name = "shopType";
            this.shopType.Size = new System.Drawing.Size(0, 20);
            this.shopType.TabIndex = 15;
            // 
            // shopRatingLabel
            // 
            this.shopRatingLabel.AutoSize = true;
            this.shopRatingLabel.Location = new System.Drawing.Point(10, 106);
            this.shopRatingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.shopRatingLabel.Name = "shopRatingLabel";
            this.shopRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.shopRatingLabel.TabIndex = 14;
            this.shopRatingLabel.Text = "Rating:";
            // 
            // shopAdressLabel
            // 
            this.shopAdressLabel.AutoSize = true;
            this.shopAdressLabel.Location = new System.Drawing.Point(10, 86);
            this.shopAdressLabel.Margin = new System.Windows.Forms.Padding(3);
            this.shopAdressLabel.Name = "shopAdressLabel";
            this.shopAdressLabel.Size = new System.Drawing.Size(42, 13);
            this.shopAdressLabel.TabIndex = 13;
            this.shopAdressLabel.Text = "Adress:";
            // 
            // shopCityLabel
            // 
            this.shopCityLabel.AutoSize = true;
            this.shopCityLabel.Location = new System.Drawing.Point(10, 67);
            this.shopCityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.shopCityLabel.Name = "shopCityLabel";
            this.shopCityLabel.Size = new System.Drawing.Size(27, 13);
            this.shopCityLabel.TabIndex = 12;
            this.shopCityLabel.Text = "City:";
            // 
            // shopTypeLabel
            // 
            this.shopTypeLabel.AutoSize = true;
            this.shopTypeLabel.Location = new System.Drawing.Point(10, 47);
            this.shopTypeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.shopTypeLabel.Name = "shopTypeLabel";
            this.shopTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.shopTypeLabel.TabIndex = 11;
            this.shopTypeLabel.Text = "Type:";
            // 
            // shopTitle
            // 
            this.shopTitle.AutoSize = true;
            this.shopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopTitle.Location = new System.Drawing.Point(73, 18);
            this.shopTitle.Margin = new System.Windows.Forms.Padding(3);
            this.shopTitle.Name = "shopTitle";
            this.shopTitle.Size = new System.Drawing.Size(0, 20);
            this.shopTitle.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonSaveFavorites);
            this.groupBox1.Controls.Add(this.buttonDeleteFromFavorites);
            this.groupBox1.Controls.Add(this.buttonAddComment);
            this.groupBox1.Controls.Add(this.buttonViewComments);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(399, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 189);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(7, 164);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(110, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.Text = "Search...";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(123, 164);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(24, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "S";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSaveFavorites
            // 
            this.buttonSaveFavorites.Location = new System.Drawing.Point(7, 135);
            this.buttonSaveFavorites.Name = "buttonSaveFavorites";
            this.buttonSaveFavorites.Size = new System.Drawing.Size(141, 23);
            this.buttonSaveFavorites.TabIndex = 4;
            this.buttonSaveFavorites.Text = "Save Favorites";
            this.buttonSaveFavorites.UseVisualStyleBackColor = true;
            this.buttonSaveFavorites.Click += new System.EventHandler(this.buttonSaveFavorites_Click);
            // 
            // buttonDeleteFromFavorites
            // 
            this.buttonDeleteFromFavorites.Location = new System.Drawing.Point(7, 106);
            this.buttonDeleteFromFavorites.Name = "buttonDeleteFromFavorites";
            this.buttonDeleteFromFavorites.Size = new System.Drawing.Size(141, 23);
            this.buttonDeleteFromFavorites.TabIndex = 3;
            this.buttonDeleteFromFavorites.Text = "Delete from favorites";
            this.buttonDeleteFromFavorites.UseVisualStyleBackColor = true;
            this.buttonDeleteFromFavorites.Click += new System.EventHandler(this.buttonDeleteFromFavorites_Click);
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Location = new System.Drawing.Point(6, 77);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(141, 23);
            this.buttonAddComment.TabIndex = 2;
            this.buttonAddComment.Text = "Add comment";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // buttonViewComments
            // 
            this.buttonViewComments.Location = new System.Drawing.Point(6, 48);
            this.buttonViewComments.Name = "buttonViewComments";
            this.buttonViewComments.Size = new System.Drawing.Size(141, 23);
            this.buttonViewComments.TabIndex = 1;
            this.buttonViewComments.Text = "View Comments";
            this.buttonViewComments.UseVisualStyleBackColor = true;
            this.buttonViewComments.Click += new System.EventHandler(this.buttonViewComments_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "To Favorites";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxShops);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shops";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageShops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            this.tabPageFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavorites)).EndInit();
            this.groupBoxShops.ResumeLayout(false);
            this.groupBoxShops.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageShops;
        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.TabPage tabPageFavorites;
        private System.Windows.Forms.DataGridView dataGridViewFavorites;
        private System.Windows.Forms.GroupBox groupBoxShops;
        private System.Windows.Forms.Label shopId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label shopRating;
        private System.Windows.Forms.Label shopAdress;
        private System.Windows.Forms.Label shopCity;
        private System.Windows.Forms.Label shopType;
        private System.Windows.Forms.Label shopRatingLabel;
        private System.Windows.Forms.Label shopAdressLabel;
        private System.Windows.Forms.Label shopCityLabel;
        private System.Windows.Forms.Label shopTypeLabel;
        private System.Windows.Forms.Label shopTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeleteFromFavorites;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.Button buttonViewComments;
        private System.Windows.Forms.Button buttonSaveFavorites;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}