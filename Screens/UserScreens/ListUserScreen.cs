using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of all users");
            Console.WriteLine("--------------------");
            ListUsers();
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void ListUsers()
        {
            var repository = new Repository<User>();
            var users = repository.Get();
            foreach (var items in users)
                Console.WriteLine($"{items.Id} - {items.Name} - {items.Email} - {items.PasswordHash} - {items.Bio} - {items.Image} - {items.Slug}");
        }
    }
}