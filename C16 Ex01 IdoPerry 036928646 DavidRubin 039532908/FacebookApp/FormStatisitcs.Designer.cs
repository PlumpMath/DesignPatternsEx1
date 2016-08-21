namespace FacebookApp
{
    partial class FormStatisitcs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalNumberOfLikes = new System.Windows.Forms.Label();
            this.labelMostLikedPostTitle = new System.Windows.Forms.Label();
            this.labelMostLikedPostContent = new System.Windows.Forms.Label();
            this.labelMostLikedAlbumTitle = new System.Windows.Forms.Label();
            this.labelMostLikedPhotoTitle = new System.Windows.Forms.Label();
            this.pictureBoxMostLikedAlbum = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostLikedPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FacebookApp.Properties.Resources.Statistics;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 53);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(92, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistics:";
            // 
            // labelTotalNumberOfLikes
            // 
            this.labelTotalNumberOfLikes.AutoSize = true;
            this.labelTotalNumberOfLikes.Location = new System.Drawing.Point(19, 90);
            this.labelTotalNumberOfLikes.Name = "labelTotalNumberOfLikes";
            this.labelTotalNumberOfLikes.Size = new System.Drawing.Size(194, 20);
            this.labelTotalNumberOfLikes.TabIndex = 2;
            this.labelTotalNumberOfLikes.Text = "Total number of post likes:";
            // 
            // labelMostLikedPostTitle
            // 
            this.labelMostLikedPostTitle.AutoSize = true;
            this.labelMostLikedPostTitle.Location = new System.Drawing.Point(19, 121);
            this.labelMostLikedPostTitle.Name = "labelMostLikedPostTitle";
            this.labelMostLikedPostTitle.Size = new System.Drawing.Size(122, 20);
            this.labelMostLikedPostTitle.TabIndex = 4;
            this.labelMostLikedPostTitle.Text = "Most Liked Post";
            // 
            // labelMostLikedPostContent
            // 
            this.labelMostLikedPostContent.AutoSize = true;
            this.labelMostLikedPostContent.Location = new System.Drawing.Point(19, 152);
            this.labelMostLikedPostContent.Name = "labelMostLikedPostContent";
            this.labelMostLikedPostContent.Size = new System.Drawing.Size(0, 20);
            this.labelMostLikedPostContent.TabIndex = 5;
            // 
            // labelMostLikedAlbumTitle
            // 
            this.labelMostLikedAlbumTitle.AutoSize = true;
            this.labelMostLikedAlbumTitle.Location = new System.Drawing.Point(19, 186);
            this.labelMostLikedAlbumTitle.Name = "labelMostLikedAlbumTitle";
            this.labelMostLikedAlbumTitle.Size = new System.Drawing.Size(129, 20);
            this.labelMostLikedAlbumTitle.TabIndex = 6;
            this.labelMostLikedAlbumTitle.Text = "Most liked Album";
            // 
            // labelMostLikedPhotoTitle
            // 
            this.labelMostLikedPhotoTitle.AutoSize = true;
            this.labelMostLikedPhotoTitle.Location = new System.Drawing.Point(338, 186);
            this.labelMostLikedPhotoTitle.Name = "labelMostLikedPhotoTitle";
            this.labelMostLikedPhotoTitle.Size = new System.Drawing.Size(126, 20);
            this.labelMostLikedPhotoTitle.TabIndex = 7;
            this.labelMostLikedPhotoTitle.Text = "Most liked Photo";
            // 
            // pictureBoxMostLikedAlbum
            // 
            this.pictureBoxMostLikedAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMostLikedAlbum.Location = new System.Drawing.Point(18, 210);
            this.pictureBoxMostLikedAlbum.Name = "pictureBoxMostLikedAlbum";
            this.pictureBoxMostLikedAlbum.Size = new System.Drawing.Size(221, 179);
            this.pictureBoxMostLikedAlbum.TabIndex = 8;
            this.pictureBoxMostLikedAlbum.TabStop = false;
            // 
            // pictureBoxMostLikedPhoto
            // 
            this.pictureBoxMostLikedPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxMostLikedPhoto.Location = new System.Drawing.Point(342, 210);
            this.pictureBoxMostLikedPhoto.Name = "pictureBoxMostLikedPhoto";
            this.pictureBoxMostLikedPhoto.Size = new System.Drawing.Size(221, 179);
            this.pictureBoxMostLikedPhoto.TabIndex = 9;
            this.pictureBoxMostLikedPhoto.TabStop = false;
            // 
            // FormStatisitcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 443);
            this.Controls.Add(this.pictureBoxMostLikedPhoto);
            this.Controls.Add(this.pictureBoxMostLikedAlbum);
            this.Controls.Add(this.labelMostLikedPhotoTitle);
            this.Controls.Add(this.labelMostLikedAlbumTitle);
            this.Controls.Add(this.labelMostLikedPostContent);
            this.Controls.Add(this.labelMostLikedPostTitle);
            this.Controls.Add(this.labelTotalNumberOfLikes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatisitcs";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalNumberOfLikes;
        private System.Windows.Forms.Label labelMostLikedPostTitle;
        private System.Windows.Forms.Label labelMostLikedPostContent;
        private System.Windows.Forms.Label labelMostLikedAlbumTitle;
        private System.Windows.Forms.Label labelMostLikedPhotoTitle;
        private System.Windows.Forms.PictureBox pictureBoxMostLikedAlbum;
        private System.Windows.Forms.PictureBox pictureBoxMostLikedPhoto;
    }
}