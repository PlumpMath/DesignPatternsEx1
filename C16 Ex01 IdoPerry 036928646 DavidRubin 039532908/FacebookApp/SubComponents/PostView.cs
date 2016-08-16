using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{

    public partial class PostView : UserControl
    {
        private Post m_post;

        public PostView(Post i_post)
        {
            InitializeComponent();
            m_post = i_post;
            InitPost();
        }

        private void InitPost()
        {
            InitPostDetails();
            InitPostBody();
            InitPostActions();
            labelPostMessage.Text = m_post.Message;
        }

        /// <summary>
        /// Post Actions include like,comment and share
        /// </summary>
        private void InitPostActions()
        {
            postActions.Init(m_post);
        }

        /// <summary>
        /// Post body will change according to post type
        /// could be picture video, link or just textual post
        /// NOTE - RIGHT NOW WE ARE NOT SUPPORTING VIDEO POSTS
        /// </summary>
        private void InitPostBody()
        {
            
        }

        /// <summary>
        /// Post details include who posted this and how long ago
        /// </summary>
        private void InitPostDetails()
        {
            postDetails.LoadDetailsFromPost(m_post);
        }
    }
}
