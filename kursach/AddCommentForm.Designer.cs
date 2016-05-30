namespace kursach
{
    partial class AddCommentForm
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
            this.groupBoxComment = new System.Windows.Forms.GroupBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComment
            // 
            this.groupBoxComment.Controls.Add(this.textBoxComment);
            this.groupBoxComment.Controls.Add(this.buttonCancel);
            this.groupBoxComment.Controls.Add(this.buttonSubmit);
            this.groupBoxComment.Location = new System.Drawing.Point(12, 12);
            this.groupBoxComment.Name = "groupBoxComment";
            this.groupBoxComment.Size = new System.Drawing.Size(248, 159);
            this.groupBoxComment.TabIndex = 0;
            this.groupBoxComment.TabStop = false;
            this.groupBoxComment.Text = "Comment";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(6, 19);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(236, 105);
            this.textBoxComment.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(133, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(6, 130);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(109, 23);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // AddCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 175);
            this.Controls.Add(this.groupBoxComment);
            this.Name = "AddCommentForm";
            this.Text = "Comment";
            this.groupBoxComment.ResumeLayout(false);
            this.groupBoxComment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}