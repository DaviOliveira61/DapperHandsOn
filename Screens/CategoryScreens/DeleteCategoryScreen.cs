using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Delete category");
            Console.WriteLine("-----------------");
            Console.Write("Which category ID do you want to delete? ");
            var id = int.Parse(Console.ReadLine());
            DeleteCategory(id);
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void DeleteCategory(int id)
        {
            try
            {
                var repository = new Repository<Category>();
                repository.Delete(id);
                Console.WriteLine("Deleted successfully!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to delete category!");
            }
        }
    }
}