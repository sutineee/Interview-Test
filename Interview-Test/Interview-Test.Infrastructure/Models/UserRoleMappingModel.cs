using System.ComponentModel.DataAnnotations.Schema;

namespace Interview_Test.Models;

[Table("UserRoleMappingTb")]
public class UserRoleMappingModel
{
    [ForeignKey("Id")]
    public UserModel User { get; set; }
    [ForeignKey("RoleId")]
    public RoleModel Role { get; set; }
}