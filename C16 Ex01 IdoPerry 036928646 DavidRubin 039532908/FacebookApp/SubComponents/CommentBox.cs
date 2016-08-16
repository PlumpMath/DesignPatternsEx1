using System.Windows.Forms;
using System.Diagnostics;

namespace FacebookApp
{

    internal delegate void CommentSubmitHandler(string i_CommentText);

    public partial class CommentBox : UserControl
    {
        event CommentSubmitHandler CommentSubmit;

        public CommentBox()
        {
            InitializeComponent();
            textBoxCommentText.KeyDown += TextBoxCommentTextOnKeyDown;
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

}
