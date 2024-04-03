using BaltaDataAccessHandsOn.Models;
using BaltaDataAccessHandsOn.Repositories;

namespace BaltaDataAccessHandsOn.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Update tag");
            Console.WriteLine("-----------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Update(new Tag
            {
                Id = id,
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Update(tag);
                Console.WriteLine(tag.Name + " has been updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update " + tag.Name);
                Console.WriteLine(ex.Message);
            }
        }
    }
}