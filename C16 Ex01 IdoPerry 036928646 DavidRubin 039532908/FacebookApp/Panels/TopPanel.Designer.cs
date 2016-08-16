namespace FacebookApp
{
    partial class TopPanel
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
            this.userCoverPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureboxLoggedUserImage = new FacebookApp.UserProfileImage();
            this.userProfileImage = new FacebookApp.UserProfileImage();
            ((System.ComponentModel.ISupportInitialize)(this.userCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLoggedUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // userCoverPhoto
            // 
            this.userCoverPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userCoverPhoto.Location = new System.Drawing.Point(0, 0);
            this.userCoverPhoto.Name = "userCoverPhoto";
            this.userCoverPhoto.Size = new System.Drawing.Size(746, 276);
            this.userCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userCoverPhoto.TabIndex = 1;
            this.userCoverPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(18, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 110);
            this.panel1.TabIndex = 2;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUserName.Location = new System.Drawing.Point(134, 206);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(361, 46);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "textBoxUserName";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(690, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 48);
            this.panel2.TabIndex = 5;
            // 
            // pictureboxLoggedUserImage
            // 
            this.pictureboxLoggedUserImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxLoggedUserImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureboxLoggedUserImage.Location = new System.Drawing.Point(695, 13);
            this.pictureboxLoggedUserImage.Name = "pictureboxLoggedUserImage";
            this.pictureboxLoggedUserImage.Size = new System.Drawing.Size(39, 38);
            this.pictureboxLoggedUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxLoggedUserImage.TabIndex = 4;
            this.pictureboxLoggedUserImage.TabStop = false;
            this.pictureboxLoggedUserImage.Click += new System.EventHandler(this.pictureboxLoggedUserImage_Click);
            // 
            // userProfileImage
            // 
            this.userProfileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userProfileImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userProfileImage.Location = new System.Drawing.Point(23, 152);
            this.userProfileImage.Name = "userProfileImage";
            this.userProfileImage.Size = new System.Drawing.Size(100, 100);
            this.userProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfileImage.TabIndex = 0;
            this.userProfileImage.TabStop = false;
            // 
            // TopPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureboxLoggedUserImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.userProfileImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userCoverPhoto);
            this.Name = "TopPanel";
            this.Size = new System.Drawing.Size(746, 276);
            ((System.ComponentModel.ISupportInitialize)(this.userCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLoggedUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserProfileImage userProfileImage;
        private System.Windows.Forms.PictureBox userCoverPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserName;
        private UserProfileImage pictureboxLoggedUserImage;
        private System.Windows.Forms.Panel panel2;
    }
}
