
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUser { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nombre { get; set; }

    [Required]
    [EmailAddress]
    [Column(TypeName = "text")]
    public required string Email { get; set; }

    [Required]
    [Column(TypeName = "varchar(255)")]
    public required string Password { get; set; }

    [AllowNull]
    [Column(TypeName = "text")]
    public string? Token { get; set; }

    [AllowNull]
    public Empleado? Empleado { get; set; }
}