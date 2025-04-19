
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Entradas")]
public class Entrada{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdEntrada { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime FechaEntrada { get; set; }

    [Required]
    //[ForeignKey("Proveedores")]
    public int IdProveedor { get; set; }
    [ForeignKey("IdProveedor")]
    public required Proveedor Proveedor { get; set; }

    public ICollection<DetalleEntrada> DetallesEntrada { get; set; } = new List<DetalleEntrada>();
    

}