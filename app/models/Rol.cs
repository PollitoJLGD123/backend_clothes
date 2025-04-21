
namespace backend_net.app.models;

public class Rol
{
    public int IdRol { get; set; }

    public required string Nombre { get; set; }

    public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}