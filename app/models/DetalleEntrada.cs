
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Detalles_Entradas")]
public class DetalleEntrada
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdDetalleEntrada { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public required float Cantidad { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public required float PrecioCompra { get; set; }

    [Required]
    //[ForeignKey("Entradas")]
    public required int IdEntrada { get; set; }

    [ForeignKey("IdEntrada")]
    public required Entrada Entrada { get; set; }

    [Required]
    //[ForeignKey("Prendas")]
    public required int IdPrenda { get; set; }

    [ForeignKey("IdPrenda")]
    public required Prenda Prenda { get; set; }
}