namespace FacebookApp
{
    partial class LeftPanel
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
            this.userInfo = new FacebookApp.UserInfo();
            this.gridPictureBoxesWithTitleAlbums = new FacebookApp.GridPictureBoxesWithTitle();
            this.gridPictureBoxesWithTitleFriends = new FacebookApp.GridPictureBoxesWithTitle();
            this.SuspendLayout();
            // 
            // userInfo
            // 
            this.userInfo.BackColor = System.Drawing.Color.White;
            this.userInfo.Location = new System.Drawing.Point(3, 0);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(487, 306);
            this.userInfo.TabIndex = 0;
            // 
            // gridPictureBoxesWithTitleAlbums
            // 
            this.gridPictureBoxesWithTitleAlbums.BackColor = System.Drawing.Color.White;
            this.gridPictureBoxesWithTitleAlbums.GridColumns = 0;
            this.gridPictureBoxesWithTitleAlbums.GridRows = 0;
            this.gridPictureBoxesWithTitleAlbums.Location = new System.Drawing.Point(2, 312);
            this.gridPictureBoxesWithTitleAlbums.Name = "gridPictureBoxesWithTitleAlbums";
            this.gridPictureBoxesWithTitleAlbums.Size = new System.Drawing.Size(489, 331);
            this.gridPictureBoxesWithTitleAlbums.TabIndex = 1;
            // 
            // gridPictureBoxesWithTitleFriends
            // 
            this.gridPictureBoxesWithTitleFriends.BackColor = System.Drawing.Color.White;
            this.gridPictureBoxesWithTitleFriends.GridColumns = 0;
            this.gridPictureBoxesWithTitleFriends.GridRows = 0;
            this.gridPictureBoxesWithTitleFriends.Location = new System.Drawing.Point(1, 643);
            this.gridPictureBoxesWithTitleFriends.Name = "gridPictureBoxesWithTitleFriends";
            this.gridPictureBoxesWithTitleFriends.Size = new System.Drawing.Size(489, 331);
            this.gridPictureBoxesWithTitleFriends.TabIndex = 2;
            // 
            // LeftPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridPictureBoxesWithTitleFriends);
            this.Controls.Add(this.gridPictureBoxesWithTitleAlbums);
            this.Controls.Add(this.userInfo);
            this.Name = "LeftPanel";
            this.Size = new System.Drawing.Size(492, 1120);
            this.ResumeLayout(false);

        }

        #endregion

        private UserInfo userInfo;
        private GridPictureBoxesWithTitle gridPictureBoxesWithTitleAlbums;
        private GridPictureBoxesWithTitle gridPictureBoxesWithTitleFriends;
    }
}
