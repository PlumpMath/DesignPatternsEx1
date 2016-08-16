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
            this.topPanel = new System.Windows.Forms.Panel();
            this.commentsThreadSections = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // commentBoxPostComment
            // 
            this.commentBoxPostComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.commentBoxPostComment.Location = new System.Drawing.Point(0, 59);
            this.commentBoxPostComment.Name = "commentBoxPostComment";
            this.commentBoxPostComment.Size = new System.Drawing.Size(474, 55);
            this.commentBoxPostComment.TabIndex = 2;
            this.commentBoxPostComment.Type = FacebookApp.eCommentBoxType.Comment;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(474, 39);
            this.topPanel.TabIndex = 3;
            // 
            // commentsThreadSections
            // 
            this.commentsThreadSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsThreadSections.Location = new System.Drawing.Point(3, 45);
            this.commentsThreadSections.Name = "commentsThreadSections";
            this.commentsThreadSections.Size = new System.Drawing.Size(474, 8);
            this.commentsThreadSections.TabIndex = 5;
            // 
            // PostActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commentsThreadSections);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.commentBoxPostComment);
            this.Name = "PostActions";
            this.Size = new System.Drawing.Size(474, 114);
            this.ResumeLayout(false);

        }

        #endregion

        private CommentBox commentBoxPostComment;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel commentsThreadSections;
    }
}
