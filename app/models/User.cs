
namespace backend_net.app.models;

public class User
{
    public int IdUser { get; set; }

    public required string Nombre { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

    public string? Token { get; set; }

    public Empleado? Empleado { get; set; }
}