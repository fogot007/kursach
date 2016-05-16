namespace kursach
{
    public partial class UserForm
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
            this.dataGridViewShops = new System.Windows.Forms.DataGridView();
            this.dataGridViewLeftPanel = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeftPanel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewShops);
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewLeftPanel);
            this.splitContainer2.SplitterDistance = 100;
            // 
            // radioButtonFav
            // 
            this.radioButtonFav.Enabled = true;
            this.radioButtonFav.Location = new System.Drawing.Point(7, 27);
            // 
            // radioButtonShops
            // 
            this.radioButtonShops.Location = new System.Drawing.Point(97, 27);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(176, 47);
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(113, 47);
            this.buttonGo.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchString
            // 
            this.searchString.Location = new System.Drawing.Point(7, 50);
            this.searchString.Enter += new System.EventHandler(this.searchString_Enter_1);
            // 
            // favouritesLabel
            // 
            this.favouritesLabel.Location = new System.Drawing.Point(3, 73);
            this.favouritesLabel.Size = new System.Drawing.Size(98, 20);
            this.favouritesLabel.Text = "Favourites:";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.Location = new System.Drawing.Point(176, 27);
            // 
            // dataGridViewShops
            // 
            this.dataGridViewShops.AllowUserToAddRows = false;
            this.dataGridViewShops.AllowUserToDeleteRows = false;
            this.dataGridViewShops.AllowUserToOrderColumns = true;
            this.dataGridViewShops.AllowUserToResizeColumns = false;
            this.dataGridViewShops.AllowUserToResizeRows = false;
            this.dataGridViewShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShops.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShops.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShops.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShops.Name = "dataGridViewShops";
            this.dataGridViewShops.ReadOnly = true;
            this.dataGridViewShops.RowHeadersVisible = false;
            this.dataGridViewShops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShops.Size = new System.Drawing.Size(452, 362);
            this.dataGridViewShops.TabIndex = 0;
            this.dataGridViewShops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShops_CellContentClick);
            // 
            // dataGridViewLeftPanel
            // 
            this.dataGridViewLeftPanel.AllowUserToAddRows = false;
            this.dataGridViewLeftPanel.AllowUserToDeleteRows = false;
            this.dataGridViewLeftPanel.AllowUserToOrderColumns = true;
            this.dataGridViewLeftPanel.AllowUserToResizeColumns = false;
            this.dataGridViewLeftPanel.AllowUserToResizeRows = false;
            this.dataGridViewLeftPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeftPanel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLeftPanel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLeftPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLeftPanel.Name = "dataGridViewLeftPanel";
            this.dataGridViewLeftPanel.ReadOnly = true;
            this.dataGridViewLeftPanel.RowHeadersVisible = false;
            this.dataGridViewLeftPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeftPanel.Size = new System.Drawing.Size(228, 258);
            this.dataGridViewLeftPanel.TabIndex = 0;
            this.dataGridViewLeftPanel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeftPanel_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(228, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.closeLogoutToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeftPanel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            Data.DataGridViewShops = dataGridViewShops;
            Data.DataGridViewFav = dataGridViewLeftPanel;
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShops;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewLeftPanel;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}