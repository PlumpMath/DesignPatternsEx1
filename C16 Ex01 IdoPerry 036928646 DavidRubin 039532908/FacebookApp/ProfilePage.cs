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
        private FeedView m_Feed;

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
            m_Feed = new FeedView();
            m_Feed.AutoSize = true;
            m_Feed.Dock = DockStyle.Top;
            m_Feed.ShowUser(m_CurrentUser);
            m_Feed.UserClicked += ShowUser;

            ReplaceComponentInMainPanel(m_Feed);
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

        /// <summary>
        /// Start partying!!!
        /// </summary>
        public void CommenceParty()
        {
            topPanel.CommenceParty();
            leftPanel.CommenceParty();
            if (m_Feed != null)
            {
                m_Feed.CommenceParty();
            }
        }
    }
}
