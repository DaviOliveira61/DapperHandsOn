using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.ReportsScreen
{
    public static class ReportUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Press ESC to back to menu!");
            UserWithRole();
            Console.ReadKey();
            MenuReportScreen.Load();
        }
        private static void UserWithRole()
        {
            var repository = new UserRepository();
            var users = repository.GetWithRole();
            foreach (var item in users)
            {
                Console.Write($"{item.Name}, ");
                Console.WriteLine($"{item.Email} ");

                foreach (var role in item.Roles)
                {
                    if (role != null)
                        Console.Write($" {role.Name} ");
                }
                Console.WriteLine();
            }
        }
    }
}