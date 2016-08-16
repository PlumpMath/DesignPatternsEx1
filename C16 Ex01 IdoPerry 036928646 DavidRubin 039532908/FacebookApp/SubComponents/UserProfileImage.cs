using System.Windows.Forms;

namespace FacebookApp
{
    using System.Drawing;

    using FacebookWrapper.ObjectModel;

    public partial class UserProfileImage : PictureBox
    {
        public UserProfileImage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void LoadUserImage(User i_User)
        {
            string targetUrl = GetTargetUrl(i_User);
            //load
            LoadAsync(targetUrl);
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
