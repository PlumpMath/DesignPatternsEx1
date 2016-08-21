using System.Windows.Forms;

using FacebookWrapper.ObjectModel;

using System.Collections.Generic;

namespace FacebookApp.SubComponents
{
    public partial class PostsList : UserControl
    {
        private readonly List<Post.eType> m_PostTypeWhiteList = new List<Post.eType>()
                                                                    {
                                                                        Post.eType.status,
                                                                        Post.eType.photo
                                                                    };
        private List<PostView> m_CurrentlyDesplayedPosts = new List<PostView>();

        public event UserChangedDelegate UserClicked;

        public PostsList()
        {
            InitializeComponent();
        }

        public void ShowUserPosts(User i_User)
        {
            FacebookObjectCollection<Post> userPosts = i_User.WallPosts;

            //Create post view for each one of the posts starting with the newest
            for (int i = userPosts.Count - 1; i >= 0; i--)
            {
                Post post = userPosts[i];

                //Add only posts from the whitelist types
                if (m_PostTypeWhiteList.IndexOf(post.Type.Value) != -1)
                {
                    //only add posts with pics or mesasge
                    if (post.Message != null || post.PictureURL != null)
                    {
                        PostView postViewToAddToList = new PostView(post);
                        postViewToAddToList.Dock = DockStyle.Top;
                        postViewToAddToList.Padding = new Padding(0, 15, 0, 0);
                        postViewToAddToList.UserClicked += PostViewToAddToListOnUserClicked;
                        Controls.Add(postViewToAddToList);
                        m_CurrentlyDesplayedPosts.Add(postViewToAddToList);
                    }
                }
            }
        }

        private void PostViewToAddToListOnUserClicked(User i_User)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(i_User);
            }
        }

        public void CommenceParty()
        {
            //only the top two
            int maxDancers = 2;
            for (int i = m_CurrentlyDesplayedPosts.Count - 1; i > m_CurrentlyDesplayedPosts.Count - 4; i--)
            {
                PostView currentlyDesplayedPost = m_CurrentlyDesplayedPosts[i];
                currentlyDesplayedPost.Commencepparty();
            }
        }
    }
}
