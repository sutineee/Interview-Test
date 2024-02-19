using Interview_Test.Repositories.Interfaces;

namespace Interview_Test.Repositories;

public class UserRepository : IUserRepository
{
    public dynamic GetUserById(string id)
    {
         try
         {
             var data = Data.Users.Select(u => new
             {
                 id = u.Id,
                 username = u.Username,
                 firstName = u.UserProfile.FirstName,
                 lastName = u.UserProfile.LastName,
                 age = u.UserProfile.Age,
                 roles = u.UserRoleMappings.Select(r => new { roleId = r.Role.RoleId, roleName = r.Role.RoleName }),
                 permissions = u.UserRoleMappings.SelectMany(p => p.Role.Permissions).Distinct().Order()
             }).Where(u => u.id == id).SingleOrDefault();
             return data;
         }
         catch (Exception) 
         {
             throw;
         }
    }
}
