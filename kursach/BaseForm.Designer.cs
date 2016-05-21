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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.favouritesLabel = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.radioButtonShops = new System.Windows.Forms.RadioButton();
            this.radioButtonFav = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(684, 362);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonAll);
            this.splitContainer2.Panel1.Controls.Add(this.favouritesLabel);
            this.splitContainer2.Panel1.Controls.Add(this.buttonGo);
            this.splitContainer2.Panel1.Controls.Add(this.searchString);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonShops);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonFav);
            this.splitContainer2.Panel1MinSize = 100;
            this.splitContainer2.Panel2MinSize = 250;
            this.splitContainer2.Size = new System.Drawing.Size(228, 362);
            this.splitContainer2.SplitterDistance = 108;
            this.splitContainer2.TabIndex = 0;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(167, 34);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(35, 17);
            this.radioButtonAll.TabIndex = 14;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "all";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // favouritesLabel
            // 
            this.favouritesLabel.AutoSize = true;
            this.favouritesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favouritesLabel.Location = new System.Drawing.Point(3, 80);
            this.favouritesLabel.Name = "favouritesLabel";
            this.favouritesLabel.Size = new System.Drawing.Size(93, 20);
            this.favouritesLabel.TabIndex = 13;
            this.favouritesLabel.Text = "Favourites";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(154, 57);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(48, 23);
            this.buttonGo.TabIndex = 11;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // searchString
            // 
            this.searchString.Location = new System.Drawing.Point(7, 57);
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(141, 20);
            this.searchString.TabIndex = 10;
            this.searchString.Enter += new System.EventHandler(this.searchString_Enter);
            this.searchString.Leave += new System.EventHandler(this.searchString_Leave);
            // 
            // radioButtonShops
            // 
            this.radioButtonShops.AutoSize = true;
            this.radioButtonShops.Location = new System.Drawing.Point(97, 34);
            this.radioButtonShops.Name = "radioButtonShops";
            this.radioButtonShops.Size = new System.Drawing.Size(64, 17);
            this.radioButtonShops.TabIndex = 8;
            this.radioButtonShops.Text = "in shops";
            this.radioButtonShops.UseVisualStyleBackColor = true;
            this.radioButtonShops.Visible = false;
            // 
            // radioButtonFav
            // 
            this.radioButtonFav.AutoSize = true;
            this.radioButtonFav.Enabled = false;
            this.radioButtonFav.Location = new System.Drawing.Point(7, 34);
            this.radioButtonFav.Name = "radioButtonFav";
            this.radioButtonFav.Size = new System.Drawing.Size(82, 17);
            this.radioButtonFav.TabIndex = 7;
            this.radioButtonFav.Text = "in favourites";
            this.radioButtonFav.UseVisualStyleBackColor = true;
            this.radioButtonFav.Visible = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 362);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "BaseForm";
            this.Text = "ShopManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NonUserForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected SplitContainer splitContainer1;
        protected SplitContainer splitContainer2;
        protected RadioButton radioButtonFav;
        protected RadioButton radioButtonShops;
        protected Button buttonGo;
        protected TextBox searchString;
        protected Label favouritesLabel;
        protected RadioButton radioButtonAll;
    }
}