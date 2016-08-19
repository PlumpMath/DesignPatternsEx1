namespace FacebookApp
{
    partial class FormApp
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
            this.loadingPanel1 = new FacebookApp.LoadingPanel();
            this.profilePage = new FacebookApp.ProfilePage();
            this.SuspendLayout();
            // 
            // loadingPanel1
            // 
            this.loadingPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingPanel1.AnimationSpeed = 12;
            this.loadingPanel1.CurrentActiveSquare = 1;
            this.loadingPanel1.Location = new System.Drawing.Point(259, 143);
            this.loadingPanel1.MaximumSize = new System.Drawing.Size(187, 72);
            this.loadingPanel1.MinimumSize = new System.Drawing.Size(187, 72);
            this.loadingPanel1.Name = "loadingPanel1";
            this.loadingPanel1.Size = new System.Drawing.Size(187, 72);
            this.loadingPanel1.TabIndex = 1;
            // 
            // profilePage
            // 
            this.profilePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage.Location = new System.Drawing.Point(0, 0);
            this.profilePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(699, 679);
            this.profilePage.TabIndex = 0;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 679);
            this.Controls.Add(this.loadingPanel1);
            this.Controls.Add(this.profilePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormApp";
            this.Text = "Awsome Facebook App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ProfilePage profilePage;
        private LoadingPanel loadingPanel1;

    }
}

