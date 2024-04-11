using BaltaDataAccessHandsOn.Repositories;
using BaltaDataAccessHandsOn.Screens.MainMenuScreen;
using BaltaDataAccessHandsOn.Screens.MenuLinksScreens;
using BaltaDataAccessHandsOn.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccessHandsOn
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();
            // ConnectAPostWithATag.Load();
            MainMenuScreen.Load();
            // GetUsers(Database.Connection);
            // GetPost(Database.Connection);
            // DeleteUserScreen.Load();
            // CreateUserScreen.Load();
            Console.ReadKey();
            Database.Connection.Close();
        }
        public static void GetUsers(SqlConnection connection)
        {
            var repository = new UserRepository();
            var users = repository.GetWithRole();
            foreach (var item in users)
            {
                Console.Write($"{item.Name}, ");
                Console.WriteLine($"{item.Email} ");

                foreach (var role in item.Roles)
                {
                    Console.Write($" - {role.Name}, ");
                }
            }

        }
        public static void GetPost(SqlConnection connection)
        {
            var repository = new PostRepository();
            var posts = repository.GetWithTag();
            foreach (var item in posts)
            {
                Console.WriteLine($"{item.Id}");
                Console.WriteLine($"{item.Title}");
                foreach (var tag in item.Tags)
                {
                    Console.WriteLine($" - {tag.Name}");
                }
            }
        }
    }
}