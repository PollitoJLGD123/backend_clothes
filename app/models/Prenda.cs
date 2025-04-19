
namespace backend_net.app.models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;

[Table("Prendas")]
public class Prenda{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPrenda { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Nombre { get; set; }

    [MaxLength(255)]
    [AllowNull]
    public string? Descripcion { get; set; }

    [AllowNull]
    [MaxLength(50)]
    public string? Color { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public required decimal Precio { get; set; }

    [AllowNull]
    [Column(TypeName = "int")]
    //[Range(0, 100)] rango de un numero
    public int? Stock { get; set; }

    [Required]
    //[ForeignKey("Marcas")]
    public required int IdMarca { get; set; }
    [ForeignKey("IdMarca")]
    public required Marca Marca { get; set; }

    [Required]
    //[ForeignKey("Categorias")]
    public required int IdCategoria { get; set; }
    [ForeignKey("IdCategoria")]
    public required Categoria Categoria { get; set; }

    [Required]
    //[ForeignKey("Tallas")]
    public required int IdTalla { get; set; }
    [ForeignKey("IdTalla")]
    public required Talla Talla { get; set; }

    [Required]
    public required int IdProveedor { get; set; }

    [ForeignKey("IdProveedor")]
    public required Proveedor Proveedor { get; set; }

    public ICollection<DetallePedido> DetallesPedidos { get; set; } = new List<DetallePedido>();

    public ICollection<DetalleEntrada> DetallesEntradas { get; set; } = new List<DetalleEntrada>();
}

//[AllowedValues("Rojo", "Azul", "Negro")] valores de cada campo que puede tener
//[Range(0, 100)] valor minimo y maximo de cada campo que puede tener

//public ICollection<Prenda> Prendas { get; set; } = new List<Prenda>(); para hacer una lista de prendas