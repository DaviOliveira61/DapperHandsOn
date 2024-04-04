using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("List of all categories");
            Console.WriteLine("-------------------------");
            ListCategories();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void ListCategories()
        {
            var repository = new Repository<Category>();
            var categories = repository.Get();
            foreach (var item in categories)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");

        }
    }
}