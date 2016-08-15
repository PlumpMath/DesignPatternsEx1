namespace FacebookApp
{
    partial class ProfilePage
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new FacebookApp.TopPanel();
            this.leftPanel = new FacebookApp.LeftPanel();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(156, 207);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(528, 858);
            this.mainPanel.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.Location = new System.Drawing.Point(6, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(684, 198);
            this.topPanel.TabIndex = 1;
            this.topPanel.Load += new System.EventHandler(this.topPanel_Load);
            // 
            // leftPanel
            // 
            this.leftPanel.Location = new System.Drawing.Point(0, 207);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 859);
            this.leftPanel.TabIndex = 0;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(690, 653);
            this.ResumeLayout(false);

        }

        #endregion

        private LeftPanel leftPanel;
        private TopPanel topPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}
