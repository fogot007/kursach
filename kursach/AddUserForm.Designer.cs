namespace kursach
{
    partial class AddUserForm
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
            this.ButtonBackToShops = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxToAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonBackToShops
            // 
            this.ButtonBackToShops.Location = new System.Drawing.Point(106, 119);
            this.ButtonBackToShops.Name = "ButtonBackToShops";
            this.ButtonBackToShops.Size = new System.Drawing.Size(88, 27);
            this.ButtonBackToShops.TabIndex = 17;
            this.ButtonBackToShops.Text = "Back to shops";
            this.ButtonBackToShops.UseVisualStyleBackColor = true;
            this.ButtonBackToShops.Click += new System.EventHandler(this.ButtonBackToShops_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 77);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(9, 47);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 14;
            this.labelLogin.Text = "Login:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(75, 70);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 12;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(75, 44);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 11;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(12, 119);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(88, 27);
            this.ButtonSubmit.TabIndex = 10;
            this.ButtonSubmit.Text = "ButtonSubmit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registration";
            // 
            // checkBoxToAdmin
            // 
            this.checkBoxToAdmin.AutoSize = true;
            this.checkBoxToAdmin.Location = new System.Drawing.Point(12, 96);
            this.checkBoxToAdmin.Name = "checkBoxToAdmin";
            this.checkBoxToAdmin.Size = new System.Drawing.Size(111, 17);
            this.checkBoxToAdmin.TabIndex = 18;
            this.checkBoxToAdmin.Text = "admin permissions";
            this.checkBoxToAdmin.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 151);
            this.Controls.Add(this.checkBoxToAdmin);
            this.Controls.Add(this.ButtonBackToShops);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "Add user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBackToShops;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxToAdmin;
    }
}