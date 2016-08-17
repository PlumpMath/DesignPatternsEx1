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
        private const int k_MaxNumberOfGridItems = 9;

        private const string k_Albums = "Albums";

        public LeftPanel()
        {
            InitializeComponent();
        }

        public void init(User i_user)
        {
            userInfo.Init(i_user);
            initAlbums(i_user);
        }

        private void initAlbums(User i_user)
        {
            gridPictureBoxesWithTitleAlbums.GridColumns = gridPictureBoxesWithTitleAlbums.GridRows = 2;
            gridPictureBoxesWithTitleAlbums.TitleIamge = Resources.Albums;
            gridPictureBoxesWithTitleAlbums.TitleText = k_Albums;
            List<IGridItem> gridItems = getAlbumGridItems(i_user);
            gridPictureBoxesWithTitleAlbums.Init(gridItems);
        }

        private List<IGridItem> getAlbumGridItems(User i_User)
        {
            List<IGridItem> images = new List<IGridItem>(k_MaxNumberOfGridItems);
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