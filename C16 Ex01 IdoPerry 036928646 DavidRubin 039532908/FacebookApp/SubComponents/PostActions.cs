using System;
using System.Threading;
using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    using System.Drawing;

    using FacebookWrapper.ObjectModel;

    public partial class PostActions : UserControl
    {
        private Post m_Post = null;
        private bool m_LikedByMe = false;

        private delegate void LikesLoadedDelegate(FacebookObjectCollection<User> i_UsersLiked);

        public PostActions()
        {
            InitializeComponent();
        }

        public void Init(Post i_post)
        {
            m_Post = i_post;
            new Thread(LoadPostData).Start();
        }

        private void LoadPostData()
        {
            FacebookObjectCollection<User> likedBy = m_Post.LikedBy;
            BeginInvoke(new LikesLoadedDelegate(AfterLikesLoaded), likedBy);
        }

        private void AfterLikesLoaded(FacebookObjectCollection<User> i_UsersLiked)
        {
            m_LikedByMe = i_UsersLiked.Contains(FormApp.m_LoggedInUser);

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

        private void commentBoxPostComment_CommentSubmit(string i_CommentText)
        {
            m_Post.Comment(i_CommentText);
        }

        public void CommenceParty()
        {
            commentBoxPostComment.CommenceParty();
        }
    }
}
