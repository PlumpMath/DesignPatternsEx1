using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class TopPanel : UserControl
    {
        private FormStatisitcs m_FromStatisitcs;

        public event EventHandler HomeClicked;

        public event EventHandler SettingsButtonClicked;

        public event EventHandler PartyButtonPressed;

        public TopPanel()
        {
            InitializeComponent();
            m_FromStatisitcs = new FormStatisitcs();
        }

        // Show user header
        public void ShowUser(User i_User)
        {
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

        private void userProfilePhoto_LoadCompleted(object i_Sender, AsyncCompletedEventArgs i_EventArgs)
        {
            DoneLoadingCover();
        }

        private void DoneLoadingCover()
        {
            // panel
            Controls.Remove(loadingPanel);

            // rest of the components
            userProfileImage.Visible = true;
            userCoverPhoto.Visible = true;
            pictureboxLoggedUserImage.Visible = true;
            labelUserName.Visible = true;
        }

        private void PictureboxLoggedUserImageClick(object i_Sender, EventArgs i_E)
        {
            if (HomeClicked != null)
            {
                HomeClicked.Invoke(this, null);
            }
        }

        private void ButtonSettingsClick(object i_Sender, EventArgs i_E)
        {
            if (SettingsButtonClicked != null)
            {
                SettingsButtonClicked.Invoke(this, null);
            }
        }

        private void ButtonPartyClick(object i_Sender, EventArgs i_E)
        {
            if (PartyButtonPressed != null)
            {
                PartyButtonPressed.Invoke(this, null);
            }
        }

        private void buttonStatistics_Click(object i_Sender, EventArgs i_E)
        {
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
