using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.PostScreens
{
    public static class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Delete Post");
            Console.WriteLine("-----------");
            Console.Write("Which post ID do you want to delete? ");
            var id = int.Parse(Console.ReadLine());
            Delete(id);
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Post>();
                repository.Delete(id);
                Console.WriteLine("Post has been deleted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}