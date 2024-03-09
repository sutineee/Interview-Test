using System.ComponentModel.DataAnnotations.Schema;

namespace Interview_Test.Models;

public class UserRoleMappingModel
{
    [ForeignKey("UserId")]
    public UserModel User { get; set; }
    [ForeignKey("RoleId")]
    public RoleModel Role { get; set; }
}