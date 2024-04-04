using Dapper.Contrib.Extensions;

namespace BaltaDataAccessHandsOn.Models
{
    [Table("[UserRole]")]
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}