namespace BaltaDataAccessHandsOn.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Post managment");
            Console.WriteLine("------------------");
            Console.WriteLine("What you want to do?");
            Console.WriteLine();
            Console.WriteLine("1 - Create a post");
            Console.WriteLine("2 - Edit some post");
            Console.WriteLine("3 - Delete a post");
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
                        CreatePostScreen.Load();
                        break;
                    case 2:
                        UpdatePostScreen.Load();
                        break;
                    case 3:
                        DeletePostScreen.Load();
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