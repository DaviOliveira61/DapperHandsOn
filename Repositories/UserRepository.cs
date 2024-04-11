using BaltaDataAccessHandsOn.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

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
                if (user.Id == userID)
                {
                    foreach (var roles in user.Roles)
                    {
                        if (roles != null)
                            roleId.Add(roles.Id);
                    }
                }
            }

            if (roleId.Contains(roleID) == false || roleId == null)
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
        public void DeleteUserRole(int id, bool isUser)
        {
            var sqlUser = "SELECT * FROM [UserRole] WHERE [UserId]=@id";
            var sqlRole = "SELECT * FROM [UserRole] WHERE [RoleId]=@id";
            var usersRoles = Database.Connection.Query(sqlUser, new
            {
                id
            });
            var roles = Database.Connection.Query(sqlRole, new
            {
                id
            });
            try
            {
                if (isUser == true)
                {

                    foreach (var users in usersRoles)
                    {
                        if (users.UserId == id)
                        {
                            var sqlDelete = "DELETE [UserRole] WHERE [UserId]=@id";
                            Database.Connection.Execute(sqlDelete, new
                            {
                                id
                            });
                        }
                    }
                }
                else
                {
                    foreach (var role in roles)
                    {
                        if (role.RoleId == id)
                        {
                            var sqlDelete = "DELETE [UserRole] WHERE [RoleId]=@id";
                            Database.Connection.Execute(sqlDelete, new
                            {
                                id
                            });
                        }
                    }
                }

            }
            catch (System.NullReferenceException)
            {

                Console.WriteLine("Unable to delete because this role doens't exist!");
            }

        }

    }
}