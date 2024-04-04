using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Delete an user");
            Console.WriteLine("-----------------");
            Console.Write("Which user ID do you want to delete? ");
            var id = int.Parse(Console.ReadLine());
            DeleteUser(id);
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void DeleteUser(int id)
        {
            try
            {
                var userRepository = new UserRepository();
                var repository = new Repository<User>();
                repository.Delete(id);
                userRepository.Delete(id);
                Console.WriteLine("Deleted successfully!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to delete the profile!");
            }
        }
    }
}