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
            this.profilePage = new FacebookApp.ProfilePage();
            this.SuspendLayout();
            // 
            // profilePage
            // 
            this.profilePage.Location = new System.Drawing.Point(-2, 0);
            this.profilePage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(1094, 1040);
            this.profilePage.TabIndex = 0;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 1045);
            this.Controls.Add(this.profilePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormApp";
            this.Text = "Awsome Facebook App";
            this.ResumeLayout(false);

        }

        #endregion

        private ProfilePage profilePage;

    }
}

