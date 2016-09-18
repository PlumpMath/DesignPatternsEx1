using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    public partial class PostView : UserControl
    {
        private Post m_Post;

        public event UserChangedDelegate UserClicked;

        public PostView(Post i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;
        }

        public void OnUserClicked(User i_User)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(i_User);
            }
        }
    }
}
