using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    using FacebookWrapper.ObjectModel;

    public partial class PostBody : UserControl
    {
        public PostBody()
        {
            InitializeComponent();
        }

        public void Init(Post i_Post)
        {
            // if post don't have message then remove message
            if (i_Post.Message == null)
            {
                Controls.Remove(labelPostMessage);
            }
            else
            {
                labelPostMessage.Text = i_Post.Message;
            }
            
            // if post dont have a photo then remove photo
            if (i_Post.PictureURL == null)
            {
                Controls.Remove(pictureBoxPostPhoto);
            }
            else
            {
                pictureBoxPostPhoto.LoadAsync(i_Post.PictureURL);
            }
        }
    }
}
