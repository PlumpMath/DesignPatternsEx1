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
            this.labelUserName = new System.Windows.Forms.Label();
            this.loadingPanel = new FacebookApp.LoadingPanel();
            this.pictureboxLoggedUserImage = new FacebookApp.UserProfileImage();
            this.userProfileImage = new FacebookApp.UserProfileImage();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonParty = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // userCoverPhoto
            // 
            this.userCoverPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userCoverPhoto.Location = new System.Drawing.Point(0, 0);
            this.userCoverPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userCoverPhoto.Name = "userCoverPhoto";
            this.userCoverPhoto.Size = new System.Drawing.Size(1119, 425);
            this.userCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userCoverPhoto.TabIndex = 1;
            this.userCoverPhoto.TabStop = false;
            this.userCoverPhoto.Visible = false;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUserName.Location = new System.Drawing.Point(201, 317);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(530, 69);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "textBoxUserName";
            this.labelUserName.Visible = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.AnimationSpeed = 12;
            this.loadingPanel.AutoSize = true;
            this.loadingPanel.CurrentActiveSquare = 2;
            this.loadingPanel.LoadingLabel = "";
            this.loadingPanel.Location = new System.Drawing.Point(417, 166);
            this.loadingPanel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.loadingPanel.MaximumSize = new System.Drawing.Size(280, 111);
            this.loadingPanel.MinimumSize = new System.Drawing.Size(280, 111);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(280, 111);
            this.loadingPanel.TabIndex = 6;
            // 
            // pictureboxLoggedUserImage
            // 
            this.pictureboxLoggedUserImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxLoggedUserImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureboxLoggedUserImage.Location = new System.Drawing.Point(1042, 20);
            this.pictureboxLoggedUserImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureboxLoggedUserImage.Name = "pictureboxLoggedUserImage";
            this.pictureboxLoggedUserImage.Size = new System.Drawing.Size(58, 58);
            this.pictureboxLoggedUserImage.TabIndex = 4;
            this.pictureboxLoggedUserImage.TabStop = false;
            this.pictureboxLoggedUserImage.Visible = false;
            this.pictureboxLoggedUserImage.Click += new System.EventHandler(this.PictureboxLoggedUserImageClick);
            // 
            // userProfileImage
            // 
            this.userProfileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userProfileImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userProfileImage.Location = new System.Drawing.Point(34, 234);
            this.userProfileImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userProfileImage.Name = "userProfileImage";
            this.userProfileImage.Size = new System.Drawing.Size(150, 154);
            this.userProfileImage.TabIndex = 0;
            this.userProfileImage.TabStop = false;
            this.userProfileImage.Visible = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.Location = new System.Drawing.Point(921, 20);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(112, 35);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettingsClick);
            // 
            // buttonParty
            // 
            this.buttonParty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonParty.Location = new System.Drawing.Point(533, 13);
            this.buttonParty.Name = "buttonParty";
            this.buttonParty.Size = new System.Drawing.Size(75, 23);
            this.buttonParty.TabIndex = 8;
            this.buttonParty.Text = "PARTY!";
            this.buttonParty.UseVisualStyleBackColor = true;
            this.buttonParty.Click += new System.EventHandler(this.ButtonPartyClick);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStatistics.Location = new System.Drawing.Point(801, 20);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(112, 35);
            this.buttonStatistics.TabIndex = 8;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // TopPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonParty);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.pictureboxLoggedUserImage);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.userProfileImage);
            this.Controls.Add(this.userCoverPhoto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TopPanel";
            this.Size = new System.Drawing.Size(1119, 425);
            ((System.ComponentModel.ISupportInitialize)(this.userCoverPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserProfileImage userProfileImage;
        private System.Windows.Forms.PictureBox userCoverPhoto;
        private System.Windows.Forms.Label labelUserName;
        private UserProfileImage pictureboxLoggedUserImage;
        private LoadingPanel loadingPanel;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonParty;
    }
}
