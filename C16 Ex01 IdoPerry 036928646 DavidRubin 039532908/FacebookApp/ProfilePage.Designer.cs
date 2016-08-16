namespace FacebookApp
{
    partial class ProfilePage
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new FacebookApp.TopPanel();
            this.commentBox1 = new FacebookApp.CommentBox();
            this.leftPanel = new FacebookApp.LeftPanel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.commentBox1);
            this.mainPanel.Location = new System.Drawing.Point(234, 211);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(528, 734);
            this.mainPanel.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Location = new System.Drawing.Point(4, 5);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(754, 198);
            this.topPanel.TabIndex = 1;
            this.topPanel.Load += new System.EventHandler(this.topPanel_Load);
            // 
            // commentBox1
            // 
            this.commentBox1.Location = new System.Drawing.Point(17, 15);
            this.commentBox1.Name = "commentBox1";
            this.commentBox1.Size = new System.Drawing.Size(507, 55);
            this.commentBox1.TabIndex = 0;
            this.commentBox1.Type = FacebookApp.eCommentBoxType.Comment;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.Location = new System.Drawing.Point(4, 211);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(227, 735);
            this.leftPanel.TabIndex = 0;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(763, 627);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LeftPanel leftPanel;
        private TopPanel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private CommentBox commentBox1;
    }
}
