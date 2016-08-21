using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public class UserStatistics
    {
        public Post MostLikedPost { get; set; }

        public int TotalNumberOfLikes { get; set; }

        public int MostLikedPostLikeCount { get; set; }

        public Album MostLikedAlbum { get; set; }

        public Photo MostLikedPhoto { get; set; }

        public int MostLikedAlbumLikeCount { get; set; }

        public int MostLikedPhotoLikeCount { get; set; }
    }
}