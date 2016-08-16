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

    public partial class Feed : UserControl
    {
        private bool m_isSelfFeed = false;

        public Feed()
        {
            InitializeComponent();
        }

        public void ShowUser(User i_user)
        {
            m_isSelfFeed = (i_user == FormApp.m_LoggedInUser);
            InitCommentBox();
            InitPostsList(i_user);
        }

        private void InitPostsList(User i_User)
        {
            postsList.ShowUserPosts(i_User);
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
            Debug.Print(i_CommentText);
        }
    }
}
