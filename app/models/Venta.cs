
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

[Table("Ventas")]
public class Venta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdVenta { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    [DefaultValue(typeof(DateTime), "2025-02-02 00:00:00")]
    public DateTime FechaVenta { get; set; }

    [Required]
    [MaxLength(100)]
    public required string DireccionVenta { get; set; }

    [AllowNull]
    [Column(TypeName = "decimal(18,2)")]
    [DefaultValue(typeof(float), "0")]
    public float? Total { get; set; }

    [Required]
    //[ForeignKey("Clientes")]
    public required int IDCliente { get; set; }

    [ForeignKey("IDCliente")]
    public required Cliente Cliente { get; set; }
    
    [Required]
    [MaxLength(50)]
    public required string MetodoPago { get; set; }

    public ICollection<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
}

//[DefaultValue(false)]
//[DefaultValue(false)]
//[DefaultValue(false)]
//[DefaultValue(false)]
//[DefaultValue(false)]