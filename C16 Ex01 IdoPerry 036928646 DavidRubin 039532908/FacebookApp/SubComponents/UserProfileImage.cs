using System.Windows.Forms;

namespace FacebookApp
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    using FacebookWrapper.ObjectModel;

    public partial class UserProfileImage : UserControl
    {

        public event AsyncCompletedEventHandler LoadCompleted;

        public UserProfileImage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            pictureBoxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUserImage.Click += pictureBoxUserImage_Click;
        }

        void pictureBoxUserImage_Click(object sender, System.EventArgs e)
        {
            OnClick(e);
        }

        public void LoadUserImage(User i_User)
        {
            string targetUrl = GetTargetUrl(i_User);
            //load
            pictureBoxUserImage.LoadAsync(targetUrl);
            pictureBoxUserImage.LoadCompleted += pictureBoxUserImage_LoadCompleted;
        }

        void pictureBoxUserImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (LoadCompleted != null)
            {
                LoadCompleted(this, e);
            }
        }

        /// <summary>
        /// Gets a user and returns the image url according to component size
        /// </summary>
        /// <param name="i_user"></param>
        /// <returns></returns>
        private string GetTargetUrl(User i_user)
        {
            string targetUrl;

            if (Size.Width < 50)
            {
                targetUrl = i_user.PictureSmallURL;
            }
            else if (Size.Width < 100)
            {
                targetUrl = i_user.PictureNormalURL;
            }
            else
            {
                targetUrl = i_user.PictureLargeURL;
            }

            return targetUrl;
        }
    }
}
