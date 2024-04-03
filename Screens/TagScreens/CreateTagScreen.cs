using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("New tag");
            Console.WriteLine("-----------");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Create(tag);
                Console.WriteLine(tag.Name + " has been registered successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to register " + tag.Name);
                Console.WriteLine(ex.Message);
            }
        }
    }
}