using System.Windows.Forms;

namespace FacebookApp.SubComponents
{
    using System;

    using FacebookWrapper.ObjectModel;

    public partial class PostDetails : UserControl
    {
        public PostDetails()
        {
            InitializeComponent();
        }

        public void LoadDetailsFromPost(Post i_post)
        {
            labelPostType.Text = i_post.Type.ToString();
            //image
            userProfileImagePostedBy.LoadUserImage(i_post.From);
            //name
            labelFrom.Text = i_post.From.Name;
            //X time ago
            string timeText = string.Empty;
            if (i_post.CreatedTime.HasValue)
            {
                timeText = GetPassedTimeSinceCreated(i_post.CreatedTime.Value);
            }

            labelPostedTime.Text = timeText;
        }

        private string GetPassedTimeSinceCreated(DateTime i_timeCreated)
        {
            string result;

            DateTime now = DateTime.Now;
            TimeSpan passed = now.Subtract(i_timeCreated);

            //if more then a two weeek return the date
            if (passed.Days > 8)
            {
                result = string.Format("Posted in {0} ", i_timeCreated.ToShortDateString());
            }
            //if a week return a week ago 7,8 days
            else if (passed.Days> 6)
            {
                result = "Posted a week ago";
            }
            //if less then a week, return number of days
            else if (passed.Days > 1)
            {
                result = string.Format("Posted {0} days ago", passed.Days);
            }
            //if between 1-2 dayes return yesterday
            else if (passed.Days == 1)
            {
                result = "Posted yesterday";
            }
            //if more then an hour return in hours
            else if (passed.Hours > 1)
            {
                result = string.Format("Posted {0} hours ago", passed.Hours);
            }
            else if (passed.Hours == 1)
            {
                result = "Posted an hour ago";
            }
            //else return in minutes
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
    }
}
