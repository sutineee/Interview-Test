namespace Interview_Test.Models;

public class UserRoleMappingModel
{
    public string UserId { get; set; }
    public int RoleId { get; set; }
    public UserModel User { get; set; }
    public RoleModel Role { get; set; }
}