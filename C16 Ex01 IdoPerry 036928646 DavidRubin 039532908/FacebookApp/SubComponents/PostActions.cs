using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    using FacebookWrapper.ObjectModel;

    public partial class PostActions : UserControl
    {
        private Post m_post = null;

        public PostActions()
        {
            InitializeComponent();
        }

        public void Init(Post i_post)
        {
            m_post = i_post;
            commentBoxPostComment.Type = eCommentBoxType.Comment;
            commentBoxPostComment.ShowUser(FormApp.m_LoggedInUser);
            commentBoxPostComment.CommentSubmit += commentBoxPostComment_CommentSubmit;
        }

        void commentBoxPostComment_CommentSubmit(string i_CommentText)
        {
            m_post.Comment(i_CommentText);
        }
    }
}
