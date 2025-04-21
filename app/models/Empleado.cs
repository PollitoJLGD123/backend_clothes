
namespace backend_net.app.models;

public class Empleado
{
    public int IdEmpleado { get; set; }

    public required string Nombre { get; set; }

    public required string Apellido { get; set; }

    public required string Direccion { get; set; }

    public required string Telefono { get; set; }

    public required string DNI { get; set; }

    public required string Email { get; set; }

    public string? ImagenPerfil { get; set; }

    public string? ImagenPerfilUrl { get; set; }

    public required int IdUser { get; set; }

    public User? User { get; set; }

    public required int IdRol { get; set; }

    public Rol? Rol { get; set; }

}