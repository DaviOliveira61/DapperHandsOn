using BaltaDataAccessHandsOn.Screens.MainMenuScreen;

namespace BaltaDataAccessHandsOn.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Tag managment");
            Console.WriteLine("------------------");
            Console.WriteLine("What you want to do?");
            Console.WriteLine();
            Console.WriteLine("1 - List all tags");
            Console.WriteLine("2 - Insert a new tag");
            Console.WriteLine("3 - Update a tag");
            Console.WriteLine("4 - Delete a tag");
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
                        ListTagScreen.Load();
                        break;
                    case 2:
                        CreateTagScreen.Load();
                        break;
                    case 3:
                        UpdateTagScreen.Load();
                        break;
                    case 4:
                        DeleteTagScreen.Load();
                        break;
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