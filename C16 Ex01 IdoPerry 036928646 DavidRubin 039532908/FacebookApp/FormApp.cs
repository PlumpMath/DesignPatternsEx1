using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    using Timer = System.Windows.Forms.Timer;

    public partial class FormApp : Form
    {
        public static User m_LoggedInUser;
        private const int k_CollectionLimit = 50;
        private Thread m_loadingThread;
        private UserSettings m_userSettings = UserSettings.CreateFromFile();
        private ProfilePage m_CurrentProfilePage;

        private delegate void UserLoadedDelegate(User i_User);

        public delegate void PartyEventHandler();

        public FormApp()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            ShowLoadingScreen();
            if (m_userSettings.RememberMe)
            {
                Thread.CurrentThread.Name = "Main";
                m_loadingThread = new Thread(loginWithToken);
                m_loadingThread.Name = "loading";
                m_loadingThread.Start();
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

        private void settingsForm_OnChangesSubmitted(UserSettings i_changdSettings)
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
                Invoke(new UserLoadedDelegate(ShowUserProfile), m_LoggedInUser);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void ShowLoadingScreen()
        {
            Controls.Clear();

            LoadingPanel loadingPanel = new LoadingPanel();
            int xPos = (Size.Width / 2) - (loadingPanel.Size.Width / 2);
            int yPos = (Size.Height / 2) - (loadingPanel.Size.Height / 2);
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
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
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

        private void CurrentProfilePagePartyClicked(object sender, EventArgs e)
        {
            if (m_CurrentProfilePage != null)
            {
                DJObserverable.DropTheBeat();
            }
        }

        private void CurrentProfilePageOnSettingsButtonClicked(object sender, EventArgs eventArgs)
        {
            ShowSettingsForm();
        }

        private void CurrentProfilePageHomeClicked(object sender, EventArgs e)
        {
            ShowUserProfile(m_LoggedInUser);
        }
    }
}
