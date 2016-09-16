using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    using FacebookApp.Builder;

    public partial class PostsList : UserControl
    {
        private readonly List<Post.eType> m_PostTypeWhiteList = new List<Post.eType>()
                                                                    {
                                                                        Post.eType.status,
                                                                        Post.eType.photo
                                                                    };

        private List<PostView> m_CurrentlyDesplayedPosts = new List<PostView>();
        private User m_User;

        private delegate void PostsLoadedDelegate(FacebookObjectCollection<Post> i_UserPosts);
        public event UserChangedDelegate UserClicked;

        public PostsList()
        {
            InitializeComponent();
        }

        public void ShowUserPosts(User i_User)
        {
            m_User = i_User;
            new Thread(LoadPosts).Start();
        }

        private void PopuplatePosts(FacebookObjectCollection<Post> i_UserPosts)
        {
            // Create post view for each one of the posts starting with the newest
            for (int i = i_UserPosts.Count - 1; i >= 0; i--)
            {
                Post post = i_UserPosts[i];

                // Add only posts from the whitelist types
                if (m_PostTypeWhiteList.IndexOf(post.Type.Value) != -1)
                {
                    // only add posts with pics or mesasge
                    if (post.Message != null || post.PictureURL != null)
                    {
                        PostView postViewToAddToList = PostsViewDirector.Construct(post);
                        postViewToAddToList.UserClicked += PostViewToAddToListOnUserClicked;
                        Controls.Add(postViewToAddToList);
                        m_CurrentlyDesplayedPosts.Add(postViewToAddToList);
                    }
                }
            }

        }

        private void LoadPosts()
        {
            FacebookObjectCollection<Post> userPosts = m_User.WallPosts;
            BeginInvoke(new PostsLoadedDelegate(PopuplatePosts), userPosts);
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
            // only the top two
            for (int i = m_CurrentlyDesplayedPosts.Count - 1; i > m_CurrentlyDesplayedPosts.Count - 4; i--)
            {
                PostView currentlyDesplayedPost = m_CurrentlyDesplayedPosts[i];
                currentlyDesplayedPost.Commencepparty();
            }
        }
    }
}
