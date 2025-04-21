
namespace backend_net.app.models2;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Options;

[Table("Pedidos_Proveedores")]
public class PedidoProveedor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPedidoProveedor { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime FechaPedido { get; set; }

    [ForeignKey("IdProveedor")]
    [AllowNull]
    public Proveedor Proveedor { get; set; }
    [Required]
    public required int IdProveedor { get; set; }

    [Required]
    [MaxLength(50)]
    [AllowedValues("Pendiente", "Enviado", "Recibido", "Anulado")]
    [Column(TypeName = "ENUM('Pendiente', 'Enviado', 'Recibido', 'Anulado')")]
    public required string Estado { get; set; }

    public ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();
}

//public DateTime FechaPedido { get; set; } = DateTime.Now;