
namespace backend_net.app.models;

public class Entrada{
    public int IdEntrada { get; set; }

    public DateTime FechaEntrada { get; set; }

    public int IdProveedor { get; set; }

    public Proveedor? Proveedor { get; set; }

    public ICollection<DetalleEntrada> DetallesEntradas { get; set; } = new List<DetalleEntrada>();
}