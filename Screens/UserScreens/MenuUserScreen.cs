namespace BaltaDataAccessHandsOn.Screens.UserScreens
{
    public class MenuUserScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("User managment");
            Console.WriteLine("------------------");
            Console.WriteLine("What you want to do?");
            Console.WriteLine();
            Console.WriteLine("1 - List all users");
            Console.WriteLine("2 - Insert a new user");
            Console.WriteLine("3 - Update an user");
            Console.WriteLine("4 - Delete an user");
            Console.WriteLine("0 - Back to the main menu");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.Write("Your choose: ");
            try
            {
                var shortOption = short.Parse(Console.ReadLine());
                switch (shortOption)
                {
                    case 1:
                        ListUserScreen.Load();
                        break;
                    case 2:
                        CreateUserScreen.Load();
                        break;
                    case 3:
                        UpdateUserScreen.Load();
                        break;
                    case 4:
                        DeleteUserScreen.Load();
                        break;
                    case 0:
                        MainMenuScreen.MainMenuScreen.Load();
                        break;
                    default: Load(); break;
                }
            }
            catch (Exception ex)
            {
                Load();
            }

        }
    }
}