using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookApp.Interfaces;
using FacebookApp.Properties;

using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class LeftPanel : UserControl
    {
        private const int k_NumberOfItemsPerLevel = 2;
        private const string k_Albums = "Albums";
        private const string k_Friends = "Friends";

        public LeftPanel()
        {
            InitializeComponent();
        }

        public void init(User i_User)
        {
            userInfo.Init(i_User);
            initAlbums(i_User);
            initFriends(i_User);
        }

        private void initFriends(User i_User)
        {
            gridPictureBoxesWithTitleAlbums.GridColumns = gridPictureBoxesWithTitleAlbums.GridRows = k_NumberOfItemsPerLevel;
            gridPictureBoxesWithTitleAlbums.TitleIamge = Resources.Albums;
            gridPictureBoxesWithTitleAlbums.TitleText = k_Friends;
            List<IGridItem> gridItems = getAlbumGridItems(i_User);
            gridPictureBoxesWithTitleAlbums.Init(gridItems);
        }

        private void initAlbums(User i_User)
        {
            gridPictureBoxesWithTitleFriends.GridColumns = gridPictureBoxesWithTitleFriends.GridRows = k_NumberOfItemsPerLevel;
            gridPictureBoxesWithTitleFriends.TitleIamge = Resources.Friends;
            gridPictureBoxesWithTitleFriends.TitleText = k_Albums;
            List<IGridItem> gridItems = getFriendsGridItems(i_User);
            gridPictureBoxesWithTitleFriends.Init(gridItems);
        }

        private List<IGridItem> getFriendsGridItems(User i_User)
        {
            List<IGridItem> images = new List<IGridItem>();
            if (i_User.Friends != null)
            {
                foreach (User user in i_User.Friends)
                {
                    images.Add(new GridUser(user));
                }
            }

            return images;
        }

        private List<IGridItem> getAlbumGridItems(User i_User)
        {
            List<IGridItem> images = new List<IGridItem>();
            if (i_User.Albums != null)
            {
                foreach (Album album in i_User.Albums)
                {
                    images.Add(new GridAlbum(album));
                }
            }

            return images;
        }
    }
}