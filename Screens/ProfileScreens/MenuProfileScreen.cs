namespace BaltaDataAccessHandsOn.Screens.ProfileScreens
{
    public class MenuProfileScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Profile managment");
            Console.WriteLine("------------------");
            Console.WriteLine("What you want to do?");
            Console.WriteLine();
            Console.WriteLine("1 - List all profiles");
            Console.WriteLine("2 - Insert a new profile");
            Console.WriteLine("3 - Update a profile");
            Console.WriteLine("4 - Delete a profile");
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
                        ListProfileScreen.Load();
                        break;
                    case 2:
                        CreateProfileScreen.Load();
                        break;
                    case 3:
                        UpdateProfileScreen.Load();
                        break;
                    case 4:
                        DeleteProfileScreen.Load();
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