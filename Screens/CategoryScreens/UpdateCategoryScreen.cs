using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Update category");
            Console.WriteLine("-----------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            UpdateCategory(new Category
            {
                Id = id,
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void UpdateCategory(Category category)
        {
            try
            {
                var repository = new Repository<Category>();
                repository.Update(category);
                System.Console.WriteLine($"{category.Name} has been updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to update the category {category.Name}");
                Console.WriteLine(ex.Message);
            }
        }
    }
}