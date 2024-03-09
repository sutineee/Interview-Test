using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interview_Test.Models;

public class UserProfileModel
{
    [Required]
    [Column(TypeName = "varchar(100)")]
    public string FirstName { get; set; }
    [Required]
    [Column(TypeName = "varchar(100)")]
    public string LastName { get; set; }
    public int? Age { get; set; }
}