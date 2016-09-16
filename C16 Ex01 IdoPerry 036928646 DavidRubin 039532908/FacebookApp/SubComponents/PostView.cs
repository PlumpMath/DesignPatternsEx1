using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    public partial class PostView : UserControl
    {
        private Post m_Post;

        public event UserChangedDelegate UserClicked;

        public PostView(Post i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;
            InitPost();
        }

        private void InitPost()
        {
            InitPostDetails();
            InitPostBody();
            InitPostActions();
        }

        /// <summary>
        /// Post Actions include like,comment and share
        /// </summary>
        private void InitPostActions()
        {
            //postActions.Init(m_Post);
        }

        /// <summary>
        /// Post body will change according to post type
        /// could be picture video, link or just textual post
        /// NOTE - RIGHT NOW WE ARE NOT SUPPORTING VIDEO POSTS
        /// </summary>
        private void InitPostBody()
        {
            //UpdateSize();
        }

        /// <summary>
        /// Post details include who posted this and how long ago
        /// </summary>
        private void InitPostDetails()
        {
            //postDetails.UserClicked += postDetails_UserClicked;
        }

        private void postDetails_UserClicked(User i_User)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(i_User);
            }
        }

        public void Commencepparty()
        {
//            postDetails.CommenceParty();
            //postActions.CommenceParty();
        }
    }
}
