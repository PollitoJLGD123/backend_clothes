
namespace backend_net.app.models;

public class Contacto
{
    public int IdContacto { get; set; }

    public required string Nombre { get; set; }

    public required string Apellido { get; set; }

    public required string Telefono { get; set; }

    public required string Mensaje { get; set; }

    public required string Email { get; set; }
}