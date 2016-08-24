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
            this.labelPostMessage.Location = new System.Drawing.Point(0, 91);
            this.labelPostMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostMessage.Name = "labelPostMessage";
            this.labelPostMessage.Size = new System.Drawing.Size(109, 20);
            this.labelPostMessage.TabIndex = 11;
            this.labelPostMessage.Text = "post message";
            // 
            // pictureBoxPostPhoto
            // 
            this.pictureBoxPostPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxPostPhoto.Location = new System.Drawing.Point(0, 111);
            this.pictureBoxPostPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPostPhoto.Name = "pictureBoxPostPhoto";
            this.pictureBoxPostPhoto.Size = new System.Drawing.Size(706, 626);
            this.pictureBoxPostPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPostPhoto.TabIndex = 12;
            this.pictureBoxPostPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 855);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 3);
            this.panel1.TabIndex = 13;
            // 
            // postActions
            // 
            this.postActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postActions.Location = new System.Drawing.Point(0, 746);
            this.postActions.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.postActions.Name = "postActions";
            this.postActions.Size = new System.Drawing.Size(706, 109);
            this.postActions.TabIndex = 14;
            // 
            // postDetails
            // 
            this.postDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.postDetails.Location = new System.Drawing.Point(0, 0);
            this.postDetails.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.postDetails.Name = "postDetails";
            this.postDetails.Size = new System.Drawing.Size(706, 91);
            this.postDetails.TabIndex = 3;
            // 
            // PostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.postActions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPostPhoto);
            this.Controls.Add(this.labelPostMessage);
            this.Controls.Add(this.postDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 23, 4, 5);
            this.Name = "PostView";
            this.Size = new System.Drawing.Size(706, 858);
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
