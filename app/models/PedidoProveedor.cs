
namespace backend_net.app.models;

public class PedidoProveedor
{
    public int IdPedidoProveedor { get; set; }

    public DateTime FechaPedido { get; set; }

    public Proveedor? Proveedor { get; set; }

    public required int IdProveedor { get; set; }

    public required string Estado { get; set; }

    public ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();
}

//public DateTime FechaPedido { get; set; } = DateTime.Now;