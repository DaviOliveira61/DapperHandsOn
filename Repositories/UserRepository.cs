using BaltaDataAccessHandsOn.Models;
using Dapper;

namespace BaltaDataAccessHandsOn.Repositories
{
    public class UserRepository : Repository<User>
    {
        public List<User> GetWithRole()
        {
            var query = @"
                SELECT 
                    [User].*,
                    [Role].*
                FROM
                    [User]
                LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";
            var users = new List<User>();
            var items = Database.Connection.Query<User, Role, User>(
                query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr == null)
                    {
                        usr = user;
                        if (role != null)
                            usr.Roles.Add(role);

                        users.Add(usr);
                    }
                    else
                        usr.Roles.Add(role);

                    return user;
                }, splitOn: "Id");
            return users;
        }
        public void LinkUserProfile(int userID, int roleID)
        {
            var verifyUserProfile = GetWithRole();
            // List<int> userId = new List<int>();
            List<int> roleId = new List<int>();
            foreach (var user in verifyUserProfile)
            {
                // Console.WriteLine($"{user.Name}");
                // userId.Add(user.Id);
                foreach (var roles in user.Roles)
                {
                    // Console.WriteLine($"{roles.Name}");
                    roleId.Add(roles.Id);
                }
            }

            if (roleId.Contains(roleID) == false)
            {
                var repository = new Repository<UserRole>();
                var userRole = new UserRole
                {
                    RoleId = roleID,
                    UserId = userID
                };
                repository.Create(userRole);
                Console.WriteLine("User was linked successfully!");
            }
            else
            {
                Console.WriteLine("The user had this profile.");
            }
        }

    }
}