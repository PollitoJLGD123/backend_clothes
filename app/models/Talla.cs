namespace backend_net.app.models;

public class Talla
{
    public int IdTalla { get; set; }

    public required string NombreTalla { get; set; }

    public string? Descripcion { get; set; }

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}