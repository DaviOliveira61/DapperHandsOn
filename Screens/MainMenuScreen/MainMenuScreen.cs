using BaltaDataAccessHandsOn.Screens.TagScreens;

namespace BaltaDataAccessHandsOn.Screens.MainMenuScreen
{
    public static class MainMenuScreen
    {
        public static void Show()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("My Blog");
                Console.WriteLine("-----------------");
                Console.WriteLine("What you want to do?");
                Console.WriteLine();
                Console.WriteLine("1 - User managment");
                Console.WriteLine("2 - Profile managment");
                Console.WriteLine("3 - Category managment");
                Console.WriteLine("4 - Tag managment");
                Console.WriteLine("5 - Link profile/user");
                Console.WriteLine("6 - Link post/tag");
                Console.WriteLine("7 - Reports");
                Console.WriteLine("");
                Console.WriteLine("--------");
                Console.Write("Your choose: ");
                var option = short.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 4:
                        MenuTagScreen.Load();
                        break;
                    default: Show(); break;
                }
            }
            catch (System.Exception)
            {
                Show();
            }

        }
    }
}