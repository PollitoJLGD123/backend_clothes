
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Detalles_Ventas")]
public class DetalleVenta
{
    public int IdDetalleVenta { get; set; }

    public required float Cantidad { get; set; }

    public required decimal PrecioVentaReal { get; set; } // es el precio real que lo diste  en la venta, no el precio de la prenda
    //imaginemos que cobraste mas o menos 10% de descuento

    public required int IdVenta { get; set; }

    public Venta? Venta { get; set; }

    public required int IdPrenda { get; set; }

    public Prenda? Prenda { get; set; }
}