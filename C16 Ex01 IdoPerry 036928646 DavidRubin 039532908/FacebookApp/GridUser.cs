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

        public Image GetImage()
        {
            return r_User.ImageSmall;
        }

        public User GetUser()
        {
            return r_User;
        }
    }
}
