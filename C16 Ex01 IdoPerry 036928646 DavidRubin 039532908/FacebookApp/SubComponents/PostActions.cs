using System;
using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    using System.Drawing;

    using FacebookWrapper.ObjectModel;

    public partial class PostActions : UserControl
    {
        private Post m_Post = null;
        private bool m_LikedByMe = false;

        public PostActions()
        {
            InitializeComponent();
        }

        public void Init(Post i_post)
        {
            m_Post = i_post;
            FacebookObjectCollection<User> likedBy = i_post.LikedBy;
            m_LikedByMe = likedBy.Contains(FormApp.m_LoggedInUser);

            UpdateLikeButton();
            commentBoxPostComment.Type = eCommentBoxType.Comment;
            commentBoxPostComment.ShowUser(FormApp.m_LoggedInUser);

            commentBoxPostComment.CommentSubmit += commentBoxPostComment_CommentSubmit;
            buttonLike.Click += ButtonLikeOnClick;
        }

        private void ButtonLikeOnClick(object i_Sender, EventArgs i_EventArgs)
        {
            if (!m_LikedByMe)
            {
                m_Post.Like();
                m_LikedByMe = true;
                UpdateLikeButton();
            }
        }

        private void UpdateLikeButton()
        {
            if (m_LikedByMe)
            {
                buttonLike.Enabled = false;
                buttonLike.BackColor = Color.DodgerBlue;
                buttonLike.ForeColor = Color.White;
                buttonLike.Text = "liked";
            }
        }

        private void ToggleLikeButton()
        {
        }

        void commentBoxPostComment_CommentSubmit(string i_CommentText)
        {
            m_Post.Comment(i_CommentText);
        }

        public void CommenceParty()
        {
            commentBoxPostComment.CommenceParty();
        }
    }
}
