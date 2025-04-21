
namespace backend_net.app.models;

public class Marca
{
    public int IdMarca { get; set; }

    public required string Nombre { get; set; }

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}
