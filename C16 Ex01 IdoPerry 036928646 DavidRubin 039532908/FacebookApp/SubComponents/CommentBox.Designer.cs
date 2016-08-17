namespace FacebookApp
{
    partial class CommentBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userProfileImage = new FacebookApp.UserProfileImage();
            this.textBoxCommentText = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userProfileImage
            // 
            this.userProfileImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userProfileImage.BackColor = System.Drawing.Color.White;
            this.userProfileImage.Location = new System.Drawing.Point(10, 9);
            this.userProfileImage.Name = "userProfileImage";
            this.userProfileImage.Size = new System.Drawing.Size(34, 35);
            this.userProfileImage.TabIndex = 0;
            this.userProfileImage.TabStop = false;
            // 
            // textBoxCommentText
            // 
            this.textBoxCommentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommentText.Location = new System.Drawing.Point(53, 18);
            this.textBoxCommentText.Name = "textBoxCommentText";
            this.textBoxCommentText.Size = new System.Drawing.Size(128, 20);
            this.textBoxCommentText.TabIndex = 1;
            this.textBoxCommentText.Text = "write a comment";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Location = new System.Drawing.Point(187, 16);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(67, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Post";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // CommentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCommentText);
            this.Controls.Add(this.userProfileImage);
            this.Name = "CommentBox";
            this.Size = new System.Drawing.Size(258, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserProfileImage userProfileImage;
        private System.Windows.Forms.TextBox textBoxCommentText;
        private System.Windows.Forms.Button buttonSubmit;
    }
}
