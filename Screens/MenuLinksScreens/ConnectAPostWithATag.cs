using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.MenuLinksScreens
{
    public static class ConnectAPostWithATag
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Which post and tag do you want to link?");
            Console.WriteLine("--------------------");
            Console.Write("Post ID: ");
            var postID = int.Parse(Console.ReadLine());
            Console.Write("Tag ID: ");
            var tagID = int.Parse(Console.ReadLine());
            LinkPostAndTag(postID, tagID);
            Console.ReadKey();
            MainMenuScreen.MainMenuScreen.Load();
        }
        private static void LinkPostAndTag(int postId, int tagId)
        {
            // try
            // {
            var postRepository = new PostRepository();
            postRepository.LinkPostAndTag(postId, tagId);
            // }
            // // catch (Exception ex)
            // // {
            // //     Console.WriteLine("Post won't linked");
            // //     Console.WriteLine(ex.StackTrace);
            // //     Console.WriteLine(ex.Source);
            // // }
        }
    }
}