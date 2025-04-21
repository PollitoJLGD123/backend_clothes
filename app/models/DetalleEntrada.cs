
namespace backend_net.app.models;

public class DetalleEntrada
{
    public int IdDetalleEntrada { get; set; }

    public required float Cantidad { get; set; }

    public required decimal PrecioCompra { get; set; }

    public required int IdEntrada { get; set; }

    public Entrada? Entrada { get; set; }

    public required int IdPrenda { get; set; }

    public Prenda? Prenda { get; set; }
}