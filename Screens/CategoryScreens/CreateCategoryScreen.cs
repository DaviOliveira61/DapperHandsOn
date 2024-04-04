using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("New category");
            Console.WriteLine("-----------------");
            Console.Write("Category name: ");
            var name = Console.ReadLine();
            Console.Write("Category slug: ");
            var slug = Console.ReadLine();
            CreateCategory(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void CreateCategory(Category category)
        {
            try
            {
                var repository = new Repository<Category>();
                repository.Create(category);
                Console.WriteLine(category.Name + " has been registered successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to register '{category.Name}'");
                Console.WriteLine(ex.Message);
            }
        }
    }
}