using System;
using System.Drawing;
using System.Windows.Forms;
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
            MusicPlayer.OnPartyStart += CommenceParty;
        }

        public void ShowUser(User i_User)
        {
            m_CurrentUser = i_User;
            initLeftPanel();
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
            topPanel.SettingsButtonClicked += topPanelSettingsButtonClicked;
            topPanel.PartyButtonPressed += topPanelOnPartyButtonPressed;
        }

        private void topPanelOnPartyButtonPressed(object sender, EventArgs eventArgs)
        {
            if (PartyClicked != null)
            {
                PartyClicked.Invoke(this, null);
            }
        }

        private void topPanelSettingsButtonClicked(object sender, EventArgs e)
        {
            if (SettingsButtonClicked != null)
            {
                SettingsButtonClicked.Invoke(this, null);
            }
        }

        private void topPanel_HomeClicked(object sender, EventArgs e)
        {
            if (HomeClicked != null)
            {
                HomeClicked.Invoke(this, null);
            }
        }

        private void initLeftPanel()
        {
           leftPanel.Init(m_CurrentUser);
           leftPanel.UserChanged += ShowUser;
        }

        /// <summary>
        /// Start partying!!!
        /// </summary>
        public void CommenceParty()
        {
            ColorfulFlicker flicker = new ColorfulFlicker();
            flicker.Size = new Size(ClientSize.Width, ClientSize.Height);
            flicker.Location = new Point(0, 0);
            flicker.StartFlickering();
            Controls.Add(flicker);
            flicker.BringToFront();
            ComponentDanceMachine.PartiesOver += componentDanceMachine_PartiesOver;
        }

        private void componentDanceMachine_PartiesOver(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is ColorfulFlicker)
                {
                    Controls.Remove(control);
                }
            }
        }
    }
}
