
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Detalles_Ventas")]
public class DetalleVenta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdDetalleVenta { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public required float Cantidad { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public required float PrecioVentaReal { get; set; } // es el precio real que lo diste  en la venta, no el precio de la prenda
    //imaginemos que cobraste mas o menos 10% de descuento

    [Required]
    //[ForeignKey("Ventas")]
    public required int IdVenta { get; set; }

    [ForeignKey("IdVenta")]
    [AllowNull]
    public Venta Venta { get; set; }

    [Required]
    //[ForeignKey("Prendas")]
    public required int IdPrenda { get; set; }

    [ForeignKey("IdPrenda")]
    [AllowNull]
    public Prenda Prenda { get; set; }
}