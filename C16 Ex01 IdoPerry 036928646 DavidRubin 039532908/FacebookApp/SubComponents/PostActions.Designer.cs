namespace FacebookApp.SubComponents
{
    partial class PostActions
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
            this.buttonLike = new System.Windows.Forms.Button();
            this.commentBoxPostComment = new FacebookApp.CommentBox();
            this.SuspendLayout();
            // 
            // buttonLike
            // 
            this.buttonLike.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLike.Location = new System.Drawing.Point(241, 15);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLike.MaximumSize = new System.Drawing.Size(50, 25);
            this.buttonLike.MinimumSize = new System.Drawing.Size(50, 25);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(50, 25);
            this.buttonLike.TabIndex = 0;
            this.buttonLike.Text = "like";
            this.buttonLike.UseVisualStyleBackColor = true;
            // 
            // commentBoxPostComment
            // 
            this.commentBoxPostComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentBoxPostComment.Location = new System.Drawing.Point(0, 12);
            this.commentBoxPostComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentBoxPostComment.Name = "commentBoxPostComment";
            this.commentBoxPostComment.Size = new System.Drawing.Size(235, 28);
            this.commentBoxPostComment.TabIndex = 2;
            this.commentBoxPostComment.Type = FacebookApp.eCommentBoxType.Comment;
            // 
            // PostActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.commentBoxPostComment);
            this.Name = "PostActions";
            this.Size = new System.Drawing.Size(293, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private CommentBox commentBoxPostComment;
        private System.Windows.Forms.Button buttonLike;
    }
}
