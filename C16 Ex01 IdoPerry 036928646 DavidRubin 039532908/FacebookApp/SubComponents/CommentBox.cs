using System.Windows.Forms;
using System.Diagnostics;

namespace FacebookApp
{
    using System;

    using FacebookWrapper.ObjectModel;

    public delegate void CommentSubmitHandler(string i_CommentText);

    public partial class CommentBox : UserControl
    {
        public event CommentSubmitHandler CommentSubmit;

        private eCommentBoxType m_type = eCommentBoxType.Comment;
        public eCommentBoxType Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
                string initString = string.Empty;
                switch (value)
                {
                    case eCommentBoxType.Comment:
                        initString = "Write a comment";
                        break;
                    case eCommentBoxType.WallSelf:
                        initString = "Whats on your mind?";
                        break;
                    case eCommentBoxType.WallUser:
                        initString = "Write something...";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("value", value, null);
                }

                textBoxCommentText.Text = initString;
            }
        }

        public CommentBox()
        {
            InitializeComponent();
            textBoxCommentText.KeyDown += TextBoxCommentTextOnKeyDown;
        }

        public void ShowUser(User i_User)
        {
            userProfileImage.LoadUserImage(i_User);
        }

        private void TextBoxCommentTextOnKeyDown(object i_Sender, KeyEventArgs i_KeyEventArgs)
        {
            // On enter clear text box and dispatch comment text
            if (i_KeyEventArgs.KeyCode == Keys.Enter)
            {
                if (CommentSubmit != null)
                {
                    CommentSubmit(textBoxCommentText.Text);
                }

                textBoxCommentText.Text = "";
            }
        }
    }

    public enum eCommentBoxType
    {
        Comment,
        WallSelf,
        WallUser
    }
}
