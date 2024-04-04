using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.ProfileScreens
{
    public static class ListProfileScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of all profiles");
            Console.WriteLine("--------------------");
            ListProfiles();
            Console.ReadKey();
            MenuProfileScreen.Load();
        }
        private static void ListProfiles()
        {
            var repository = new Repository<Role>();
            var profiles = repository.Get();
            foreach (var items in profiles)
                Console.WriteLine($"{items.Id} - {items.Name} ({items.Slug})");
        }
    }
}