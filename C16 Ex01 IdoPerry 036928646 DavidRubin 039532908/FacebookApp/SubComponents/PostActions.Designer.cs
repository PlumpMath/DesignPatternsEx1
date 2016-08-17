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
            this.commentBoxPostComment = new FacebookApp.CommentBox();
            this.buttonLike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentBoxPostComment
            // 
            this.commentBoxPostComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentBoxPostComment.Location = new System.Drawing.Point(0, 36);
            this.commentBoxPostComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentBoxPostComment.Name = "commentBoxPostComment";
            this.commentBoxPostComment.Size = new System.Drawing.Size(474, 36);
            this.commentBoxPostComment.TabIndex = 2;
            this.commentBoxPostComment.Type = FacebookApp.eCommentBoxType.Comment;
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(2, 2);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(50, 27);
            this.buttonLike.TabIndex = 0;
            this.buttonLike.Text = "like";
            this.buttonLike.UseVisualStyleBackColor = true;
            // 
            // PostActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.commentBoxPostComment);
            this.Name = "PostActions";
            this.Size = new System.Drawing.Size(474, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private CommentBox commentBoxPostComment;
        private System.Windows.Forms.Button buttonLike;
    }
}
