namespace backend_net.app.models2;

using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<User> Users { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<Empleado> Empleados { get; set; }
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
        modelBuilder.Entity<Reclamacion>().Property(p => p.FechaSolicitud).HasDefaultValueSql("CURRENT_TIMESTAMP");
        // para poner la fecha de la reclamacion con timestamp actual

        modelBuilder.Entity<User>().HasData(
            new User { IdUser = 1, Nombre = "Juan", Email= "jose@gmail.com", Password= BCrypt.HashPassword("123456789") },
            new User { IdUser = 2, Nombre = "Maria", Email= "maria@gmail.com", Password= BCrypt.HashPassword("987654321") },
            new User { IdUser = 3, Nombre = "Pedro", Email= "pedro@gmail.com", Password= BCrypt.HashPassword("456789123") }
        );

        modelBuilder.Entity<Rol>().HasData(
            new Rol { IdRol = 1, Nombre = "Administrador" },
            new Rol { IdRol = 2,  Nombre = "Usuario" }
        );

        modelBuilder.Entity<Empleado>().HasData(
            new Empleado {IdEmpleado = 1, Nombre = "Juan", Apellido = "Perez", Email= "jose@gmail.com", Telefono= "123456789", Direccion= "Av. Juan Perez 123", DNI = "23456789", IdUser = 1, IdRol = 1 },
            new Empleado { IdEmpleado = 2, Nombre = "Maria", Apellido = "Lopez", Email= "maria@gmail.com", Telefono= "987654321", Direccion= "Av. Maria Lopez 123", DNI = "87654321", IdUser = 2, IdRol = 1 },
            new Empleado { IdEmpleado = 3, Nombre = "Pedro", Apellido = "Rodriguez", Email= "pedro@gmail.com", Telefono= "456789123", Direccion= "Av. Pedro Rodriguez 123", DNI = "45789123", IdUser = 3, IdRol = 1 }
        );

        modelBuilder.Entity<Contacto>().HasData(
            new Contacto {IdContacto = 1, Nombre = "Rosa", Apellido = "Pari", Email= "rosa@gmail.com", Telefono= "985632147", 
            Mensaje= "Hola, tengo una consulta sobre un producto"},
            new Contacto { IdContacto = 2, Nombre = "Pedro", Apellido = "Rodriguez", Email= "pedro@gmail.com", Telefono= "456789123", 
            Mensaje= "Hola, tengo una consulta sobre un producto"},
            new Contacto { IdContacto = 3, Nombre = "Maria", Apellido = "Lopez", Email= "maria@gmail.com", Telefono= "987654321", 
            Mensaje= "Hola, tengo una consulta sobre un producto"}
        );

        modelBuilder.Entity<Reclamacion>().HasData(
            new Reclamacion
            {
                IdReclamacion = 1,
                Nombre = "Carlos",
                Apellido = "García",
                Direccion = "Av. Primavera 123",
                Ciudad = "Lima",
                Distrito = "Miraflores",
                Email = "carlos@gmail.com",
                Telefono = "987654321",
                TipoDocumento = "DNI",
                NumeroDocumento = "12345678",
                FechaIncidente = new DateTime(2024, 4, 1)
            },
            new Reclamacion
            {
                IdReclamacion = 2,
                Nombre = "Ana",
                Apellido = "Sánchez",
                Direccion = "Jr. Los Álamos 456",
                Ciudad = "Arequipa",
                Distrito = "Cercado",
                Email = "ana.sanchez@gmail.com",
                Telefono = "923456789",
                TipoDocumento = "RUC",
                NumeroDocumento = "20123456789",
                FechaIncidente = new DateTime(2024, 4, 5)
            },
            new Reclamacion
            {
                IdReclamacion = 3,
                Nombre = "Luis",
                Apellido = "Torres",
                Direccion = "Calle Las Flores 789",
                Ciudad = "Cusco",
                Distrito = "Wanchaq",
                Email = "luis.torres@gmail.com",
                Telefono = "956321478",
                TipoDocumento = "Pasaporte",
                NumeroDocumento = "P1234567",
                FechaIncidente = new DateTime(2024, 3, 28)
            }
        );
        
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { IdCategoria = 1, Nombre = "Camisas" },
            new Categoria { IdCategoria = 2, Nombre = "Pantalones" },
            new Categoria { IdCategoria = 3, Nombre = "Chaquetas" },
            new Categoria { IdCategoria = 4, Nombre = "Zapatos" },
            new Categoria { IdCategoria = 5, Nombre = "Accesorios" }
        );

        modelBuilder.Entity<Marca>().HasData(
            new Marca { IdMarca = 1, Nombre = "Nike"  },
            new Marca { IdMarca = 2, Nombre = "Reebok"  },
            new Marca { IdMarca = 3, Nombre = "Adidas"  },
            new Marca { IdMarca = 4, Nombre = "Puma"  },
            new Marca { IdMarca = 5, Nombre = "Element" },
            new Marca { IdMarca = 6, Nombre = "Vans"},
            new Marca { IdMarca = 7, Nombre = "Converse" },
            new Marca { IdMarca = 8, Nombre = "Fila" },
            new Marca { IdMarca = 9, Nombre = "Nike" }
        );

        modelBuilder.Entity<Talla>().HasData(
            new Talla { IdTalla = 1, NombreTalla = "S", Descripcion = "Talla Small"  },
            new Talla { IdTalla = 2, NombreTalla = "M", Descripcion = "Talla Medium"  },
            new Talla { IdTalla = 3, NombreTalla = "L", Descripcion = "Tala Large"  },
            new Talla { IdTalla = 4, NombreTalla = "XL", Descripcion = "Talla Extra Large"  },
            new Talla { IdTalla = 5, NombreTalla = "XXL", Descripcion = "Talla Extra Extra Large"  }
        );

        modelBuilder.Entity<Proveedor>().HasData(
            new Proveedor { IdProveedor = 1, Nombre = "Juan", Apellido = "Perez", Email= "jose@gmail.com", Telefono= "123456789", Direccion= "Av. Juan Perez 123", DNI = "23456789" },
            new Proveedor { IdProveedor = 2, Nombre = "Maria", Apellido = "Lopez", Email= "maria@gmail.com", Telefono= "987654321", Direccion= "Av. Maria Lopez 123", DNI = "87654321" },
            new Proveedor { IdProveedor = 3, Nombre = "Pedro", Apellido = "Rodriguez", Email= "pedro@gmail.com", Telefono= "456789123", Direccion= "Av. Pedro Rodriguez 123", DNI = "45689123" }
        );

        modelBuilder.Entity<Prenda>().HasData(
            new Prenda{ IdPrenda = 1, Nombre = "Camisa Jean", Descripcion = "Camisa de Jean para varón", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 2, Nombre = "Camiseta Jean", Descripcion = "Camiseta de Jean para varón", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 3, Nombre = "Casaca Jean", Descripcion = "Casaca de Jean Oversize", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 4, Nombre = "Pantalon exacto", Descripcion = "Pantalon exacto para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 5, Nombre = "Camisa Elegante", Descripcion = "Camisa Elegante para Hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },            
            new Prenda{ IdPrenda = 6, Nombre = "Zapatos de Vestir", Descripcion = "Zapatos de vestir para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 7, Nombre = "Zapatillas Adidas", Descripcion = "Zapatillas Adidas para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 8, Nombre = "Polo Estampado", Descripcion = "Polo de estampado para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 9, Nombre = "Polo Oversize", Descripcion = "Polo de oversize para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 10, Nombre = "Camiseta Maria", Descripcion = "Camiseta de Maria para varón", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 11, Nombre = "Chompa Abrigadora", Descripcion = "Chompa abrigadora para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 12, Nombre = "Pantalon Axios", Descripcion = "Pantalon para pedir peticiones", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda{ IdPrenda = 13, Nombre = "Pantalon Dress", Descripcion = "Pantalon comodo para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 }
        );

        modelBuilder.Entity<Entrada>().HasData(
            new Entrada { IdEntrada = 1, FechaEntrada = new DateTime(2024, 4, 1), IdProveedor = 1 },
            new Entrada { IdEntrada = 2, FechaEntrada = new DateTime(2024, 4, 2), IdProveedor = 2 },
            new Entrada { IdEntrada = 3, FechaEntrada = new DateTime(2024, 4, 3), IdProveedor = 3 }
        );

        modelBuilder.Entity<DetalleEntrada>().HasData(
            new DetalleEntrada { IdDetalleEntrada = 1, Cantidad = 30, PrecioCompra = 100, IdEntrada = 1, IdPrenda = 1 },
            new DetalleEntrada { IdDetalleEntrada = 2, Cantidad = 10, PrecioCompra = 100, IdEntrada = 1, IdPrenda = 2 },
            new DetalleEntrada { IdDetalleEntrada = 3, Cantidad = 10, PrecioCompra = 100, IdEntrada = 1, IdPrenda = 3 },
            new DetalleEntrada { IdDetalleEntrada = 4, Cantidad = 20, PrecioCompra = 100, IdEntrada = 2, IdPrenda = 4 },
            new DetalleEntrada { IdDetalleEntrada = 5, Cantidad = 10, PrecioCompra = 100, IdEntrada = 2, IdPrenda = 5 },
            new DetalleEntrada { IdDetalleEntrada = 6, Cantidad = 10, PrecioCompra = 100, IdEntrada = 2, IdPrenda = 6 },
            new DetalleEntrada { IdDetalleEntrada = 7, Cantidad = 22, PrecioCompra = 100, IdEntrada = 2, IdPrenda = 7 },
            new DetalleEntrada { IdDetalleEntrada = 8, Cantidad = 20, PrecioCompra = 100, IdEntrada = 3, IdPrenda = 8 },
            new DetalleEntrada { IdDetalleEntrada = 9, Cantidad = 11, PrecioCompra = 100, IdEntrada = 3, IdPrenda = 9 },            
            new DetalleEntrada { IdDetalleEntrada = 10, Cantidad = 8, PrecioCompra = 100, IdEntrada = 3, IdPrenda = 10 }
        );

        modelBuilder.Entity<PedidoProveedor>().HasData(
            new PedidoProveedor { IdPedidoProveedor = 1, FechaPedido = new DateTime(2024, 4, 1), IdProveedor = 1, Estado = "Pendiente" },
            new PedidoProveedor { IdPedidoProveedor = 2, FechaPedido = new DateTime(2024, 4, 2), IdProveedor = 2, Estado = "Pendiente" },
            new PedidoProveedor { IdPedidoProveedor = 3, FechaPedido = new DateTime(2024, 4, 3), IdProveedor = 3, Estado = "Recibido" }
        );

        modelBuilder.Entity<DetallePedido>().HasData(
            new DetallePedido { IdDetallePedido = 1, Cantidad = 30, IdPedidoProveedor = 1, IdPrenda = 1 },
            new DetallePedido { IdDetallePedido = 2, Cantidad = 10, IdPedidoProveedor = 1, IdPrenda = 2 },
            new DetallePedido { IdDetallePedido = 3, Cantidad = 10, IdPedidoProveedor = 1, IdPrenda = 3 },
            new DetallePedido { IdDetallePedido = 4, Cantidad = 20, IdPedidoProveedor = 2, IdPrenda = 4 },
            new DetallePedido { IdDetallePedido = 5, Cantidad = 10, IdPedidoProveedor = 2, IdPrenda = 5 },
            new DetallePedido { IdDetallePedido = 6, Cantidad = 10, IdPedidoProveedor = 2, IdPrenda = 6 },
            new DetallePedido { IdDetallePedido = 7, Cantidad = 22, IdPedidoProveedor = 2, IdPrenda = 7 },
            new DetallePedido { IdDetallePedido = 8, Cantidad = 20, IdPedidoProveedor = 3, IdPrenda = 8 },
            new DetallePedido { IdDetallePedido = 9, Cantidad = 11, IdPedidoProveedor = 3, IdPrenda = 9 },
            new DetallePedido { IdDetallePedido = 10, Cantidad = 8, IdPedidoProveedor = 3, IdPrenda = 10 }
        );

        modelBuilder.Entity<Cliente>().HasData(
            new Cliente { IdCliente = 1, Nombre = "Juan", Apellido = "Perez", Email= "jose@gmail.com", Telefono= "123456789", Direccion= "Av. Juan Perez 123", DNI = "74162314" },
            new Cliente { IdCliente = 2, Nombre = "Maria", Apellido = "Lopez", Email= "maria@gmail.com", Telefono= "987654321", Direccion= "Av. Maria Lopez 123", DNI = "52462314" },
            new Cliente { IdCliente = 3, Nombre = "Pedro", Apellido = "Rodriguez", Email= "pedro@gmail.com", Telefono= "456789123", Direccion= "Av. Pedro Rodriguez 123", DNI = "14762314" }
        );

        modelBuilder.Entity<Venta>().HasData(
            new Venta { IdVenta = 1, FechaVenta = new DateTime(2024, 4, 1), DireccionVenta = "Av. Juan Perez 123", Total = 100, IDCliente = 1, MetodoPago = "Efectivo"},
            new Venta { IdVenta = 2, FechaVenta = new DateTime(2024, 4, 2), DireccionVenta = "Av. Maria Lopez 123", Total = 100, IDCliente = 2, MetodoPago = "Tarjeta de Crédito"},
            new Venta { IdVenta = 3, FechaVenta = new DateTime(2024, 4, 3), DireccionVenta = "Av. Pedro Rodriguez 123", Total = 100, IDCliente = 3, MetodoPago = "Efectivo"}
        );

        modelBuilder.Entity<DetalleVenta>().HasData(
            new DetalleVenta { IdDetalleVenta = 1, Cantidad = 30, PrecioVentaReal = 100, IdVenta = 1, IdPrenda = 1 },
            new DetalleVenta { IdDetalleVenta = 2, Cantidad = 10, PrecioVentaReal = 100, IdVenta = 1, IdPrenda = 2 },
            new DetalleVenta { IdDetalleVenta = 3, Cantidad = 10, PrecioVentaReal = 100, IdVenta = 1, IdPrenda = 3 },
            new DetalleVenta { IdDetalleVenta = 4, Cantidad = 20, PrecioVentaReal = 100, IdVenta = 2, IdPrenda = 4 },
            new DetalleVenta { IdDetalleVenta = 5, Cantidad = 10, PrecioVentaReal = 100, IdVenta = 2, IdPrenda = 5 },
            new DetalleVenta { IdDetalleVenta = 6, Cantidad = 10, PrecioVentaReal = 100, IdVenta = 2, IdPrenda = 6 },
            new DetalleVenta { IdDetalleVenta = 7, Cantidad = 22, PrecioVentaReal = 100, IdVenta = 2, IdPrenda = 7 },
            new DetalleVenta { IdDetalleVenta = 8, Cantidad = 20, PrecioVentaReal = 100, IdVenta = 3, IdPrenda = 8 },
            new DetalleVenta { IdDetalleVenta = 9, Cantidad = 11, PrecioVentaReal = 100, IdVenta = 3, IdPrenda = 9 },            
            new DetalleVenta { IdDetalleVenta = 10, Cantidad = 8, PrecioVentaReal = 100, IdVenta = 3, IdPrenda = 10 }
        );
    }
}
