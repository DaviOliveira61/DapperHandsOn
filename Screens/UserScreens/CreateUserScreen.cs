using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Create an user");
            Console.WriteLine("--------------------");
            Console.Write("User name: ");
            var name = Console.ReadLine();
            Console.Write("User email: ");
            var email = Console.ReadLine();
            Console.WriteLine("User password: ");
            var passwordhash = "HASH";
            Console.Write("User bio: ");
            var bio = Console.ReadLine();
            Console.WriteLine("User image: ");
            var img = "https://";
            Console.Write("User slug: ");
            var slug = Console.ReadLine();
            CreateUsers(new User // TODO: AFTER, CREATE A OPTION TO LINK HERE A USER WITH A PROFILE
            {
                Name = name,
                Email = email,
                PasswordHash = passwordhash,
                Bio = bio,
                Image = img,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void CreateUsers(User user)
        {
            try
            {
                var repository = new Repository<User>();
                repository.Create(user);
                Console.WriteLine($"User {user.Name} has been created!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Unable to create {user.Name}");
                Console.WriteLine(ex.Message);
            }

        }
    }
}