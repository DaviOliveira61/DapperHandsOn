using Dapper.Contrib.Extensions;

namespace BaltaDataAccessHandsOn.Models
{
    [Table("[User]")] //IMPORTANT: Check out the using. This is a requirement for Dapper Contrib search correctly
    public class User
    {
        public User() => Roles = new List<Role>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<Role> Roles { get; set; }
    }
}