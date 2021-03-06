﻿namespace FacebookApp.SubComponents
{
    partial class PostDetails
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
            this.labelPostedTime = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.userProfileImagePostedBy = new FacebookApp.UserProfileImage();
            this.labelPostType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPostedTime
            // 
            this.labelPostedTime.AutoSize = true;
            this.labelPostedTime.Location = new System.Drawing.Point(55, 35);
            this.labelPostedTime.Name = "labelPostedTime";
            this.labelPostedTime.Size = new System.Drawing.Size(93, 13);
            this.labelPostedTime.TabIndex = 7;
            this.labelPostedTime.Text = "Posted X time ago";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFrom.Location = new System.Drawing.Point(55, 4);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(66, 13);
            this.labelFrom.TabIndex = 6;
            this.labelFrom.Text = "Poster name";
            this.labelFrom.Click += new System.EventHandler(this.labelFrom_Click);
            // 
            // userProfileImagePostedBy
            // 
            this.userProfileImagePostedBy.BackColor = System.Drawing.Color.White;
            this.userProfileImagePostedBy.Location = new System.Drawing.Point(3, 3);
            this.userProfileImagePostedBy.Name = "userProfileImagePostedBy";
            this.userProfileImagePostedBy.Size = new System.Drawing.Size(46, 45);
            this.userProfileImagePostedBy.TabIndex = 5;
            this.userProfileImagePostedBy.TabStop = false;
            // 
            // labelPostType
            // 
            this.labelPostType.AutoSize = true;
            this.labelPostType.Location = new System.Drawing.Point(360, 4);
            this.labelPostType.Name = "labelPostType";
            this.labelPostType.Size = new System.Drawing.Size(27, 13);
            this.labelPostType.TabIndex = 8;
            this.labelPostType.Text = "type";
            // 
            // PostDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.labelPostType);
            this.Controls.Add(this.labelPostedTime);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.userProfileImagePostedBy);
            this.Name = "PostDetails";
            this.Size = new System.Drawing.Size(441, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostedTime;
        private System.Windows.Forms.Label labelFrom;
        private UserProfileImage userProfileImagePostedBy;
        private System.Windows.Forms.Label labelPostType;
    }
}
