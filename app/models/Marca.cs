
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Marcas")]
public class Marca
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdMarca { get; set; }

    [Required]
    [Column(TypeName = "varchar(50)")]
    public required string Nombre { get; set; }

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}
