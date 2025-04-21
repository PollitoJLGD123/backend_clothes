namespace backend_net.app.models;

public class Cliente
{
    public int IdCliente { get; set; }

    public required string Nombre { get; set; }

    public required string Apellido { get; set; }

    public string? Email { get; set; }

    //[StringLength(9)] Otra manera de hacer maximo
    public required string Telefono { get; set; }

    public string? Direccion { get; set; }


    //[StringLength(8)] Otra manera de hacer maximo
    public required string DNI { get; set; }

    public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
}
