
namespace backend_net.app.models2;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Proveedores")]
public class Proveedor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdProveedor { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Apellido { get; set; }

    [AllowNull]
    [MaxLength(100)]
    public string? Direccion { get; set; }

    [Required]
    //[Column(TypeName = "char(9)")] otra manera de hacer maximo
    [StringLength(9)] //maximo y minimo xd :V
    public required string Telefono { get; set; }

    [Required]
    [Column(TypeName = "char(8)")]
    public required string DNI { get; set; }

    [Required]
    [EmailAddress]
    [Column(TypeName = "text")]
    public required string Email { get; set; }

    public ICollection<PedidoProveedor> PedidosProveedor { get; set; } = new List<PedidoProveedor>();

    public ICollection<Entrada> Entradas { get; set; } = new List<Entrada>();

    public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}