
namespace backend_net.app.models2;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Categorias")]
public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCategoria { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nombre { get; set; }

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}