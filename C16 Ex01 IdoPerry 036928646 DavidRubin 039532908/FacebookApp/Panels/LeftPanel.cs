using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

using FacebookApp.Interfaces;
using FacebookApp.Properties;

using FacebookWrapper.ObjectModel;
using FacebookApp.GridItemFactory;

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

        private delegate void OnAlbumsLoadedDelagate(FacebookObjectCollection<Album> i_Albums);
        private delegate void OnFriendsLoadedDelagate(FacebookObjectCollection<User> i_Friends);

        public LeftPanel()
        {
            InitializeComponent();
        }

        public void Init(User i_User)
        {
            m_User = i_User;
            userInfo.Init(i_User);
            initAlbums();
            initFriends();
        }

        private void initFriends()
        {
            gridPictureBoxesWithTitleFriends.GridItemClick += friendGridItem_Click;
            gridPictureBoxesWithTitleFriends.GridColumns =
                gridPictureBoxesWithTitleFriends.GridRows = k_NumberOfItemsPerLevel;
            gridPictureBoxesWithTitleFriends.TitleIamge = Resources.Albums;
            gridPictureBoxesWithTitleFriends.TitleText = k_Friends;
            new Thread(getFriendsGridItems).Start();
        }
        private void initAlbums()
        {
            gridPictureBoxesWithTitleAlbums.GridColumns =
                gridPictureBoxesWithTitleAlbums.GridRows = k_NumberOfItemsPerLevel;
            gridPictureBoxesWithTitleAlbums.TitleIamge = Resources.Friends;
            gridPictureBoxesWithTitleAlbums.TitleText = k_Albums;
            new Thread(getAlbumGridItems).Start();
        }

        private void getAlbumGridItems()
        {
            FacebookObjectCollection<Album> albums = m_User.Albums;
            BeginInvoke(new OnAlbumsLoadedDelagate(LoadAlbumsToGrid), albums);
        }

        private void LoadAlbumsToGrid(FacebookObjectCollection<Album> i_Albums)
        {

            List<IGridItem> images = GirdItemsFactory.CreateGirdItems(i_Albums);
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


        private void getFriendsGridItems()
        {
            FacebookObjectCollection<User> friends = m_User.Friends;
            BeginInvoke(new OnFriendsLoadedDelagate(PopulateFriendsGrid),friends);
            
        }

        private void PopulateFriendsGrid(FacebookObjectCollection<User> i_Friends)
        {

            List<IGridItem> images = GirdItemsFactory.CreateGirdItems(i_Friends);

            gridPictureBoxesWithTitleFriends.Init(images);
        }
    }
}