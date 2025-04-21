
namespace backend_net.app.models;

public class Categoria
{
    public int IdCategoria { get; set; }

    public required string Nombre { get; set; }

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}