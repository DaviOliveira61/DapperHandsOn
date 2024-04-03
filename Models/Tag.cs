using Dapper.Contrib.Extensions;

namespace BaltaDataAccessHandsOn.Models
{
    [Table("[Tag]")] //IMPORTANT: Check out the using. This is a requirement for Dapper Contrib search correctly
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}