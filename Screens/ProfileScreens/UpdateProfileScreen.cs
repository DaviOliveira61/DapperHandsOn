using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.ProfileScreens
{
    public static class UpdateProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Update a profile");
            Console.WriteLine("-----------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            UpdateProfile(new Role
            {
                Id = id,
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuProfileScreen.Load();
        }
        private static void UpdateProfile(Role role)
        {
            try
            {
                var repository = new Repository<Role>();
                repository.Update(role);
                System.Console.WriteLine($"{role.Name} has been updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to update the profile {role.Name}");
                Console.WriteLine(ex.Message);
            }
        }
    }
}