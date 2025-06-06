
namespace backend_net.app.models;

public class Proveedor
{
    public int IdProveedor { get; set; }

    public required string Nombre { get; set; }

    public required string Apellido { get; set; }

    public string? Direccion { get; set; }

    public required string Telefono { get; set; }

    public required string DNI { get; set; }

    public required string Email { get; set; }

    public ICollection<PedidoProveedor> PedidosProveedor { get; set; } = new List<PedidoProveedor>();

    public ICollection<Entrada> Entradas { get; set; } = new List<Entrada>();

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}