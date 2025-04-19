
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Rols")]
public class Rol
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRol { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nombre { get; set; }

    public ICollection<User> Users { get; set; } = new List<User>();
}