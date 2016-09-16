namespace FacebookApp.Builder
{
    using System.Windows.Forms;
    using FacebookApp.SubComponents;
    using FacebookWrapper.ObjectModel;

    public class PostsViewBuilder
    {
        public static PostView Build(Post i_Post)
        {
            PostView postResult = new PostView(i_Post);
            postResult.Dock = DockStyle.Top;
            postResult.Padding = new Padding(0, 15, 0, 0);
            PostDetails details = new PostDetails();
            PostBody body = new PostBody();
            PostActions actions = new PostActions();

            actions.Init(i_Post);
            body.Init(i_Post);
            details.Init(i_Post);

            details.Dock = DockStyle.Top;
            body.Dock = DockStyle.Top;
            actions.Dock = DockStyle.Top;

            postResult.Controls.Add(actions);
            postResult.Controls.Add(body);
            postResult.Controls.Add(details);

            details.UserClicked += postResult.OnUserClicked;

            return postResult;
        }
    }
}
