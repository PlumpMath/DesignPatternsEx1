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
            this.commentBox1 = new FacebookApp.CommentBox();
            this.postsFeed1 = new FacebookApp.SubComponents.PostsList();
            this.SuspendLayout();
            // 
            // commentBox1
            // 
            this.commentBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentBox1.Location = new System.Drawing.Point(3, 3);
            this.commentBox1.Name = "commentBox1";
            this.commentBox1.Size = new System.Drawing.Size(380, 55);
            this.commentBox1.TabIndex = 0;
            this.commentBox1.Type = FacebookApp.eCommentBoxType.Comment;
            // 
            // postsFeed1
            // 
            this.postsFeed1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postsFeed1.Location = new System.Drawing.Point(4, 65);
            this.postsFeed1.Name = "postsFeed1";
            this.postsFeed1.Size = new System.Drawing.Size(379, 387);
            this.postsFeed1.TabIndex = 1;
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postsFeed1);
            this.Controls.Add(this.commentBox1);
            this.Name = "Feed";
            this.Size = new System.Drawing.Size(386, 455);
            this.ResumeLayout(false);

        }

        #endregion

        private CommentBox commentBox1;
        private PostsList postsFeed1;
    }
}
