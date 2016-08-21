using System.Windows.Forms;
using System.Diagnostics;

using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    public partial class FeedView : UserControl
    {
        private bool m_IsSelfFeed = false;
        private User m_User = null;

        public event UserChangedDelegate UserClicked;

        public FeedView()
        {
            InitializeComponent();
        }

        public void ShowUser(User i_User)
        {
            m_User = i_User;
            m_IsSelfFeed = i_User == FormApp.m_LoggedInUser;
            InitCommentBox();
            InitPostsList();
        }

        private void InitPostsList()
        {
            postsList.ShowUserPosts(m_User);
            postsList.UserClicked += postsList_UserClicked;
        }

        private void postsList_UserClicked(User i_User)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(i_User);
            }
        }

        private void InitCommentBox()
        {
            eCommentBoxType commentType = m_IsSelfFeed ? eCommentBoxType.WallSelf : eCommentBoxType.WallUser;
            commentBox.Type = commentType;

            // comment should always be of the current user
            commentBox.ShowUser(FormApp.m_LoggedInUser);
            commentBox.CommentSubmit += CommentBoxOnCommentSubmit;
        }

        private void CommentBoxOnCommentSubmit(string i_CommentText)
        {
            m_User.PostStatus(i_CommentText);
            Debug.Print(i_CommentText);
        }

        public void CommenceParty()
        {
            postsList.CommenceParty();
        }
    }
}
