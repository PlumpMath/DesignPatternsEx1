using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

using FacebookApp.Interfaces;
using FacebookApp.Properties;

using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public delegate void UserChangedDelegate(User i_NewUser);

    public partial class LeftPanel : UserControl
    {
        private const int k_NumberOfItemsPerLevel = 2;

        private const string k_Albums = "Albums";

        private const string k_Friends = "Friends";
        private User m_User;

        public event UserChangedDelegate UserChanged;

        private delegate void OnAlbumsLoadedDelagaet(FacebookObjectCollection<Album> i_Albums);

        public LeftPanel()
        {
            InitializeComponent();
        }

        public void Init(User i_User)
        {
            m_User = i_User;
            userInfo.Init(i_User);
            initAlbums();
            //initFriends(i_User);
        }

        private void initFriends(User i_User)
        {
            gridPictureBoxesWithTitleFriends.GridItemClick += friendGridItem_Click;
            gridPictureBoxesWithTitleFriends.GridColumns =
                gridPictureBoxesWithTitleFriends.GridRows = k_NumberOfItemsPerLevel;
            gridPictureBoxesWithTitleFriends.TitleIamge = Resources.Albums;
            gridPictureBoxesWithTitleFriends.TitleText = k_Friends;
            List<IGridItem> gridItems = getFriendsGridItems(i_User);
            gridPictureBoxesWithTitleFriends.Init(gridItems);
        }
        private void initAlbums()
        {
            gridPictureBoxesWithTitleAlbums.GridColumns =
                gridPictureBoxesWithTitleAlbums.GridRows = k_NumberOfItemsPerLevel;
            gridPictureBoxesWithTitleAlbums.TitleIamge = Resources.Friends;
            gridPictureBoxesWithTitleAlbums.TitleText = k_Albums;
            new Thread(getAlbumGridItems).Start();
            //getAlbumGridItems();
        }

        private void getAlbumGridItems()
        {
            FacebookObjectCollection<Album> albums = m_User.Albums;
            BeginInvoke(new OnAlbumsLoadedDelagaet(LoadAlbumsToGrid), albums);
        }

        private void LoadAlbumsToGrid(FacebookObjectCollection<Album> i_Albums)
        {

            List<IGridItem> images = new List<IGridItem>();
            if (i_Albums != null)
            {
                foreach (Album album in i_Albums)
                {
                    images.Add(new GridAlbum(album));
                }
            }

            gridPictureBoxesWithTitleAlbums.Init(images);
        }

        private void friendGridItem_Click(object i_Sender, EventArgs i_E)
        {
            if (i_Sender is GridUser)
            {
                User selectedUser = ((GridUser)i_Sender).GetUser();
                if (UserChanged != null)
                {
                    UserChanged(selectedUser);
                }
            }
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

        public void CommenceParty()
        {
        }
    }
}