namespace backend_net.app.models2;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

[Table("Clientes")]
public class Cliente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCliente { get; set; }

    [Required]
    [Column(TypeName = "varchar(50)")]
    public required string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Apellido { get; set; }

    [AllowNull]
    [EmailAddress]
    [Column(TypeName = "text")]
    public string? Email { get; set; }

    [Required]
    [Column(TypeName = "char(9)")]
    //[StringLength(9)] Otra manera de hacer maximo
    public required string Telefono { get; set; }

    [AllowNull]
    [MaxLength(100)]
    public string? Direccion { get; set; }

    [Required]
    [Column(TypeName = "char(8)")]
    //[StringLength(8)] Otra manera de hacer maximo
    public required string DNI { get; set; }

    public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
}
