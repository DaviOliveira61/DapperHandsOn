using System.Text;
using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.PostScreens
{
    public class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Update a post");
            Console.WriteLine("-----------");
            Console.Write("Which is post ID? ");
            var postId = int.Parse(Console.ReadLine());

            Console.Write("What is category of this post? Write the ID: ");
            var categoryId = int.Parse(Console.ReadLine());

            Console.Write("Who is the author? Write the ID: ");
            var authorId = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Summary: ");
            var summary = Console.ReadLine();

            Console.Write("What do you wish write? ");
            var body = new StringBuilder();
            do
            {
                body.Append(Console.ReadLine());
                body.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            var lastUpdate = DateTime.Now;

            UpdatePost(new Post
            {
                Id = postId,
                CategoryId = categoryId,
                AuthorId = authorId,
                Title = title,
                Summary = summary,
                Body = body.ToString(),
                Slug = slug,
                LastUpdateDate = lastUpdate
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        public static void UpdatePost(Post post)
        {
            try
            {
                var repository = new Repository<Post>();
                var posts = repository.Get();
                DateTime createDate;
                List<int> postsIds = new List<int>();
                foreach (var postGetDate in posts)
                {
                    postsIds.Add(postGetDate.Id);
                    foreach (var getId in postsIds)
                    {
                        if (getId == post.Id)
                        {
                            post.CreateDate = postGetDate.CreateDate;
                        }
                    }
                }
                repository.Update(post);
                Console.WriteLine(post.Title + " has been updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update " + post.Title);
                Console.WriteLine(ex.Message);
            }
        }
    }
}