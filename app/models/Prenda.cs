
namespace backend_net.app.models;

public class Prenda{
    public int IdPrenda { get; set; }

    public required string Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Color { get; set; }

    public required decimal Precio { get; set; }

    public int? Stock { get; set; }

    public required int IdMarca { get; set; }

    public Marca? Marca { get; set; }

    public required int IdCategoria { get; set; }
    
    public Categoria? Categoria { get; set; }

    public required int IdTalla { get; set; }

    public Talla? Talla { get; set; }

    public required int IdProveedor { get; set; }

    public Proveedor? Proveedor { get; set; }

    public ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();

    public ICollection<DetalleEntrada> DetallesEntradas { get; set; } = new List<DetalleEntrada>();

    public ICollection<DetalleVenta> DetallesVentas { get; set; } = new List<DetalleVenta>();

}

//[AllowedValues("Rojo", "Azul", "Negro")] valores de cada campo que puede tener
//[Range(0, 100)] valor minimo y maximo de cada campo que puede tener

//public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>(); para hacer una lista de prendas