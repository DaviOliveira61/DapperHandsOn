using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tag list");
            Console.WriteLine("-----------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<Tag>();
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");

        }
    }
}