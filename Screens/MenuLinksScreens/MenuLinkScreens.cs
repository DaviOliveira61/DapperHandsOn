namespace BaltaDataAccessHandsOn.Screens.MenuLinksScreens
{
    public class MenuLinksScreens
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Links managment");
            Console.WriteLine("------------------");
            Console.WriteLine("What you want to do?");
            Console.WriteLine();
            Console.WriteLine("1 - Link an user to a profile");
            Console.WriteLine("2 - Link a post with a tag");
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
                        ConnectAnUserProfile.Load();
                        break;
                    // case 2:
                    //     // CreateUserScreen.Load();
                    //     break;
                    case 0:
                        MainMenuScreen.MainMenuScreen.Show();
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