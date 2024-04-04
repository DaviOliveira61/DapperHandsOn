using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.ProfileScreens
{
    public static class CreateProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Create a profile");
            Console.WriteLine("--------------------");
            Console.Write("Profile name: ");
            var name = Console.ReadLine();
            Console.Write("Profile slug: ");
            var slug = Console.ReadLine();
            CreateProfiles(new Role
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuProfileScreen.Load();
        }
        private static void CreateProfiles(Role role)
        {
            try
            {
                var repository = new Repository<Role>();
                repository.Create(role);
                Console.WriteLine($"Profile {role.Name} has been created!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Unable to craete {role.Name}");
                Console.WriteLine(ex.Message);
            }

        }
    }
}