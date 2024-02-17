namespace Interview_Test.Models;

public class RoleModel
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public ICollection<string> Permissions { get; set; }
    public ICollection<UserRoleMappingModel> UserRoleMappings { get; set; }
}