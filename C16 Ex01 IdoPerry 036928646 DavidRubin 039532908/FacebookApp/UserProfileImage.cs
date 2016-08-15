using System.Windows.Forms;

namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public partial class UserProfileImage : PictureBox
    {
        public UserProfileImage()
        {
            InitializeComponent();
        }

        public void LoadUserImage(User i_User)
        {
            //define which size is it
            //load
            LoadAsync(i_User.PictureLargeURL);
        }
    }
}
