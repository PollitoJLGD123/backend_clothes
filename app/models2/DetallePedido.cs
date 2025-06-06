
namespace backend_net.app.models2;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Detalles_Pedidos")]
public class DetallePedido
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdDetallePedido { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public required float Cantidad { get; set; }

    [Required]
    //[ForeignKey("PedidosProveedores")]
    public required int IdPedidoProveedor { get; set; }

    [ForeignKey("IdPedidoProveedor")]
    [AllowNull]
    public PedidoProveedor PedidoProveedor { get; set; }

    [Required]
    //[ForeignKey("Prendas")]
    public required int IdPrenda { get; set; }

    [ForeignKey("IdPrenda")]
    [AllowNull]
    public Prenda Prenda { get; set; }
}

//NotMapped