using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public partial class PostView : UserControl
    {
        private Post m_post;

        public event UserChangedDelegate UserClicked;

        public PostView(Post i_post)
        {
            InitializeComponent();
            m_post = i_post;
            InitPost();
        }

        private void InitPost()
        {
            InitPostDetails();
            InitPostBody();
            InitPostActions();
            labelPostMessage.Text = m_post.Message;
        }

        /// <summary>
        /// Post Actions include like,comment and share
        /// </summary>
        private void InitPostActions()
        {
            postActions.Init(m_post);
        }

        /// <summary>
        /// Post body will change according to post type
        /// could be picture video, link or just textual post
        /// NOTE - RIGHT NOW WE ARE NOT SUPPORTING VIDEO POSTS
        /// </summary>
        private void InitPostBody()
        {
            //if post don't have message then remove message
            if (m_post.Message == null)
            {
                Controls.Remove(labelPostMessage);
            }
            else
            {
                labelPostMessage.Text = m_post.Message;
            }

            //if post dont have a photo then remove photo
            if (m_post.PictureURL == null)
            {
                Controls.Remove(pictureBoxPostPhoto);
            }
            else
            {
                pictureBoxPostPhoto.LoadAsync(m_post.PictureURL);
            }

            UpdateSize();
        }

        /// <summary>
        /// Set component size according to sub components sizes
        /// </summary>
        private void UpdateSize()
        {
            int newSize = postDetails.Size.Height;
            newSize += 40; //spacing
            newSize += postActions.Size.Height;

            if (Controls.Contains(labelPostMessage))
            {
                newSize += labelPostMessage.Size.Height;
            }

            if (Controls.Contains(pictureBoxPostPhoto))
            {
                //change picture to its actual size
                int height = (int)pictureBoxPostPhoto.Image.HorizontalResolution;
                pictureBoxPostPhoto.Size = new Size(pictureBoxPostPhoto.Size.Width, height);
                newSize += pictureBoxPostPhoto.Size.Height;
            }

            Size sizeObj = new Size(Size.Width, newSize);
            this.Size = sizeObj;
        }

        /// <summary>
        /// Post details include who posted this and how long ago
        /// </summary>
        private void InitPostDetails()
        {
            postDetails.LoadDetailsFromPost(m_post);
            postDetails.UserClicked += postDetails_UserClicked;
        }

        void postDetails_UserClicked(User i_User)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(i_User);
            }
        }
    }
}
