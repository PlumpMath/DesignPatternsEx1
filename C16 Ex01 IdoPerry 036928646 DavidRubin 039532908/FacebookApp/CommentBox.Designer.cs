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
            ((System.ComponentModel.ISupportInitialize)(this.userProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // userProfileImage
            // 
            this.userProfileImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userProfileImage.Location = new System.Drawing.Point(3, 4);
            this.userProfileImage.Name = "userProfileImage";
            this.userProfileImage.Size = new System.Drawing.Size(44, 45);
            this.userProfileImage.TabIndex = 0;
            this.userProfileImage.TabStop = false;
            // 
            // textBoxCommentText
            // 
            this.textBoxCommentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommentText.Location = new System.Drawing.Point(53, 19);
            this.textBoxCommentText.Name = "textBoxCommentText";
            this.textBoxCommentText.Size = new System.Drawing.Size(255, 20);
            this.textBoxCommentText.TabIndex = 1;
            this.textBoxCommentText.Text = "write a comment";
            // 
            // CommentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCommentText);
            this.Controls.Add(this.userProfileImage);
            this.Name = "CommentBox";
            this.Size = new System.Drawing.Size(311, 55);
            ((System.ComponentModel.ISupportInitialize)(this.userProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserProfileImage userProfileImage;
        private System.Windows.Forms.TextBox textBoxCommentText;
    }
}
