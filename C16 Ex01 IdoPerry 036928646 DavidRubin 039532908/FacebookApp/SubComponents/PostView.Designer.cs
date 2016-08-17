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
            this.postActions = new FacebookApp.SubComponents.PostActions();
            this.postDetails = new FacebookApp.SubComponents.PostDetails();
            this.SuspendLayout();
            // 
            // labelPostMessage
            // 
            this.labelPostMessage.AutoSize = true;
            this.labelPostMessage.Location = new System.Drawing.Point(4, 68);
            this.labelPostMessage.Name = "labelPostMessage";
            this.labelPostMessage.Size = new System.Drawing.Size(35, 13);
            this.labelPostMessage.TabIndex = 2;
            this.labelPostMessage.Text = "label1";
            // 
            // postActions
            // 
            this.postActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postActions.Location = new System.Drawing.Point(0, 155);
            this.postActions.Name = "postActions";
            this.postActions.Size = new System.Drawing.Size(471, 63);
            this.postActions.TabIndex = 4;
            // 
            // postDetails
            // 
            this.postDetails.Location = new System.Drawing.Point(3, 3);
            this.postDetails.Name = "postDetails";
            this.postDetails.Size = new System.Drawing.Size(441, 59);
            this.postDetails.TabIndex = 3;
            // 
            // PostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.postActions);
            this.Controls.Add(this.postDetails);
            this.Controls.Add(this.labelPostMessage);
            this.Name = "PostView";
            this.Size = new System.Drawing.Size(471, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPostMessage;
        private PostDetails postDetails;
        private PostActions postActions;
    }
}
