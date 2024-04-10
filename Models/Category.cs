using System.Collections.Generic;
using BaltaDataAccessHandsOn.Repositories;
using Dapper.Contrib.Extensions;

namespace BaltaDataAccessHandsOn.Models
{
    [Table("[Category]")]
    public class Category
    {
        public Category() => Posts = new List<Post>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post> Posts { get; set; }


        public void insertAPost(Post post, int id)
        {
            var repository = new Repository<Category>();
            var categories = repository.Get();
            foreach (var item in categories)
                if (item.Id == id)
                    Posts.Add(post);
        }
    }
}