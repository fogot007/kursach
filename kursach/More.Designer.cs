namespace kursach
{
    partial class More
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
            this.closeButton = new System.Windows.Forms.Button();
            this.shopTitle = new System.Windows.Forms.Label();
            this.shopTypeLabel = new System.Windows.Forms.Label();
            this.shopCityLabel = new System.Windows.Forms.Label();
            this.shopAdressLabel = new System.Windows.Forms.Label();
            this.shopRatingLabel = new System.Windows.Forms.Label();
            this.shopType = new System.Windows.Forms.Label();
            this.shopCity = new System.Windows.Forms.Label();
            this.shopAdress = new System.Windows.Forms.Label();
            this.shopRating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(84, 164);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // shopTitle
            // 
            this.shopTitle.AutoSize = true;
            this.shopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopTitle.Location = new System.Drawing.Point(99, 9);
            this.shopTitle.Name = "shopTitle";
            this.shopTitle.Size = new System.Drawing.Size(86, 20);
            this.shopTitle.TabIndex = 1;
            this.shopTitle.Text = "Shop title";
            // 
            // shopTypeLabel
            // 
            this.shopTypeLabel.AutoSize = true;
            this.shopTypeLabel.Location = new System.Drawing.Point(33, 46);
            this.shopTypeLabel.Name = "shopTypeLabel";
            this.shopTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.shopTypeLabel.TabIndex = 2;
            this.shopTypeLabel.Text = "Type:";
            // 
            // shopCityLabel
            // 
            this.shopCityLabel.AutoSize = true;
            this.shopCityLabel.Location = new System.Drawing.Point(33, 74);
            this.shopCityLabel.Name = "shopCityLabel";
            this.shopCityLabel.Size = new System.Drawing.Size(27, 13);
            this.shopCityLabel.TabIndex = 3;
            this.shopCityLabel.Text = "City:";
            // 
            // shopAdressLabel
            // 
            this.shopAdressLabel.AutoSize = true;
            this.shopAdressLabel.Location = new System.Drawing.Point(33, 104);
            this.shopAdressLabel.Name = "shopAdressLabel";
            this.shopAdressLabel.Size = new System.Drawing.Size(42, 13);
            this.shopAdressLabel.TabIndex = 4;
            this.shopAdressLabel.Text = "Adress:";
            // 
            // shopRatingLabel
            // 
            this.shopRatingLabel.AutoSize = true;
            this.shopRatingLabel.Location = new System.Drawing.Point(33, 132);
            this.shopRatingLabel.Name = "shopRatingLabel";
            this.shopRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.shopRatingLabel.TabIndex = 5;
            this.shopRatingLabel.Text = "Rating:";
            // 
            // shopType
            // 
            this.shopType.AutoSize = true;
            this.shopType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopType.Location = new System.Drawing.Point(111, 46);
            this.shopType.Name = "shopType";
            this.shopType.Size = new System.Drawing.Size(57, 20);
            this.shopType.TabIndex = 6;
            this.shopType.Text = "label6";
            // 
            // shopCity
            // 
            this.shopCity.AutoSize = true;
            this.shopCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopCity.Location = new System.Drawing.Point(111, 74);
            this.shopCity.Name = "shopCity";
            this.shopCity.Size = new System.Drawing.Size(57, 20);
            this.shopCity.TabIndex = 7;
            this.shopCity.Text = "label7";
            // 
            // shopAdress
            // 
            this.shopAdress.AutoSize = true;
            this.shopAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopAdress.Location = new System.Drawing.Point(111, 104);
            this.shopAdress.Name = "shopAdress";
            this.shopAdress.Size = new System.Drawing.Size(57, 20);
            this.shopAdress.TabIndex = 8;
            this.shopAdress.Text = "label8";
            // 
            // shopRating
            // 
            this.shopRating.AutoSize = true;
            this.shopRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.shopRating.Location = new System.Drawing.Point(111, 132);
            this.shopRating.Name = "shopRating";
            this.shopRating.Size = new System.Drawing.Size(61, 20);
            this.shopRating.TabIndex = 9;
            this.shopRating.Text = "veewff";
            // 
            // More
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 197);
            this.Controls.Add(this.shopRating);
            this.Controls.Add(this.shopAdress);
            this.Controls.Add(this.shopCity);
            this.Controls.Add(this.shopType);
            this.Controls.Add(this.shopRatingLabel);
            this.Controls.Add(this.shopAdressLabel);
            this.Controls.Add(this.shopCityLabel);
            this.Controls.Add(this.shopTypeLabel);
            this.Controls.Add(this.shopTitle);
            this.Controls.Add(this.closeButton);
            this.Name = "More";
            this.Text = "More";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label shopTitle;
        private System.Windows.Forms.Label shopTypeLabel;
        private System.Windows.Forms.Label shopCityLabel;
        private System.Windows.Forms.Label shopAdressLabel;
        private System.Windows.Forms.Label shopRatingLabel;
        private System.Windows.Forms.Label shopType;
        private System.Windows.Forms.Label shopCity;
        private System.Windows.Forms.Label shopAdress;
        private System.Windows.Forms.Label shopRating;
    }
}