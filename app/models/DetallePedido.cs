
namespace backend_net.app.models;

public class DetallePedido
{
    public int IdDetallePedido { get; set; }

    public required float Cantidad { get; set; }

    public required int IdPedidoProveedor { get; set; }

    public PedidoProveedor? PedidoProveedor { get; set; }

    public required int IdPrenda { get; set; }

    public Prenda? Prenda { get; set; }
}

//NotMapped