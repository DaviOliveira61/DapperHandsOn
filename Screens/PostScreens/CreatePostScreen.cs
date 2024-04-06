using System.Text;
using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;
using BaltaDataAccessHandsOn.Screens.MainMenuScreen;

namespace BaltaDataAccessHandsOn.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Create a post");
            Console.WriteLine("--------------------");
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
            var createDate = DateTime.Now;
            var lastUpdate = DateTime.Now;

            CreateAPost(new Post
            {
                CategoryId = categoryId,
                AuthorId = authorId,
                Title = title,
                Summary = summary,
                Body = body.ToString(),
                Slug = slug,
                CreateDate = createDate,
                LastUpdateDate = lastUpdate
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void CreateAPost(Post post)
        {
            // Check if category exists
            var postCategory = post.CategoryId;
            bool categoryExist = false;
            var getCategory = new Repository<Category>();
            var categories = getCategory.Get();

            foreach (var searchCategories in categories)
            {
                if (postCategory == searchCategories.Id)
                {
                    categoryExist = true;
                    break; // get out of the foreach
                }
                else
                {
                    Console.WriteLine("Choose a valid category!");
                    Console.WriteLine("Do you want to back to the main menu or write a new post? (M, P)");
                    var option = Console.ReadLine().ToLower();
                    while (option != "m" || option != "p")
                    {
                        Console.WriteLine("Choose a valid option!");
                        Console.WriteLine("Do you want to back to the main menu or write a new post? (M, P)");
                        option = Console.ReadLine().ToLower();
                        if (option == "m")
                            MainMenuScreen.MainMenuScreen.Load();
                        else
                            Load();
                    }

                }
            }

            // Check if author exists
            var postAuthor = post.AuthorId;
            bool authorExist = false;
            var getAuthor = new Repository<Role>();
            var authors = getAuthor.Get();

            foreach (var searchAuthors in authors)
            {
                if (postAuthor == searchAuthors.Id)
                {
                    authorExist = true;
                    break; // get out of the foreach
                }
                else
                {
                    Console.WriteLine("Choose a valid author!");
                    Console.ReadKey();
                    Load();
                }
            }

            try
            {
                if (authorExist == true && categoryExist == true)
                {
                    var repository = new Repository<Post>();
                    var category = new Category();
                    repository.Create(post);
                    category.insertAPost(post);

                    Console.WriteLine();
                    Console.WriteLine("Post has been created!");
                    Console.ReadKey();
                    MenuPostScreen.Load();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Unable to create the post!");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                MenuPostScreen.Load();
            }
        }
    }
}