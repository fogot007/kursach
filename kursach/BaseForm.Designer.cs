using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kursach
{
    public partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.splitContainer1 = new SplitContainer();
            this.splitContainer2 = new SplitContainer();
            this.favouritesLabel = new Label();
            this.buttonOk = new Button();
            this.buttonGo = new Button();
            this.searchString = new TextBox();
            this.radioButtonShops = new RadioButton();
            this.radioButtonFav = new RadioButton();
            this.radioButtonAll = new RadioButton();
            ((ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new Size(684, 362);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = DockStyle.Fill;
            this.splitContainer2.Location = new Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonAll);
            this.splitContainer2.Panel1.Controls.Add(this.favouritesLabel);
            this.splitContainer2.Panel1.Controls.Add(this.buttonOk);
            this.splitContainer2.Panel1.Controls.Add(this.buttonGo);
            this.splitContainer2.Panel1.Controls.Add(this.searchString);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonShops);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonFav);
            this.splitContainer2.Panel1MinSize = 100;
            this.splitContainer2.Panel2MinSize = 250;
            this.splitContainer2.Size = new Size(228, 362);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 0;
            // 
            // favouritesLabel
            // 
            this.favouritesLabel.AutoSize = true;
            this.favouritesLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.favouritesLabel.Location = new Point(3, 80);
            this.favouritesLabel.Name = "favouritesLabel";
            this.favouritesLabel.Size = new Size(93, 20);
            this.favouritesLabel.TabIndex = 13;
            this.favouritesLabel.Text = "Favourites";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new Point(167, 54);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(52, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new Point(113, 55);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new Size(52, 23);
            this.buttonGo.TabIndex = 11;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // searchString
            // 
            this.searchString.Location = new Point(7, 57);
            this.searchString.Name = "searchString";
            this.searchString.Size = new Size(100, 20);
            this.searchString.TabIndex = 10;
            this.searchString.Enter += new EventHandler(this.searchString_Enter);
            this.searchString.Leave += new EventHandler(this.searchString_Leave);
            // 
            // radioButtonShops
            // 
            this.radioButtonShops.AutoSize = true;
            this.radioButtonShops.Checked = true;
            this.radioButtonShops.Location = new Point(97, 34);
            this.radioButtonShops.Name = "radioButtonShops";
            this.radioButtonShops.Size = new Size(64, 17);
            this.radioButtonShops.TabIndex = 8;
            this.radioButtonShops.TabStop = true;
            this.radioButtonShops.Text = "in shops";
            this.radioButtonShops.UseVisualStyleBackColor = true;
            // 
            // radioButtonFav
            // 
            this.radioButtonFav.AutoSize = true;
            this.radioButtonFav.Enabled = false;
            this.radioButtonFav.Location = new Point(7, 34);
            this.radioButtonFav.Name = "radioButtonFav";
            this.radioButtonFav.Size = new Size(82, 17);
            this.radioButtonFav.TabIndex = 7;
            this.radioButtonFav.Text = "in favourites";
            this.radioButtonFav.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new Point(167, 34);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new Size(35, 17);
            this.radioButtonAll.TabIndex = 14;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "all";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(684, 362);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = Cursors.Default;
            this.Name = "BaseForm";
            this.Text = "ShopManager";
            this.FormClosed += new FormClosedEventHandler(this.NonUserForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected SplitContainer splitContainer1;
        protected SplitContainer splitContainer2;
        protected RadioButton radioButtonFav;
        protected RadioButton radioButtonShops;
        protected Button buttonOk;
        protected Button buttonGo;
        protected TextBox searchString;
        protected Label favouritesLabel;
        protected RadioButton radioButtonAll;
    }
}