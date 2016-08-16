using System.Windows.Forms;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    public partial class PostsList : UserControl
    {
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
                PostView postViewToAddToList = new PostView(post);
                postViewToAddToList.Dock = DockStyle.Top;
                Controls.Add(postViewToAddToList);   
            }
        }
    }
}
