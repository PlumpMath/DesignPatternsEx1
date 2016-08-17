using System;
using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    using FacebookWrapper.ObjectModel;

    public partial class PostActions : UserControl
    {
        private Post m_post = null;
        private bool m_likedByMe = false;

        public PostActions()
        {
            InitializeComponent();
        }

        public void Init(Post i_post)
        {
            m_post = i_post;
            FacebookObjectCollection<User> likedBy = i_post.LikedBy;
            m_likedByMe = likedBy.Contains(FormApp.m_LoggedInUser);
            UpdateLikeButton();
            buttonLike.Click += ButtonLikeOnClick;
            commentBoxPostComment.Type = eCommentBoxType.Comment;
            commentBoxPostComment.ShowUser(FormApp.m_LoggedInUser);
            commentBoxPostComment.CommentSubmit += commentBoxPostComment_CommentSubmit;
        }

        private void ButtonLikeOnClick(object sender, EventArgs eventArgs)
        {
            if (!m_likedByMe)
            {
                m_post.Like();
                m_likedByMe = true;
                UpdateLikeButton();
            }
        }

        private void UpdateLikeButton()
        {
            if (m_likedByMe)
            {
                buttonLike.Enabled = false;
                buttonLike.Text = "liked";
            }
        }

        private void ToggleLikeButton()
        {

        }

        void commentBoxPostComment_CommentSubmit(string i_CommentText)
        {
            m_post.Comment(i_CommentText);
        }
    }
}
