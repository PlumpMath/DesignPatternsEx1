using System.Windows.Forms;
using System;

using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
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
                ResetTextsComponentTexts();
            }
        }

        private void ResetTextsComponentTexts()
        {
            string textAreaString = string.Empty;
            string buttonText = string.Empty;

            switch (Type)
            {
                case eCommentBoxType.Comment:
                    textAreaString = "Write a comment";
                    buttonText = "Comment";
                    break;
                case eCommentBoxType.WallSelf:
                    textAreaString = "Whats on your mind?";
                    buttonText = "Post";
                    break;
                case eCommentBoxType.WallUser:
                    textAreaString = "Write something...";
                    buttonText = "Post";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("value", Type, null);
            }

            textBoxCommentText.Text = textAreaString;
            buttonSubmit.Text = buttonText;
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
                SubmitText();
            }
        }

        private void SubmitText()
        {
            if (CommentSubmit != null)
            {
                CommentSubmit(textBoxCommentText.Text);
            }

            textBoxCommentText.Text = String.Empty;
        }

        private void buttonSubmit_Click(object i_Sender, EventArgs i_E)
        {
            SubmitText();
        }

        public void CommenceParty()
        {
            ComponentDanceMachine dancer1 = new ComponentDanceMachine(userProfileImage);
            dancer1.Start();
        }
    }

    public enum eCommentBoxType
    {
        Comment,
        WallSelf,
        WallUser
    }
}
