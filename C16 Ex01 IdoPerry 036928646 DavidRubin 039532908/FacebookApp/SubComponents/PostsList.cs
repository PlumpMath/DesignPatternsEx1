﻿using System.Windows.Forms;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    using System;
    using System.Collections.Generic;

    public partial class PostsList : UserControl
    {
        private readonly List<Post.eType> m_postTypeWhiteList = new List<Post.eType>() { Post.eType.status, Post.eType.photo };
        private List<PostView> m_CurrentlyDesplayedPosts = new List<PostView>(); 
        public event UserChangedDelegate UserClicked;

        public PostsList()
        {
            InitializeComponent();
        }

        public void ShowUserPosts(User i_user)
        {
            FacebookObjectCollection<Post> userPosts = i_user.WallPosts;

            //Create post view for each one of the posts starting with the newest
            for (int i = userPosts.Count -1 ; i >= 0  ; i--)
            {
                Post post = userPosts[i];

                //Add only posts from the whitelist types
                if (m_postTypeWhiteList.IndexOf(post.Type.Value) != -1)
                {
                    //only add posts with pics or mesasge
                    if (post.Message != null || post.PictureURL != null)
                    {
                        PostView postViewToAddToList = new PostView(post);
                        postViewToAddToList.Dock = DockStyle.Top;
                        postViewToAddToList.Padding = new Padding(0, 15, 0, 0);
                        postViewToAddToList.UserClicked += PostViewToAddToListOnUserClicked;
                        Controls.Add(postViewToAddToList);     
                        m_CurrentlyDesplayedPosts.Add(postViewToAddToList);
                    }
                }
            }
        }

        private void PostViewToAddToListOnUserClicked(User i_User)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(i_User);
            }
        }

        public void CommenceParty()
        {
            //only the top two
            int maxDancers = 2;
            for (int i = m_CurrentlyDesplayedPosts.Count -1 ; i > m_CurrentlyDesplayedPosts.Count - 4; i--)
            {
                PostView currentlyDesplayedPost = m_CurrentlyDesplayedPosts[i];
                currentlyDesplayedPost.Commencepparty();
            }
//            foreach (PostView postView in m_CurrentlyDesplayedPosts)
//            {
//
//                postView.Commencepparty();
//            }
        }
    }
}
