using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    using System.Diagnostics;

    public partial class TopPanel : UserControl
    {
        private string m_loggedUserImageUrl;
        private string m_currecntUserImageUrl;
        private string m_currecntUserCoverUrl;
        private string m_userName;
        private Thread m_loadingThread;
        private FormStatisitcs m_FromStatisitcs;

        public event EventHandler HomeClicked;
        public event EventHandler SettingsButtonClicked;
        public event EventHandler PartyButtonPressed;

        public TopPanel()
        {
            InitializeComponent();
        }

        //Show user header
        public void ShowUser(User i_User)
        {
            //m_loadingThread = new Thread(LoadData);
            userProfileImage.LoadUserImage(i_User);
            pictureboxLoggedUserImage.LoadUserImage(FormApp.m_LoggedInUser);
            labelUserName.Text = i_User.Name;
            labelUserName.BackColor = Color.Transparent;

            if (i_User.Cover != null)
            {
                userCoverPhoto.LoadAsync(i_User.Cover.SourceURL);
            }
            userProfileImage.LoadCompleted += userProfilePhoto_LoadCompleted;
        }

        void userProfilePhoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DoneLoadingCover();
        }

        private void DoneLoadingCover()
        {
            //panel
            Controls.Remove(loadingPanel);

            //rest of the components
            userProfileImage.Visible = true;
            userCoverPhoto.Visible = true;
            pictureboxLoggedUserImage.Visible = true;
            labelUserName.Visible = true;
        }

        private void PictureboxLoggedUserImageClick(object sender, EventArgs e)
        {
            if (HomeClicked != null)
            {
                HomeClicked.Invoke(this, null);
            } 
        }

        private void ButtonSettingsClick(object sender, EventArgs e)
        {
            if (SettingsButtonClicked != null)
            {
                SettingsButtonClicked.Invoke(this, null);
            }
        }

        private void ButtonPartyClick(object sender, EventArgs e)
        {
            if (PartyButtonPressed != null)
            {
                PartyButtonPressed.Invoke(this,null);
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            if (m_FromStatisitcs == null)
            {
                m_FromStatisitcs = new FormStatisitcs();
            }
            m_FromStatisitcs.ShowDialog();
        }

        public void CommenceParty()
        {
            buttonParty.Visible = false;
            ComponentDanceMachine dancer1 = new ComponentDanceMachine(labelUserName);
            ComponentDanceMachine dancer2 = new ComponentDanceMachine(userProfileImage);
            ComponentDanceMachine dancer3 = new ComponentDanceMachine(pictureboxLoggedUserImage);

            dancer1.Start();
            dancer2.Start();
            dancer3.Start();
        }
    }
}
