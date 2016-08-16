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

    public partial class PostsList : UserControl
    {
        public PostsList()
        {
            InitializeComponent();
        }

        public void ShowUserPosts(User i_user)
        {
            FacebookObjectCollection<Post> posts = i_user.Posts;
            foreach (Post post in posts)
            {
                Debug.Print(post.Message);
            }
        }
    }
}
