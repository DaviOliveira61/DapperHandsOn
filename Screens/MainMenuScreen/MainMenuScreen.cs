using BaltaDataAccessHandsOn.Screens.CategoryScreens;
using BaltaDataAccessHandsOn.Screens.ProfileScreens;
using BaltaDataAccessHandsOn.Screens.TagScreens;
using BaltaDataAccessHandsOn.Screens.UserScreens;
using BaltaDataAccessHandsOn.Screens.MenuLinksScreens;
using BaltaDataAccessHandsOn.Screens.PostScreens;

namespace BaltaDataAccessHandsOn.Screens.MainMenuScreen
{
    public static class MainMenuScreen
    {
        public static void Load()
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
                Console.WriteLine("8 - Post managment");
                Console.WriteLine("");
                Console.WriteLine("--------");
                Console.Write("Your choose: ");
                var option = short.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:
                        MenuUserScreen.Load();
                        break;
                    case 2:
                        MenuProfileScreen.Load();
                        break;
                    case 3:
                        MenuCategoryScreen.Load();
                        break;
                    case 4:
                        MenuTagScreen.Load();
                        break;
                    case 5:
                        ConnectAnUserProfile.Load();
                        break;
                    case 6:
                        // do something
                        break;
                    case 7:
                        // do something
                        break;
                    case 8:
                        MenuPostScreen.Load();
                        break;
                    default: Load(); break;
                }
            }
            catch (System.Exception)
            {
                Load();
            }

        }
    }
}