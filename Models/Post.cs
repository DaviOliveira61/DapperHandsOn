using Dapper.Contrib.Extensions;

namespace BaltaDataAccessHandsOn.Models
{
    [Table("[Post]")] //IMPORTANT: Check out the using. This is a requirement for Dapper Contrib search correctly
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}