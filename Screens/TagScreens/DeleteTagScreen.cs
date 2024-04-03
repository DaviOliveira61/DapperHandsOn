using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete tag");
            Console.WriteLine("-----------");
            Console.Write("Which tag ID do you want to delete? ");
            var id = int.Parse(Console.ReadLine());
            Delete(id);
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Delete(id);
                Console.WriteLine("Tag has been deleted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}