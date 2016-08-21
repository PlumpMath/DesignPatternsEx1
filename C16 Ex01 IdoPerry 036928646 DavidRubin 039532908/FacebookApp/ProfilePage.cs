using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookApp.SubComponents;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class ProfilePage : UserControl
    {
        public event EventHandler HomeClicked;
        public event EventHandler SettingsButtonClicked;
        public event EventHandler PartyClicked;

        private User m_CurrentUser;
        public ProfilePage()
        {
            InitializeComponent();
        }

        public void ShowUser(User i_User)
        {
            m_CurrentUser = i_User;
            InitLeftPanel();
            InitTopPanel();
            InitMainPanel();

        }

        private void InitMainPanel()
        {
            FeedView feed = new FeedView();
            feed.AutoSize = true;
            feed.Dock = DockStyle.Top;
            feed.ShowUser(m_CurrentUser);
            feed.UserClicked += ShowUser;

            ReplaceComponentInMainPanel(feed);
        }

        private void ReplaceComponentInMainPanel(Control i_controlToAdd)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(i_controlToAdd);
        }

        private void InitTopPanel()
        {
            topPanel.ShowUser(m_CurrentUser);
            topPanel.HomeClicked += topPanel_HomeClicked;
            topPanel.SettingsButtonClicked += TopPanelSettingsButtonClicked;
            topPanel.PartyButtonPressed += TopPanelOnPartyButtonPressed;
        }

        private void TopPanelOnPartyButtonPressed(object sender, EventArgs eventArgs)
        {
            if (PartyClicked != null)
            {
                PartyClicked.Invoke(this,null);
            }
        }

        void TopPanelSettingsButtonClicked(object sender, EventArgs e)
        {
            if (SettingsButtonClicked != null)
            {
                SettingsButtonClicked.Invoke(this, null);
            }
        }

        void topPanel_HomeClicked(object sender, EventArgs e)
        {
            if (HomeClicked != null)
            {
                HomeClicked.Invoke(this,null);
            }
        }

        private void InitLeftPanel()
        {
            
           leftPanel.Init(m_CurrentUser);
           leftPanel.UserChanged += ShowUser;
        }

    }
}
