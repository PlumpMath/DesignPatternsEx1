using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public partial class TopPanel : UserControl
    {
        public TopPanel()
        {
            InitializeComponent();
        }

        //Show user header
        public void ShowUser(User i_User)
        {
            userProfileImage.LoadUserImage(i_User);
            userCoverPhoto.LoadAsync(i_User.Cover.SourceURL);
            pictureboxLoggedUserImage.LoadUserImage(FormApp.m_LoggedInUser);
            labelUserName.Text = i_User.Name;
            labelUserName.BackColor = Color.Transparent;
        }

        //TODO - when picture clicked,load my page
        private void pictureboxLoggedUserImage_Click(object sender, EventArgs e)
        {

        }
    }
}
