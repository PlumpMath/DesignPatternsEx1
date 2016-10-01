using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookApp.Interfaces;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class GridAlbum : IGridItem
    {
        private readonly Album r_Album;

        public GridAlbum(Album i_Album)
        {
            r_Album = i_Album;
        }

        public Image ImageThumb
        {
            get
            {
                return r_Album.ImageSmall;
            }
        }

        public Image ImageLarge
        {
            get
            {
                return r_Album.ImageAlbum;
            }
        }
    }
}