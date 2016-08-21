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
    using System.Diagnostics;
    using System.Threading;

    using FacebookWrapper.ObjectModel;

    public partial class TopPanel : UserControl
    {
        private string m_loggedUserImageUrl;
        private string m_currecntUserImageUrl;
        private string m_currecntUserCoverUrl;
        private string m_userName;
        private Thread m_loadingThread;

        public event EventHandler HomeClicked;

        public TopPanel()
        {
            InitializeComponent();
        }

        //Show user header
        public void ShowUser(User i_User)
        {
            //m_loadingThread = new Thread(LoadData);
            userProfileImage.LoadUserImage(i_User);
            userCoverPhoto.LoadAsync(i_User.Cover.SourceURL);
            pictureboxLoggedUserImage.LoadUserImage(FormApp.m_LoggedInUser);
            labelUserName.Text = i_User.Name;
            labelUserName.BackColor = Color.Transparent;
            userCoverPhoto.LoadCompleted += userCoverPhoto_LoadCompleted;
        }

        void userCoverPhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Debug.Print("ok!");
            ToggleLoadPanel(false);
        }

        private void ToggleLoadPanel(bool i_loadingVisible)
        {
            //panel
            loadingPanel.Visible = i_loadingVisible;

            //rest of the components
            userProfileImage.Visible = !i_loadingVisible;
            userCoverPhoto.Visible = !i_loadingVisible;
            pictureboxLoggedUserImage.Visible = !i_loadingVisible;
            labelUserName.Visible = !i_loadingVisible;
        }

        private void PictureboxLoggedUserImageClick(object sender, EventArgs e)
        {
            if (HomeClicked != null)
            {
                HomeClicked(this,null);
            } 
        }
    }
}
