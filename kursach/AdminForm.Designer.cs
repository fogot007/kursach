namespace kursach
{
    partial class AdminForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageShops = new System.Windows.Forms.TabPage();
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
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
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.Permissions = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.labelPermissions = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPageShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.groupBoxShops.SuspendLayout();
            this.groupBoxUsers.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageShops);
            this.tabControl.Controls.Add(this.tabPageUsers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(393, 353);
            this.tabControl.TabIndex = 0;
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
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(385, 327);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(379, 321);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.catalogToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.catalogToolStripMenuItem.Text = "Catalog";
            this.catalogToolStripMenuItem.Click += new System.EventHandler(this.catalogToolStripMenuItem_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 48);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(141, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(7, 77);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(140, 23);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Edit ";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.addButton);
            this.groupBoxOperations.Controls.Add(this.deleteButton);
            this.groupBoxOperations.Controls.Add(this.EditButton);
            this.groupBoxOperations.Location = new System.Drawing.Point(399, 184);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(153, 105);
            this.groupBoxOperations.TabIndex = 9;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
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
            this.groupBoxShops.Location = new System.Drawing.Point(400, 27);
            this.groupBoxShops.Name = "groupBoxShops";
            this.groupBoxShops.Size = new System.Drawing.Size(153, 150);
            this.groupBoxShops.TabIndex = 10;
            this.groupBoxShops.TabStop = false;
            this.groupBoxShops.Text = "Information:";
            // 
            // shopId
            // 
            this.shopId.AutoSize = true;
            this.shopId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopId.Location = new System.Drawing.Point(73, 120);
            this.shopId.Name = "shopId";
            this.shopId.Size = new System.Drawing.Size(19, 20);
            this.shopId.TabIndex = 20;
            this.shopId.Text = "1";
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
            this.shopRating.Size = new System.Drawing.Size(19, 20);
            this.shopRating.TabIndex = 18;
            this.shopRating.Text = "1";
            // 
            // shopAdress
            // 
            this.shopAdress.AutoSize = true;
            this.shopAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopAdress.Location = new System.Drawing.Point(73, 81);
            this.shopAdress.Name = "shopAdress";
            this.shopAdress.Size = new System.Drawing.Size(19, 20);
            this.shopAdress.TabIndex = 17;
            this.shopAdress.Text = "1";
            // 
            // shopCity
            // 
            this.shopCity.AutoSize = true;
            this.shopCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopCity.Location = new System.Drawing.Point(73, 62);
            this.shopCity.Name = "shopCity";
            this.shopCity.Size = new System.Drawing.Size(19, 20);
            this.shopCity.TabIndex = 16;
            this.shopCity.Text = "1";
            // 
            // shopType
            // 
            this.shopType.AutoSize = true;
            this.shopType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopType.Location = new System.Drawing.Point(73, 42);
            this.shopType.Name = "shopType";
            this.shopType.Size = new System.Drawing.Size(19, 20);
            this.shopType.TabIndex = 15;
            this.shopType.Text = "1";
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
            this.shopTitle.Location = new System.Drawing.Point(9, 19);
            this.shopTitle.Margin = new System.Windows.Forms.Padding(3);
            this.shopTitle.Name = "shopTitle";
            this.shopTitle.Size = new System.Drawing.Size(0, 20);
            this.shopTitle.TabIndex = 10;
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.Permissions);
            this.groupBoxUsers.Controls.Add(this.UserId);
            this.groupBoxUsers.Controls.Add(this.labelPermissions);
            this.groupBoxUsers.Controls.Add(this.labelUserId);
            this.groupBoxUsers.Controls.Add(this.labelUserLogin);
            this.groupBoxUsers.Location = new System.Drawing.Point(394, 28);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Size = new System.Drawing.Size(153, 151);
            this.groupBoxUsers.TabIndex = 19;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Information:";
            // 
            // Permissions
            // 
            this.Permissions.AutoSize = true;
            this.Permissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Permissions.Location = new System.Drawing.Point(78, 102);
            this.Permissions.Name = "Permissions";
            this.Permissions.Size = new System.Drawing.Size(0, 20);
            this.Permissions.TabIndex = 16;
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UserId.Location = new System.Drawing.Point(78, 57);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(0, 20);
            this.UserId.TabIndex = 15;
            // 
            // labelPermissions
            // 
            this.labelPermissions.AutoSize = true;
            this.labelPermissions.Location = new System.Drawing.Point(10, 107);
            this.labelPermissions.Margin = new System.Windows.Forms.Padding(3);
            this.labelPermissions.Name = "labelPermissions";
            this.labelPermissions.Size = new System.Drawing.Size(62, 13);
            this.labelPermissions.TabIndex = 12;
            this.labelPermissions.Text = "Permissions";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(10, 62);
            this.labelUserId.Margin = new System.Windows.Forms.Padding(3);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(43, 13);
            this.labelUserId.TabIndex = 11;
            this.labelUserId.Text = "User id:";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelUserLogin.Location = new System.Drawing.Point(9, 19);
            this.labelUserLogin.Margin = new System.Windows.Forms.Padding(3);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(0, 20);
            this.labelUserLogin.TabIndex = 10;
            // 
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(6, 19);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(140, 23);
            this.ButtonExport.TabIndex = 8;
            this.ButtonExport.Text = "Export";
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.importButton_Click);
            // 
            // ButtonImport
            // 
            this.ButtonImport.Location = new System.Drawing.Point(6, 48);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(140, 23);
            this.ButtonImport.TabIndex = 9;
            this.ButtonImport.Text = "Import";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.ButtonExport);
            this.groupBoxData.Controls.Add(this.ButtonImport);
            this.groupBoxData.Location = new System.Drawing.Point(399, 295);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(153, 76);
            this.groupBoxData.TabIndex = 20;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 377);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxUsers);
            this.Controls.Add(this.groupBoxShops);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm1_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabPageShops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxShops.ResumeLayout(false);
            this.groupBoxShops.PerformLayout();
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageShops;
        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.GroupBox groupBoxShops;
        private System.Windows.Forms.Label shopRating;
        private System.Windows.Forms.Label shopAdress;
        private System.Windows.Forms.Label shopCity;
        private System.Windows.Forms.Label shopType;
        private System.Windows.Forms.Label shopRatingLabel;
        private System.Windows.Forms.Label shopAdressLabel;
        private System.Windows.Forms.Label shopCityLabel;
        private System.Windows.Forms.Label shopTypeLabel;
        private System.Windows.Forms.Label shopTitle;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.Label Permissions;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label labelPermissions;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label shopId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
    }
}