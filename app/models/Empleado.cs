
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Empleados")]
public class Empleado
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdEmpleado { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Apellido { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Direccion { get; set; }

    [Required]
    [Column(TypeName = "char(9)")]
    public required string Telefono { get; set; }

    [Required]
    [Column(TypeName = "char(8)")]
    public required string DNI { get; set; }

    [Required]
    [EmailAddress]
    [Column(TypeName = "text")]
    public required string Email { get; set; }

    [AllowNull]
    [Column(TypeName = "text")]
    public string? ImagenPerfil { get; set; }

    [AllowNull]
    [Column(TypeName = "text")]
    public string? ImagenPerfilUrl { get; set; }

    [Required]
    //[ForeignKey("Users")]
    public required int IdUser { get; set; }

    [ForeignKey("IdUser")]
    [AllowNull]
    public User? User { get; set; }

    [Required]
    public required int IdRol { get; set; }

    [ForeignKey("IdRol")]
    [AllowNull]
    public Rol? Rol { get; set; }

}