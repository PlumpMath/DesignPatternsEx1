using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            gridPictureBoxesWithTitleAlbums.GridColumns = gridPictureBoxesWithTitleAlbums.GridRows = 3;
            gridPictureBoxesWithTitleAlbums.TitleIamge = Resources.Albums;
            gridPictureBoxesWithTitleAlbums.TitleText = k_Albums;
            List<Image> images = getAlbumImages(i_user);
            gridPictureBoxesWithTitleAlbums.Init(images);
        }

        private List<Image> getAlbumImages(User i_User)
        {
            List<Image> images = new List<Image>(k_MaxNumberOfGridItems);
            if (i_User.Albums != null)
            {
                foreach (Album album in i_User.Albums)
                {
                    images.Add(new Bitmap(album.ImageAlbum));
                }
            }

            return images;
        }
    }
}