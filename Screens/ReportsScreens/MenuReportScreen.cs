namespace BaltaDataAccessHandsOn.Screens.ReportsScreen
{
    public static class MenuReportScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Reports managment");
            Console.WriteLine("------------------");
            Console.WriteLine("What you wish to do?");
            Console.WriteLine();
            Console.WriteLine("1 - List all users with profiles");
            Console.WriteLine("2 - List all categories and the amount of posts");
            Console.WriteLine("3 - List all tags with the amount of posts");
            Console.WriteLine("4 - List all posts of one category");
            Console.WriteLine("5 - List all posts with their tags");
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
                        ReportUserScreen.Load();
                        break;
                    // case 2:
                    //     CreateProfileScreen.Load();
                    //     break;
                    // case 3:
                    //     UpdateProfileScreen.Load();
                    //     break;
                    // case 4:
                    //     DeleteProfileScreen.Load();
                    //     break;
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