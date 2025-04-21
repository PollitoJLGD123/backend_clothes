
namespace backend_net.app.models;

public class Reclamacion
{
    public int IdReclamacion { get; set; }

    public required string Nombre { get; set; }

    public required string Apellido { get; set; }

    public required string Direccion { get; set; }

    public required string Ciudad { get; set; }

    public required string Distrito { get; set; }

    public string? Email { get; set; }

    public required string Telefono { get; set; }

    public required string TipoDocumento { get; set; }

    public required string NumeroDocumento { get; set; }

    public DateTime FechaIncidente { get; set; }

    public DateTime FechaSolicitud { get; set; } = DateTime.Now;
}

