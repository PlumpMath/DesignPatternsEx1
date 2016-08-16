namespace FacebookApp.SubComponents
{
    partial class Feed
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
            this.postsList = new FacebookApp.SubComponents.PostsList();
            this.commentBox = new FacebookApp.CommentBox();
            this.SuspendLayout();
            // 
            // postsList
            // 
            this.postsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postsList.Location = new System.Drawing.Point(4, 65);
            this.postsList.Name = "postsList";
            this.postsList.Size = new System.Drawing.Size(379, 387);
            this.postsList.TabIndex = 1;
            // 
            // commentBox
            // 
            this.commentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentBox.Location = new System.Drawing.Point(3, 3);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(380, 55);
            this.commentBox.TabIndex = 0;
            this.commentBox.Type = FacebookApp.eCommentBoxType.WallUser;
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.postsList);
            this.Controls.Add(this.commentBox);
            this.Name = "Feed";
            this.Size = new System.Drawing.Size(386, 455);
            this.ResumeLayout(false);

        }

        #endregion

        private CommentBox commentBox;
        private PostsList postsList;
    }
}
