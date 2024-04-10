using Dapper.Contrib.Extensions;

namespace BaltaDataAccessHandsOn.Models
{
    [Table("[PostTag]")]
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}