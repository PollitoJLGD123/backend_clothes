namespace backend_net.app.models;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Talla> Tallas { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Prenda> Prendas { get; set; }
    public DbSet<Entrada> Entradas { get; set; }
    public DbSet<DetalleEntrada> DetallesEntradas { get; set; }
    public DbSet<Venta> Ventas { get; set; }
    public DbSet<DetalleVenta> DetallesVentas { get; set; }
    public DbSet<PedidoProveedor> PedidosProveedores { get; set; }
    public DbSet<DetallePedido> DetallePedidos { get; set; }
    public DbSet<Contacto> Contactos { get; set; }
    public DbSet<Reclamacion> Reclamaciones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Cliente>().HasData(
            new Cliente { Nombre = "Juan", Apellido = "Perez", Email= "jose@gmail.com", Telefono= "123456789", Direccion= "Av. Juan Perez 123", DNI = "123456789" },
            new Cliente { Nombre = "Maria", Apellido = "Lopez", Email= "maria@gmail.com", Telefono= "987654321", Direccion= "Av. Maria Lopez 123", DNI = "987654321" },
            new Cliente { Nombre = "Pedro", Apellido = "Rodriguez", Email= "pedro@gmail.com", Telefono= "456789123", Direccion= "Av. Pedro Rodriguez 123", DNI = "456789123" }
        ); 
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Nombre = "Pantalones" },
            new Categoria { Nombre = "Polos" },
            new Categoria { Nombre = "Camisas" },
            new Categoria { Nombre = "Zapatos" },
            new Categoria { Nombre = "Chaquetas" },
            new Categoria { Nombre = "Camisetas" },
            new Categoria { Nombre = "Sweatshirts" }
        );
        modelBuilder.Entity<Proveedor>().HasData(
            new Proveedor { Nombre = "Juan", Apellido = "Perez", Email= "jose@gmail.com", Telefono= "123456789", Direccion= "Av. Juan Perez 123", DNI = "123456789" },
            new Proveedor { Nombre = "Maria", Apellido = "Lopez", Email= "maria@gmail.com", Telefono= "987654321", Direccion= "Av. Maria Lopez 123", DNI = "987654321" },
            new Proveedor { Nombre = "Pedro", Apellido = "Rodriguez", Email= "pedro@gmail.com", Telefono= "456789123", Direccion= "Av. Pedro Rodriguez 123", DNI = "456789123" }
        );

        modelBuilder.Entity<Talla>().HasData(
            new Talla { NombreTalla = "S", Descripcion = "Talla Small"  },
            new Talla { NombreTalla = "M", Descripcion = "Talla Medium"  },
            new Talla { NombreTalla = "L", Descripcion = "Tala Large"  },
            new Talla { NombreTalla = "XL", Descripcion = "Talla Extra Large"  },
            new Talla { NombreTalla = "XXL", Descripcion = "Talla Extra Extra Large"  }
        );

        modelBuilder.Entity<Marca>().HasData(
            new Marca { Nombre = "Nike"  },
            new Marca { Nombre = "Reebok"  },
            new Marca { Nombre = "Adidas"  },
            new Marca { Nombre = "Puma"  },
            new Marca { Nombre = "Element" },
            new Marca { Nombre = "Vans"},
            new Marca { Nombre = "Converse" },
            new Marca { Nombre = "Fila" },
            new Marca { Nombre = "Nike" }
        );

        modelBuilder.Entity<Prenda>().HasData(
            new Prenda{ Nombre = "Camisa Jean", Descripcion = "Camisa de Jean para varón", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1
            }
        );
    }
}
