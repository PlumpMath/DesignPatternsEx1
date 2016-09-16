namespace FacebookApp.Builder
{

    using FacebookApp.SubComponents;
    using FacebookWrapper.ObjectModel;

    class PostsViewDirector
    {
        public static PostView Construct(Post i_Post)
        {
            return PostsViewBuilder.Build(i_Post);
        }
    }
}
