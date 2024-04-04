using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Update an user");
            Console.WriteLine("-----------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

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

            UpdateUser(new User
            {
                Id = id,
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
        private static void UpdateUser(User user)
        {
            try
            {
                var repository = new Repository<User>();
                repository.Update(user);
                System.Console.WriteLine($"{user.Name} has been updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to update the profile {user.Name}");
                Console.WriteLine(ex.Message);
            }
        }
    }
}