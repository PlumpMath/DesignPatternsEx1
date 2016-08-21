using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookApp.Interfaces;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    class GridUser : IGridItem
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
