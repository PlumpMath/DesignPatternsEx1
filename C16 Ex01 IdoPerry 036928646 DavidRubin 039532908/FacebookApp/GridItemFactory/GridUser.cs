using System.Drawing;

using FacebookApp.Interfaces;

using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class GridUser : IGridItem
    {
        private readonly User r_User;

        public GridUser(User i_User)
        {
            r_User = i_User;
        }

        public Image ImageThumb
        {
            get
            {
                return r_User.ImageSmall;
            }
        }

        public Image ImageLarge
        {
            get
            {
                return r_User.ImageLarge;
            }
        }

        public User GetUser()
        {
            return r_User;
        }
    }
}