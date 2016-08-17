namespace FacebookApp.SubComponents
{
    partial class PostView
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
            this.labelPostMessage = new System.Windows.Forms.Label();
            this.pictureBoxPostPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.postActions = new FacebookApp.SubComponents.PostActions();
            this.postDetails = new FacebookApp.SubComponents.PostDetails();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPostMessage
            // 
            this.labelPostMessage.AutoSize = true;
            this.labelPostMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPostMessage.Location = new System.Drawing.Point(0, 59);
            this.labelPostMessage.Name = "labelPostMessage";
            this.labelPostMessage.Size = new System.Drawing.Size(72, 13);
            this.labelPostMessage.TabIndex = 11;
            this.labelPostMessage.Text = "post message";
            // 
            // pictureBoxPostPhoto
            // 
            this.pictureBoxPostPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxPostPhoto.Location = new System.Drawing.Point(0, 72);
            this.pictureBoxPostPhoto.Name = "pictureBoxPostPhoto";
            this.pictureBoxPostPhoto.Size = new System.Drawing.Size(471, 407);
            this.pictureBoxPostPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPostPhoto.TabIndex = 12;
            this.pictureBoxPostPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 2);
            this.panel1.TabIndex = 13;
            // 
            // postActions
            // 
            this.postActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postActions.Location = new System.Drawing.Point(0, 483);
            this.postActions.Name = "postActions";
            this.postActions.Size = new System.Drawing.Size(471, 45);
            this.postActions.TabIndex = 14;
            // 
            // postDetails
            // 
            this.postDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.postDetails.Location = new System.Drawing.Point(0, 0);
            this.postDetails.Name = "postDetails";
            this.postDetails.Size = new System.Drawing.Size(471, 59);
            this.postDetails.TabIndex = 3;
            // 
            // PostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.postActions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPostPhoto);
            this.Controls.Add(this.labelPostMessage);
            this.Controls.Add(this.postDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.Name = "PostView";
            this.Size = new System.Drawing.Size(471, 530);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PostDetails postDetails;
        private System.Windows.Forms.Label labelPostMessage;
        private System.Windows.Forms.PictureBox pictureBoxPostPhoto;
        private System.Windows.Forms.Panel panel1;
        private PostActions postActions;
    }
}
