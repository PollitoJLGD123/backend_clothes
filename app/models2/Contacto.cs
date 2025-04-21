
namespace backend_net.app.models2;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Contactos")]
public class Contacto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdContacto { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Apellido { get; set; }

    [Required]
    [Column(TypeName = "char(9)")]
    //[StringLength(9)] Otra manera de hacer maximo y minimo a la vez
    public required string Telefono { get; set; }

    [Required]
    [MaxLength(1000)]
    public required string Mensaje { get; set; }

    [Required]
    [EmailAddress]
    [Column(TypeName = "text")]
    public required string Email { get; set; }
}