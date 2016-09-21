using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.SubComponents;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    using System.ComponentModel;
    using System.Diagnostics;

    using FacebookApp.Annotations;

    public partial class ProfilePage : UserControl, INotifyPropertyChanged
    {
        public event EventHandler HomeClicked;

        public event EventHandler SettingsButtonClicked;

        public event EventHandler PartyClicked;

        private FeedView m_Feed;

        private User m_CurrentUser;

        public User CurrentUser
        {
            get
            {
                return m_CurrentUser;
            }

            set
            {
                m_CurrentUser = value;
                OnPropertyChanged("CurrentUser");
                Debug.Print("Profile Page" + value);
            }
        }

        public ProfilePage()
        {
            InitializeComponent();
            DJObserverable.OnPartyStart += CommenceParty;
            DJObserverable.OnPartyEnd += OnPartyEnd;
        }


        public void ShowUser(User i_User)
        {
            DataBindings.Add("CurrentUser", topPanel, "CurrentUser", true, DataSourceUpdateMode.OnPropertyChanged);
            CurrentUser = i_User;
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
            topPanel.HomeClicked += topPanel_HomeClicked;
            topPanel.SettingsButtonClicked += topPanelSettingsButtonClicked;
            topPanel.PartyButtonPressed += topPanelOnPartyButtonPressed;
            ////DataBindings.Add("CurrentUser", this, "topPanel." + "TopPanel.k_CurrentlyShownUserString", false, DataSourceUpdateMode.Never);
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
        /// DropTheBeat partying!!!
        /// </summary>
        public void CommenceParty()
        {
            ColorfulFlicker flicker = new ColorfulFlicker();
            flicker.Size = new Size(ClientSize.Width, ClientSize.Height);
            flicker.Location = new Point(0, 0);
            flicker.StartFlickering();
            Controls.Add(flicker);
            flicker.BringToFront();
        }

        private void OnPartyEnd()
        {
            foreach (Control control in Controls)
            {
                if (control is ColorfulFlicker)
                {
                    Controls.Remove(control);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string i_PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(i_PropertyName));
            }
        }
    }
}
