using System.ComponentModel.DataAnnotations;

namespace Interview_Test.Models;

public class UserModel
{
    public string Id { get; set; }
    public string Username { get; set; }
    [Required]
    public UserProfileModel UserProfile { get; set; }
    [Required]
    public ICollection<UserRoleMappingModel> UserRoleMappings { get; set; }
}