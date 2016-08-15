using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{

    public partial class FormApp : Form
    {

        //TODO - should make a singleton out of FORMAPP (we could have one instance at a tie MAX)
        public static User m_LoggedInUser;

        public FormApp()
        {
            //login();
            loginWithToken();
            InitializeComponent();
            fetchUserInfo();
        }

        private void loginWithToken()
        {
            FacebookService.s_CollectionLimit = 1000;
            string token =
                "EAAEGbNPofJEBAHmkxxDTVBhLnpVZBYrdppy4pR8Wuigo4NyEJXpgIjJpfcRAyHqBJCp5acIZBjwcpS4bHyy5ncU1jh4gFFwz6g0lJUZBxXY4AxMN8uxEOoOWAjTOZBgJWZAMnx2jGDZBZBBzgZA0YlEhHviVHYvixfDDw3rAqNHx6gZDZD";
            LoginResult result = FacebookService.Connect(token);


            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }


    private void login()
    {
        FacebookService.s_CollectionLimit = 1000;
        LoginResult result = FacebookService.Login("288539458174097", 
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

            "rsvp_event"
            );


        if (!string.IsNullOrEmpty(result.AccessToken))
        {
            //EAAEGbNPofJEBAHmkxxDTVBhLnpVZBYrdppy4pR8Wuigo4NyEJXpgIjJpfcRAyHqBJCp5acIZBjwcpS4bHyy5ncU1jh4gFFwz6g0lJUZBxXY4AxMN8uxEOoOWAjTOZBgJWZAMnx2jGDZBZBBzgZA0YlEhHviVHYvixfDDw3rAqNHx6gZDZD
            m_LoggedInUser = result.LoggedInUser;
        }
        else
        {
            MessageBox.Show(result.ErrorMessage);
        }
    }

    private void fetchUserInfo()
    {
        profilePage.ShowUser(m_LoggedInUser.Friends[0]);

        //pictureBoxProfile.LoadAsync(m_LoggedInUser.Id);
        if (m_LoggedInUser.Posts.Count > 0)
        {
         //   textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
        }
    }
}
}
