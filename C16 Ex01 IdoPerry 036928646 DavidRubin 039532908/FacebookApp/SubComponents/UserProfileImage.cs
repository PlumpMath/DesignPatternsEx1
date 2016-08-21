using System.Windows.Forms;
using System.ComponentModel;

using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
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

        private void pictureBoxUserImage_Click(object sender, System.EventArgs e)
        {
            OnClick(e);
        }

        public void LoadUserImage(User i_User)
        {
            string targetUrl = GetTargetUrl(i_User);

            // load
            pictureBoxUserImage.LoadAsync(targetUrl);
            pictureBoxUserImage.LoadCompleted += pictureBoxUserImage_LoadCompleted;
        }

        private void pictureBoxUserImage_LoadCompleted(object i_Sender, AsyncCompletedEventArgs i_E)
        {
            if (LoadCompleted != null)
            {
                LoadCompleted.Invoke(this, i_E);
            }
        }

        /// <summary>
        /// Gets a user and returns the image url according to component size
        /// </summary>
        /// <param name="i_User"></param>
        /// <returns></returns>
        private string GetTargetUrl(User i_User)
        {
            string targetUrl;

            if (Size.Width < 50)
            {
                targetUrl = i_User.PictureSmallURL;
            }
            else if (Size.Width < 100)
            {
                targetUrl = i_User.PictureNormalURL;
            }
            else
            {
                targetUrl = i_User.PictureLargeURL;
            }

            return targetUrl;
        }
    }
}
