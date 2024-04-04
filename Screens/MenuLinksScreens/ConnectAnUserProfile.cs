using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.MenuLinksScreens
{
    public static class ConnectAnUserProfile
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Which user and profile do you want to link?");
            Console.WriteLine("--------------------");
            Console.Write("User ID: ");
            var userID = int.Parse(Console.ReadLine());
            Console.Write("Role ID: ");
            var roleID = int.Parse(Console.ReadLine());
            LinkUserProfile(userID, roleID);
            Console.ReadKey();
            MenuLinksScreens.Load();
        }
        private static void LinkUserProfile(int userId, int roleId)
        {
            try
            {
                var userRepository = new UserRepository();
                userRepository.LinkUserProfile(userId, roleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("User won't linked");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }
        }
    }
}