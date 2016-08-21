using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{


    public partial class FormStatisitcs : Form
    {
        private UserStatistics m_UserStatistics;
        private Thread m_StatisticsLoadingThread;
        private Timer m_timer;
        private LoadingPanel m_LoadingPanel;

        public FormStatisitcs()
        {
            InitializeComponent();
            
        }

        protected override void OnShown(EventArgs e)
        {
            if (m_UserStatistics == null)
            {
                m_UserStatistics = new UserStatistics();
                ShowLoadingScreen();
                Thread.CurrentThread.Name = "Main";
                m_StatisticsLoadingThread = new Thread(getStatistics);
                m_StatisticsLoadingThread.Name = "loading";
                m_StatisticsLoadingThread.Start();
                WaitForLoadingToEnd();
            }

            base.OnShown(e);
        }

        private void WaitForLoadingToEnd()
        {
            m_timer = new Timer();
            m_timer.Interval = 1000;
            m_timer.Tick += TimerOnTick;
            m_timer.Start();
        }

        private void TimerOnTick(object i_Sender, EventArgs i_E)
        {
            if (!m_StatisticsLoadingThread.IsAlive)
            {
                m_timer.Stop();
                init();
            }
        }

        private void ShowLoadingScreen()
        {

            m_LoadingPanel = new LoadingPanel();
            m_LoadingPanel.BringToFront();
            int xPos = Size.Width / 2 - m_LoadingPanel.Size.Width / 2;
            int yPos = Size.Height / 2 - m_LoadingPanel.Size.Height / 2;
            m_LoadingPanel.Location = new Point(xPos, yPos);
            m_LoadingPanel.Anchor = AnchorStyles.None;
            hideControls();
            Controls.Add(m_LoadingPanel);
        }

        private void hideControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Hide();
            }
        }

        private void showControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Show();
            }
        }

        private void init()
        {
            Controls.Remove(m_LoadingPanel);
            labelTotalNumberOfLikes.Text += " " + m_UserStatistics.TotalNumberOfLikes.ToString();
            labelMostLikedPostContent.Text = m_UserStatistics.MostLikedPost.Message;
            labelMostLikedPostTitle.Text += " (" + m_UserStatistics.MostLikedPostLikeCount.ToString() + " likes):";
            labelMostLikedAlbumTitle.Text += " (" + m_UserStatistics.MostLikedAlbumLikeCount.ToString() + " likes):";
            labelMostLikedPhotoTitle.Text += " (" + m_UserStatistics.MostLikedPhotoLikeCount.ToString() + " likes):";
            pictureBoxMostLikedAlbum.BackgroundImage = m_UserStatistics.MostLikedAlbum.ImageAlbum;
            pictureBoxMostLikedPhoto.BackgroundImage = m_UserStatistics.MostLikedPhoto.ImageNormal;
            showControls();
        }

        private void getStatistics()
        {
            getPostStatistics();
            getAlbumsStatistics();
            
        }

        private void getPostStatistics()
        {
            foreach (Post post in FormApp.m_LoggedInUser.Posts)
            {
                if (post.LikedBy.Count > m_UserStatistics.MostLikedPostLikeCount)
                {
                    m_UserStatistics.MostLikedPostLikeCount = post.LikedBy.Count;
                    m_UserStatistics.MostLikedPost = post;
                }

                m_UserStatistics.TotalNumberOfLikes += post.LikedBy.Count;
            }
        }

        private void getAlbumsStatistics()
        {
            foreach (Album album in FormApp.m_LoggedInUser.Albums)
            {
                if (album.LikedBy.Count > m_UserStatistics.MostLikedAlbumLikeCount)
                {
                    m_UserStatistics.MostLikedAlbumLikeCount = album.LikedBy.Count;
                    m_UserStatistics.MostLikedAlbum = album;
                }

                foreach (Photo photo in album.Photos)
                {
                    if (photo.LikedBy.Count > m_UserStatistics.MostLikedPhotoLikeCount)
                    {
                        m_UserStatistics.MostLikedPhotoLikeCount = photo.LikedBy.Count;
                        m_UserStatistics.MostLikedPhoto = photo;
                    }
                }
            }
        }
    }
}