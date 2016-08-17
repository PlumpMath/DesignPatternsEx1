using System.Windows.Forms;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    using System.Collections.Generic;

    public partial class PostsList : UserControl
    {
        private readonly List<Post.eType> m_postTypeWhiteList = new List<Post.eType>() { Post.eType.status, Post.eType.photo };

        public PostsList()
        {
            InitializeComponent();
        }

        public void ShowUserPosts(User i_user)
        {
            FacebookObjectCollection<Post> userPosts = i_user.Posts;

            //Create post view for each one of the posts starting with the newest
            for (int i = userPosts.Count -1 ; i >= 0  ; i--)
            {
                Post post = userPosts[i];

                //Add only posts from the whitelist types
                if (m_postTypeWhiteList.IndexOf(post.Type.Value) != -1)
                {
                    PostView postViewToAddToList = new PostView(post);
                    postViewToAddToList.Dock = DockStyle.Top;
                    postViewToAddToList.Padding = new Padding(0,15,0,0);
                    Controls.Add(postViewToAddToList);      
                }
            }
        }
    }
}
