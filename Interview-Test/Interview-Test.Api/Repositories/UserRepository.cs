using Interview_Test.Infrastructure;
using Interview_Test.Models;
using Interview_Test.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Interview_Test.Repositories;

public class UserRepository : IUserRepository
{
    private readonly InterviewTestDbContext _context;

    public UserRepository(InterviewTestDbContext context)
    {
        _context = context;
    }

    public dynamic GetUserById(string id)
    {
        try
        {
            var data = _context.UserTb
                .Where(u => u.Id == Guid.Parse(id))
                .Select(u => new
                {
                    id = u.Id,
                    userID = u.UserId,
                    username = u.Username,
                    firstName = u.UserProfile.FirstName,
                    lastName = u.UserProfile.LastName,
                    age = u.UserProfile.Age,
                    roles = u.UserRoleMappings.Select(r => new { roleId = r.Role.RoleId, roleName = r.Role.RoleName }),
                    permissions = u.UserRoleMappings
                            .SelectMany(ur => ur.Role.Permissions.Select(p => p.Permission)).ToList().ToArray().Order().Distinct()

                })
                .SingleOrDefault();

            return data;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public int CreateUser(UserModel user)
    {
        try
        {
            _context.Add(user);
            return _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public int CreateUsers()
    {
        try
        {
            foreach (var user in Data.Users)
            {
                foreach (var usermaping in user.UserRoleMappings)
                {
                    _context.UserRoleMappingTb.Add(new UserRoleMappingModel { User = usermaping.User, Role = usermaping.Role });
                }
            }

            return _context.SaveChanges();
        }
        catch (DbUpdateException)
        {
            throw;
        }
        catch (Exception)
        {
            throw;
        }
    }
}