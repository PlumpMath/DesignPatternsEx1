using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    using System.Diagnostics;
    using System.Threading;

    using FacebookApp.SubComponents;

    using Timer = System.Windows.Forms.Timer;

    public partial class FormApp : Form
    {
        //TODO - should make a singleton out of FORMAPP (we could have one instance at a tie MAX)
        public static User m_LoggedInUser;
        private const int k_CollectionLimit = 50;
        private Timer m_timer;
        private Thread m_loadingThread;
        private UserSettings m_userSettings = UserSettings.CreateFromFile();
        private ProfilePage m_CurrentProfilePage;

        public delegate void PartyEventHandler();

        public static event PartyEventHandler PartyStarted;

        public FormApp()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            ShowLoadingScreen();
            if (m_userSettings.RememberMe)
            {
                //login();
                //loginWithToken();
                Thread.CurrentThread.Name = "Main";
                m_loadingThread = new Thread(loginWithToken);
                m_loadingThread.Name = "loading";
                m_loadingThread.Start();
                WaitForLoadingToEnd();

            }
            else
            {
                login();
            }

            base.OnShown(e);
        }

        private void ShowSettingsForm()
        {
            SettingsForm settingsForm = new SettingsForm(m_userSettings);
            settingsForm.Show();
            settingsForm.OnChangesSubmitted += settingsForm_OnChangesSubmitted;
        }

        void settingsForm_OnChangesSubmitted(UserSettings i_changdSettings)
        {
            m_userSettings = i_changdSettings;
            m_userSettings.Save();
        }

        private void loginWithToken()
        {
            Debug.Print("loginWithToken " + Thread.CurrentThread.Name);
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            string token = m_userSettings.LastUsedToken;
            LoginResult result = FacebookService.Connect(token);

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                m_userSettings.LastUsedToken = result.AccessToken;
                m_userSettings.Save();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void WaitForLoadingToEnd()
        {
            m_timer = new Timer();
            m_timer.Interval = 1000;
            m_timer.Tick += TimerOnTick;
            m_timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            Debug.Print("m_timer_Elapsed " + Thread.CurrentThread.Name);
            Debug.Print(m_loadingThread.IsAlive.ToString());
            if (!m_loadingThread.IsAlive)
            {
                m_timer.Stop();
                ShowUserProfile(m_LoggedInUser);
            }
        }

        private void ShowLoadingScreen()
        {
            //renive all controls and add loading
            Controls.Clear();

            LoadingPanel loadingPanel = new LoadingPanel();
            int xPos = Size.Width / 2 - loadingPanel.Size.Width / 2;
            int yPos = Size.Height / 2 - loadingPanel.Size.Height / 2;
            loadingPanel.Location = new Point(xPos, yPos);
            loadingPanel.Anchor = AnchorStyles.None;

            Controls.Add(loadingPanel);
        }

        private void login()
        {
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            LoginResult result = FacebookService.Login(
                "288539458174097",
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",

                //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",

                // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                "read_page_mailboxes",
                // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                m_userSettings.LastUsedToken = result.AccessToken;
                AfterLoggedInSuccessfully();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void AfterLoggedInSuccessfully()
        {
            m_userSettings.Save();
            ShowUserProfile(m_LoggedInUser);
        }

        private void ShowUserProfile(User i_userToShow)
        {
            Debug.Print("thread " + Thread.CurrentThread.Name);
            if (m_CurrentProfilePage != null)
            {
                m_CurrentProfilePage.HomeClicked -= CurrentProfilePageHomeClicked;
                m_CurrentProfilePage.SettingsButtonClicked -= CurrentProfilePageOnSettingsButtonClicked;
                m_CurrentProfilePage.PartyClicked -= CurrentProfilePagePartyClicked;
            }
            Controls.Clear();
            m_CurrentProfilePage = new ProfilePage();
            m_CurrentProfilePage.Dock = DockStyle.Top;
            Controls.Add(m_CurrentProfilePage);

            m_CurrentProfilePage.ShowUser(i_userToShow);
            m_CurrentProfilePage.HomeClicked += CurrentProfilePageHomeClicked;
            m_CurrentProfilePage.SettingsButtonClicked += CurrentProfilePageOnSettingsButtonClicked;
            m_CurrentProfilePage.PartyClicked += CurrentProfilePagePartyClicked;
        }

        void CurrentProfilePagePartyClicked(object sender, EventArgs e)
        {
            if (m_CurrentProfilePage != null)
            {
                MusicPlayer playa = new MusicPlayer();
                playa.Start();
                m_CurrentProfilePage.CommenceParty();
            }
        }

        private void CurrentProfilePageOnSettingsButtonClicked(object sender, EventArgs eventArgs)
        {
            ShowSettingsForm();
        }

        void CurrentProfilePageHomeClicked(object sender, EventArgs e)
        {
           ShowUserProfile(m_LoggedInUser);
        }
    }
}
