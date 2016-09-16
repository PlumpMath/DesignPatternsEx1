namespace FacebookApp.SubComponents
{
    partial class PostBody
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPostMessage
            // 
            this.labelPostMessage.AutoSize = true;
            this.labelPostMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPostMessage.Location = new System.Drawing.Point(0, 0);
            this.labelPostMessage.Name = "labelPostMessage";
            this.labelPostMessage.Size = new System.Drawing.Size(72, 13);
            this.labelPostMessage.TabIndex = 13;
            this.labelPostMessage.Text = "post message";
            // 
            // pictureBoxPostPhoto
            // 
            this.pictureBoxPostPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxPostPhoto.Location = new System.Drawing.Point(0, 13);
            this.pictureBoxPostPhoto.Name = "pictureBoxPostPhoto";
            this.pictureBoxPostPhoto.Size = new System.Drawing.Size(381, 183);
            this.pictureBoxPostPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPostPhoto.TabIndex = 14;
            this.pictureBoxPostPhoto.TabStop = false;
            // 
            // PostBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.pictureBoxPostPhoto);
            this.Controls.Add(this.labelPostMessage);
            this.Name = "PostBody";
            this.Size = new System.Drawing.Size(381, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPostPhoto;
        private System.Windows.Forms.Label labelPostMessage;
    }
}
