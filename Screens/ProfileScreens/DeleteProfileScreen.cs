using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.ProfileScreens
{
    public static class DeleteProfileScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Delete profile");
            Console.WriteLine("-----------------");
            Console.Write("Which profile ID do you want to delete? ");
            var id = int.Parse(Console.ReadLine());
            DeleteProfile(id);
            Console.ReadKey();
            MenuProfileScreen.Load();
        }
        private static void DeleteProfile(int id)
        {
            try
            {
                var repository = new Repository<Role>();
                repository.Delete(id);
                Console.WriteLine("Deleted successfully!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to delete the profile!");
            }
        }
    }
}