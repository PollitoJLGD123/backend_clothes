
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

[Table("Ventas")]
public class Venta
{
    public int IdVenta { get; set; }

    public DateTime FechaVenta { get; set; }

    public required string DireccionVenta { get; set; }

    public decimal Total { get; set; }

    public required int IDCliente { get; set; }

    public Cliente? Cliente { get; set; }

    public required string MetodoPago { get; set; }

    public ICollection<DetalleVenta> DetallesVentas { get; set; } = new List<DetalleVenta>();
}

//[DefaultValue(false)]
//[DefaultValue(false)]
//[DefaultValue(false)]
//[DefaultValue(false)]
//[DefaultValue(false)]