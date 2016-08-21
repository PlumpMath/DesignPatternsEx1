using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    using System.Diagnostics;

    using FacebookWrapper.ObjectModel;

    public partial class FeedView : UserControl
    {
        private bool m_isSelfFeed = false;
        private User m_user = null;
        public event EventHandler UserClicked;

        public FeedView()
        {
            InitializeComponent();
        }

        public void ShowUser(User i_User)
        {
            m_user = i_User;
            m_isSelfFeed = (i_User == FormApp.m_LoggedInUser);
            InitCommentBox();
            InitPostsList();
        }

        private void InitPostsList()
        {
            postsList.ShowUserPosts(m_user);
            postsList.UserClicked += postsList_UserClicked;
        }

        void postsList_UserClicked(object sender, EventArgs e)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(this,null);
            }
        }

        private void InitCommentBox()
        {
            eCommentBoxType commentType = m_isSelfFeed
                                              ? eCommentBoxType.WallSelf
                                              : eCommentBoxType.WallUser;
            commentBox.Type = commentType;

            //comment should always be of the current user
            commentBox.ShowUser(FormApp.m_LoggedInUser);
            commentBox.CommentSubmit += CommentBoxOnCommentSubmit;
        }

        private void CommentBoxOnCommentSubmit(string i_CommentText)
        {
            m_user.PostStatus(i_CommentText);
            Debug.Print(i_CommentText);
        }
    }
}
