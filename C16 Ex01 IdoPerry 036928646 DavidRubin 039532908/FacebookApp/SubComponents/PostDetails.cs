using System.Windows.Forms;
using System;

using FacebookWrapper.ObjectModel;

namespace FacebookApp.SubComponents
{
    public partial class PostDetails : UserControl
    {
        private Post m_Post;

        public event UserChangedDelegate UserClicked;

        public PostDetails()
        {
            InitializeComponent();
        }

        public void LoadDetailsFromPost(Post i_Post)
        {
            m_Post = i_Post;
            labelPostType.Text = i_Post.Type.ToString();

            // image
            userProfileImagePostedBy.LoadUserImage(i_Post.From);

            // name
            labelFrom.Text = i_Post.From.Name;

            // X time ago
            string timeText = string.Empty;
            if (i_Post.CreatedTime.HasValue)
            {
                timeText = GetPassedTimeSinceCreated(i_Post.CreatedTime.Value);
            }

            labelPostedTime.Text = timeText;
        }

        private string GetPassedTimeSinceCreated(DateTime i_TimeCreated)
        {
            string result;

            DateTime now = DateTime.Now;
            TimeSpan passed = now.Subtract(i_TimeCreated);

            // if more then a two weeek return the date
            if (passed.Days > 8)
            {
                result = string.Format("Posted in {0} ", i_TimeCreated.ToShortDateString());
            }
            else if (passed.Days > 6)
            {
                // if a week return a week ago 7,8 days
                result = "Posted a week ago";
            }
            else if (passed.Days > 1)
            {
                // if less then a week, return number of days
                result = string.Format("Posted {0} days ago", passed.Days);
            }
            else if (passed.Days == 1)
            {
                // if between 1-2 dayes return yesterday
                result = "Posted yesterday";
            }
            else if (passed.Hours > 1)
            {
                // if more then an hour return in hours
                result = string.Format("Posted {0} hours ago", passed.Hours);
            }
            else if (passed.Hours == 1)
            {
                // else return in minutes
                result = "Posted an hour ago";
            }
            else if (passed.Minutes > 1)
            {
                result = string.Format("Posted {0} minutes ago", passed.Minutes);
            }
            else
            {
                result = "Posted a minute ago";
            }

            return result;
        }

        private void labelFrom_Click(object i_Sender, EventArgs i_E)
        {
            if (UserClicked != null)
            {
                UserClicked.Invoke(m_Post.From);
            }
        }

        public void CommenceParty()
        {
            ComponentDanceMachine dancer1 = new ComponentDanceMachine(userProfileImagePostedBy);
            dancer1.Start();
        }
    }
}
