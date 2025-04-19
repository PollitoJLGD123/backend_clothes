namespace backend_net.app.models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Tallas")]
public class Talla
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTalla { get; set; }

    [Required]
    [MaxLength(50)]
    public required string NombreTalla { get; set; }

    [MaxLength(255)]
    [AllowNull]
    public string? Descripcion { get; set; }

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}