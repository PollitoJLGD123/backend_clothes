
namespace backend_net.app.models;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Reclamaciones")]
public class Reclamacion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdReclamacion { get; set; }

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
    [MaxLength(100)]
    public required string Ciudad { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Distrito { get; set; }

    [AllowNull]
    [EmailAddress]
    [Column(TypeName = "text")]
    public string? Email { get; set; }

    [Required]
    [Column(TypeName = "char(9)")]
    //[StringLength(9)] Otra manera de hacer maximo
    public required string Telefono { get; set; }

    [Required]
    [AllowedValues("DNI", "RUC", "Pasaporte")]
    [Column(TypeName = "ENUM('DNI', 'RUC', 'Pasaporte')")]
    public required string TipoDocumento { get; set; }

    [Required]
    [Column(TypeName = "varchar(30)")]
    public required string NumeroDocumento { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime FechaIncidente { get; set; }

    [AllowNull]
    [Column(TypeName = "datetime")]
    [DefaultValue(typeof(DateTime), "GETDATE()")]
    public DateTime FechaSolicitud { get; set; } = DateTime.Now;
}

