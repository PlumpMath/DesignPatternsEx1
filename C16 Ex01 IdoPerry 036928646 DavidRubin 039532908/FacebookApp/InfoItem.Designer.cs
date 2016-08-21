namespace FacebookApp
{
    public partial class InfoItem
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
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.White;
            this.pictureBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxInfo.TabIndex = 0;
            this.pictureBoxInfo.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(37, 7);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 20);
            this.labelInfo.TabIndex = 1;
            // 
            // InfoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureBoxInfo);
            this.Name = "InfoItem";
            this.Size = new System.Drawing.Size(191, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.Label labelInfo;
    }
}
