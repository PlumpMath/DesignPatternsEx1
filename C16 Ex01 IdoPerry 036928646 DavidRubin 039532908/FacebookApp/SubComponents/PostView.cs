using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    public partial class PostView : UserControl
    {
        private Post m_Post;

        public event UserChangedDelegate UserClicked;

        public PostView(Post i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;
            InitPost();
        }

        private void InitPost()
        {
            InitPostDetails();
            InitPostBody();
            InitPostActions();
            labelPostMessage.Text = m_Post.Message;
        }

        /// <summary>
        /// Post Actions include like,comment and share
        /// </summary>
        private void InitPostActions()
        {
            postActions.Init(m_Post);
        }

        /// <summary>
        /// Post body will change according to post type
        /// could be picture video, link or just textual post
        /// NOTE - RIGHT NOW WE ARE NOT SUPPORTING VIDEO POSTS
        /// </summary>
        private void InitPostBody()
        {
            // if post don't have message then remove message
            if (m_Post.Message == null)
            {
                Controls.Remove(labelPostMessage);
            }
            else
            {
                labelPostMessage.Text = m_Post.Message;
            }

            // if post dont have a photo then remove photo
            if (m_Post.PictureURL == null)
            {
                Controls.Remove(pictureBoxPostPhoto);
            }
            else
            {
                pictureBoxPostPhoto.LoadAsync(m_Post.PictureURL);
            }

            UpdateSize();
        }

        /// <summary>
        /// Set component size according to sub components sizes
        /// </summary>
        private void UpdateSize()
        {
            int newSize = postDetails.Size.Height;
            newSize += 40; // spacing
            newSize += postActions.Size.Height;

            if (Controls.Contains(labelPostMessage))
            {
                newSize += labelPostMessage.Size.Height;
            }

            if (Controls.Contains(pictureBoxPostPhoto))
            {
                // change picture to its actual size
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
            postDetails.LoadDetailsFromPost(m_Post);
            postDetails.UserClicked += postDetails_UserClicked;
        }

        private void postDetails_UserClicked(User i_User)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(i_User);
            }
        }

        public void Commencepparty()
        {
            postDetails.CommenceParty();
            postActions.CommenceParty();
        }
    }
}
