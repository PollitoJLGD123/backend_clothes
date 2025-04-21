
namespace backend_net.app.models;

using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

public class DataDbContext : DbContext
{
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(user =>
        {
            user.ToTable("Users");
            user.HasKey(u => u.IdUser);
            user.Property(u => u.IdUser).ValueGeneratedOnAdd();
            user.Property(u => u.Nombre).IsRequired().HasMaxLength(50);
            user.Property(u => u.Email).IsRequired().HasColumnType("text");
            user.Property(u => u.Password).IsRequired().HasMaxLength(255);
            user.Property(u => u.Token).HasColumnType("text");
        });

        modelBuilder.Entity<Rol>(rol =>
        {
            rol.ToTable("Roles");
            rol.HasKey(r => r.IdRol);
            rol.Property(r => r.IdRol).ValueGeneratedOnAdd();
            rol.Property(r => r.Nombre).IsRequired().HasMaxLength(50);
        });

        modelBuilder.Entity<Empleado>(empleado =>
        {
            empleado.ToTable("Empleados");
            empleado.HasKey(e => e.IdEmpleado);
            empleado.Property(e => e.IdEmpleado).ValueGeneratedOnAdd();
            empleado.Property(e => e.Nombre).IsRequired().HasMaxLength(50);
            empleado.Property(e => e.Apellido).IsRequired().HasMaxLength(50);
            empleado.Property(e => e.Email).IsRequired().HasColumnType("text");
            empleado.Property(e => e.Telefono).IsRequired().HasColumnType("char(9)");
            empleado.Property(e => e.Direccion).IsRequired().HasMaxLength(100);
            empleado.Property(e => e.DNI).IsRequired().HasColumnType("char(8)");
            empleado.Property(e => e.ImagenPerfil).HasColumnType("text");
            empleado.Property(e => e.ImagenPerfilUrl).HasColumnType("text");
            empleado.HasOne(e => e.User).WithOne(u => u.Empleado).HasForeignKey<Empleado>(e => e.IdUser);
            empleado.HasOne(e => e.Rol).WithMany(r => r.Empleados).HasForeignKey(e => e.IdRol);
        });

        modelBuilder.Entity<Cliente>(cliente =>
        {
            cliente.ToTable("Clientes");
            cliente.HasKey(c => c.IdCliente);
            cliente.Property(c => c.IdCliente).ValueGeneratedOnAdd();
            cliente.Property(c => c.Nombre).IsRequired().HasMaxLength(50);
            cliente.Property(c => c.Apellido).IsRequired().HasMaxLength(50);
            cliente.Property(c => c.Email).IsRequired().HasColumnType("text");
            cliente.Property(c => c.Telefono).IsRequired().HasColumnType("char(9)");
            cliente.Property(c => c.Direccion).IsRequired().HasMaxLength(100);
            cliente.Property(c => c.DNI).IsRequired().HasColumnType("char(8)");
        });

        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categorias");
            categoria.HasKey(c => c.IdCategoria);
            categoria.Property(c => c.IdCategoria).ValueGeneratedOnAdd();
            categoria.Property(c => c.Nombre).IsRequired().HasMaxLength(50);
        });

        modelBuilder.Entity<Proveedor>(proveedor =>
        {
            proveedor.ToTable("Proveedores");
            proveedor.HasKey(p => p.IdProveedor);
            proveedor.Property(p => p.IdProveedor).ValueGeneratedOnAdd();
            proveedor.Property(p => p.Nombre).IsRequired().HasMaxLength(50);
            proveedor.Property(p => p.Apellido).IsRequired().HasMaxLength(50);
            proveedor.Property(p => p.Email).IsRequired().HasColumnType("text");
            proveedor.Property(p => p.Telefono).IsRequired().HasColumnType("char(9)");
            proveedor.Property(p => p.Direccion).HasMaxLength(100);
            proveedor.Property(p => p.DNI).IsRequired().HasColumnType("char(8)");
        });

        modelBuilder.Entity<Talla>(talla =>
        {
            talla.ToTable("Tallas");
            talla.HasKey(t => t.IdTalla);
            talla.Property(t => t.IdTalla).ValueGeneratedOnAdd();
            talla.Property(t => t.NombreTalla).IsRequired().HasMaxLength(50);
            talla.Property(t => t.Descripcion).IsRequired().HasMaxLength(255);
        });

        modelBuilder.Entity<Marca>(marca =>
        {
            marca.ToTable("Marcas");
            marca.HasKey(m => m.IdMarca);
            marca.Property(m => m.IdMarca).ValueGeneratedOnAdd();
            marca.Property(m => m.Nombre).IsRequired().HasMaxLength(50);
        });

        modelBuilder.Entity<Prenda>(prenda =>
        {
            prenda.ToTable("Prendas");
            prenda.HasKey(p => p.IdPrenda);
            prenda.Property(p => p.IdPrenda).ValueGeneratedOnAdd();
            prenda.Property(p => p.Nombre).IsRequired().HasMaxLength(50);
            prenda.Property(p => p.Descripcion).IsRequired().HasMaxLength(255);
            prenda.Property(p => p.Color).IsRequired().HasMaxLength(255);
            prenda.Property(p => p.Precio).IsRequired().HasColumnType("decimal(18,2)");
            prenda.Property(p => p.Stock).IsRequired();
            prenda.HasOne(p => p.Marca).WithMany(m => m.Prendas).HasForeignKey(p => p.IdMarca);
            prenda.HasOne(p => p.Categoria).WithMany(c => c.Prendas).HasForeignKey(p => p.IdCategoria);
            prenda.HasOne(p => p.Talla).WithMany(t => t.Prendas).HasForeignKey(p => p.IdTalla);
            prenda.HasOne(p => p.Proveedor).WithMany(p => p.Prendas).HasForeignKey(p => p.IdProveedor);
        });

        modelBuilder.Entity<Entrada>(entrada =>
        {
            entrada.ToTable("Entradas");
            entrada.HasKey(e => e.IdEntrada);
            entrada.Property(e => e.IdEntrada).ValueGeneratedOnAdd();
            entrada.Property(e => e.FechaEntrada).IsRequired();
            entrada.HasOne(e => e.Proveedor).WithMany(p => p.Entradas).HasForeignKey(e => e.IdProveedor);
        });

        modelBuilder.Entity<DetalleEntrada>(detalleEntrada =>
        {
            detalleEntrada.ToTable("DetallesEntradas");
            detalleEntrada.HasKey(de => de.IdDetalleEntrada);
            detalleEntrada.Property(de => de.IdDetalleEntrada).ValueGeneratedOnAdd();
            detalleEntrada.Property(de => de.Cantidad).IsRequired();
            detalleEntrada.Property(de => de.PrecioCompra).IsRequired().HasColumnType("decimal(18,2)");
            detalleEntrada.HasOne(de => de.Entrada).WithMany(e => e.DetallesEntradas).HasForeignKey(de => de.IdEntrada);
            detalleEntrada.HasOne(de => de.Prenda).WithMany(p => p.DetallesEntradas).HasForeignKey(de => de.IdPrenda);
        });

        modelBuilder.Entity<Venta>(venta =>
        {
            venta.ToTable("Ventas");
            venta.HasKey(v => v.IdVenta);
            venta.Property(v => v.IdVenta).ValueGeneratedOnAdd();
            venta.Property(v => v.FechaVenta).IsRequired();
            venta.Property(v => v.DireccionVenta).IsRequired().HasMaxLength(100);
            venta.Property(v => v.Total).HasColumnType("decimal(18,2)").HasDefaultValue(0m);
            venta.Property(v => v.MetodoPago).IsRequired().HasMaxLength(50);
            venta.HasOne(v => v.Cliente).WithMany(c => c.Ventas).HasForeignKey(v => v.IDCliente);
        });

        modelBuilder.Entity<DetalleVenta>(detalleVenta =>
        {
            detalleVenta.ToTable("DetallesVentas");
            detalleVenta.HasKey(dv => dv.IdDetalleVenta);
            detalleVenta.Property(dv => dv.IdDetalleVenta).ValueGeneratedOnAdd();
            detalleVenta.Property(dv => dv.Cantidad).IsRequired();
            detalleVenta.Property(dv => dv.PrecioVentaReal).IsRequired().HasColumnType("decimal(18,2)");
            detalleVenta.HasOne(dv => dv.Prenda).WithMany(p => p.DetallesVentas).HasForeignKey(dv => dv.IdPrenda);
            detalleVenta.HasOne(dv => dv.Venta).WithMany(v => v.DetallesVentas).HasForeignKey(dv => dv.IdVenta);
        });

        modelBuilder.Entity<PedidoProveedor>(pedidoProveedor =>
        {
            pedidoProveedor.ToTable("PedidosProveedores");
            pedidoProveedor.HasKey(pp => pp.IdPedidoProveedor);
            pedidoProveedor.Property(pp => pp.IdPedidoProveedor).ValueGeneratedOnAdd();
            pedidoProveedor.Property(pp => pp.FechaPedido).IsRequired();
            pedidoProveedor.HasOne(pp => pp.Proveedor).WithMany(p => p.PedidosProveedor).HasForeignKey(pp => pp.IdProveedor);
            pedidoProveedor.Property(pp => pp.Estado).IsRequired().HasColumnType("ENUM('Pendiente', 'Enviado', 'Recibido', 'Anulado')").HasDefaultValue("Pendiente");
        });

        modelBuilder.Entity<DetallePedido>(detallePedido =>
        {
            detallePedido.ToTable("DetallesPedidos");
            detallePedido.HasKey(dp => dp.IdDetallePedido);
            detallePedido.Property(dp => dp.IdDetallePedido).ValueGeneratedOnAdd();
            detallePedido.Property(dp => dp.Cantidad).IsRequired();
            detallePedido.HasOne(dp => dp.PedidoProveedor).WithMany(p => p.DetallesPedidos).HasForeignKey(dp => dp.IdPedidoProveedor);
            detallePedido.HasOne(dp => dp.Prenda).WithMany(p => p.DetallesPedidos).HasForeignKey(dp => dp.IdPrenda);
        });

        modelBuilder.Entity<Contacto>(contacto =>
        {
            contacto.ToTable("Contactos");
            contacto.HasKey(c => c.IdContacto);
            contacto.Property(c => c.IdContacto).ValueGeneratedOnAdd();
            contacto.Property(c => c.Nombre).IsRequired().HasMaxLength(50);
            contacto.Property(c => c.Apellido).IsRequired().HasMaxLength(50);
            contacto.Property(c => c.Telefono).IsRequired().HasColumnType("char(9)");
            contacto.Property(c => c.Mensaje).IsRequired().HasMaxLength(1000);
            contacto.Property(c => c.Email).IsRequired().HasColumnType("text");
        });

        modelBuilder.Entity<Reclamacion>(reclamacion =>
        {
            reclamacion.ToTable("Reclamaciones");
            reclamacion.HasKey(r => r.IdReclamacion);
            reclamacion.Property(r => r.IdReclamacion).ValueGeneratedOnAdd();
            reclamacion.Property(r => r.Nombre).IsRequired().HasMaxLength(50);
            reclamacion.Property(r => r.Apellido).IsRequired().HasMaxLength(50);
            reclamacion.Property(r => r.Direccion).IsRequired().HasMaxLength(100);
            reclamacion.Property(r => r.Ciudad).IsRequired().HasMaxLength(50);
            reclamacion.Property(r => r.Distrito).IsRequired().HasMaxLength(50);
            reclamacion.Property(r => r.Email).IsRequired().HasColumnType("text");
            reclamacion.Property(r => r.Telefono).IsRequired().HasColumnType("char(9)");
            reclamacion.Property(r => r.TipoDocumento).IsRequired().HasColumnType("ENUM('DNI', 'RUC', 'Pasaporte')");
            reclamacion.Property(r => r.NumeroDocumento).IsRequired().HasMaxLength(50);
            reclamacion.Property(r => r.FechaIncidente).IsRequired();
            reclamacion.Property(r => r.FechaSolicitud).HasDefaultValue(DateTime.Now);
        });

        modelBuilder.Entity<User>().HasData(
            new User { IdUser = 1, Nombre = "Juan", Email = "jose@gmail.com", Password = BCrypt.HashPassword("123456789") },
            new User { IdUser = 2, Nombre = "Maria", Email = "maria@gmail.com", Password = BCrypt.HashPassword("987654321") },
            new User { IdUser = 3, Nombre = "Pedro", Email = "pedro@gmail.com", Password = BCrypt.HashPassword("456789123") }
        );

        modelBuilder.Entity<Rol>().HasData(
            new Rol { IdRol = 1, Nombre = "Administrador" },
            new Rol { IdRol = 2, Nombre = "Usuario" }
        );

        modelBuilder.Entity<Empleado>().HasData(
            new Empleado { IdEmpleado = 1, Nombre = "Juan", Apellido = "Perez", Email = "jose@gmail.com", Telefono = "123456789", Direccion = "Av. Juan Perez 123", DNI = "23456789", IdUser = 1, IdRol = 1 },
            new Empleado { IdEmpleado = 2, Nombre = "Maria", Apellido = "Lopez", Email = "maria@gmail.com", Telefono = "987654321", Direccion = "Av. Maria Lopez 123", DNI = "87654321", IdUser = 2, IdRol = 1 },
            new Empleado { IdEmpleado = 3, Nombre = "Pedro", Apellido = "Rodriguez", Email = "pedro@gmail.com", Telefono = "456789123", Direccion = "Av. Pedro Rodriguez 123", DNI = "45789123", IdUser = 3, IdRol = 1 }
        );

        modelBuilder.Entity<Contacto>().HasData(
            new Contacto
            {
                IdContacto = 1,
                Nombre = "Rosa",
                Apellido = "Pari",
                Email = "rosa@gmail.com",
                Telefono = "985632147",
                Mensaje = "Hola, tengo una consulta sobre un producto"
            },
            new Contacto
            {
                IdContacto = 2,
                Nombre = "Pedro",
                Apellido = "Rodriguez",
                Email = "pedro@gmail.com",
                Telefono = "456789123",
                Mensaje = "Hola, tengo una consulta sobre un producto"
            },
            new Contacto
            {
                IdContacto = 3,
                Nombre = "Maria",
                Apellido = "Lopez",
                Email = "maria@gmail.com",
                Telefono = "987654321",
                Mensaje = "Hola, tengo una consulta sobre un producto"
            }
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
            new Marca { IdMarca = 1, Nombre = "Nike" },
            new Marca { IdMarca = 2, Nombre = "Reebok" },
            new Marca { IdMarca = 3, Nombre = "Adidas" },
            new Marca { IdMarca = 4, Nombre = "Puma" },
            new Marca { IdMarca = 5, Nombre = "Element" },
            new Marca { IdMarca = 6, Nombre = "Vans" },
            new Marca { IdMarca = 7, Nombre = "Converse" },
            new Marca { IdMarca = 8, Nombre = "Fila" },
            new Marca { IdMarca = 9, Nombre = "Nike" }
        );

        modelBuilder.Entity<Talla>().HasData(
            new Talla { IdTalla = 1, NombreTalla = "S", Descripcion = "Talla Small" },
            new Talla { IdTalla = 2, NombreTalla = "M", Descripcion = "Talla Medium" },
            new Talla { IdTalla = 3, NombreTalla = "L", Descripcion = "Tala Large" },
            new Talla { IdTalla = 4, NombreTalla = "XL", Descripcion = "Talla Extra Large" },
            new Talla { IdTalla = 5, NombreTalla = "XXL", Descripcion = "Talla Extra Extra Large" }
        );

        modelBuilder.Entity<Proveedor>().HasData(
            new Proveedor { IdProveedor = 1, Nombre = "Juan", Apellido = "Perez", Email = "jose@gmail.com", Telefono = "123456789", Direccion = "Av. Juan Perez 123", DNI = "23456789" },
            new Proveedor { IdProveedor = 2, Nombre = "Maria", Apellido = "Lopez", Email = "maria@gmail.com", Telefono = "987654321", Direccion = "Av. Maria Lopez 123", DNI = "87654321" },
            new Proveedor { IdProveedor = 3, Nombre = "Pedro", Apellido = "Rodriguez", Email = "pedro@gmail.com", Telefono = "456789123", Direccion = "Av. Pedro Rodriguez 123", DNI = "45689123" }
        );

        modelBuilder.Entity<Prenda>().HasData(
            new Prenda { IdPrenda = 1, Nombre = "Camisa Jean", Descripcion = "Camisa de Jean para varón", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 2, Nombre = "Camiseta Jean", Descripcion = "Camiseta de Jean para varón", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 3, Nombre = "Casaca Jean", Descripcion = "Casaca de Jean Oversize", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 4, Nombre = "Pantalon exacto", Descripcion = "Pantalon exacto para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 5, Nombre = "Camisa Elegante", Descripcion = "Camisa Elegante para Hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 6, Nombre = "Zapatos de Vestir", Descripcion = "Zapatos de vestir para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 7, Nombre = "Zapatillas Adidas", Descripcion = "Zapatillas Adidas para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 8, Nombre = "Polo Estampado", Descripcion = "Polo de estampado para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 9, Nombre = "Polo Oversize", Descripcion = "Polo de oversize para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 10, Nombre = "Camiseta Maria", Descripcion = "Camiseta de Maria para varón", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 11, Nombre = "Chompa Abrigadora", Descripcion = "Chompa abrigadora para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 12, Nombre = "Pantalon Axios", Descripcion = "Pantalon para pedir peticiones", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 },
            new Prenda { IdPrenda = 13, Nombre = "Pantalon Dress", Descripcion = "Pantalon comodo para hombre", Color = "Negro", Precio = 100, Stock = 10, IdMarca = 2, IdCategoria = 3, IdTalla = 2, IdProveedor = 1 }
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
            new Cliente { IdCliente = 1, Nombre = "Juan", Apellido = "Perez", Email = "jose@gmail.com", Telefono = "123456789", Direccion = "Av. Juan Perez 123", DNI = "74162314" },
            new Cliente { IdCliente = 2, Nombre = "Maria", Apellido = "Lopez", Email = "maria@gmail.com", Telefono = "987654321", Direccion = "Av. Maria Lopez 123", DNI = "52462314" },
            new Cliente { IdCliente = 3, Nombre = "Pedro", Apellido = "Rodriguez", Email = "pedro@gmail.com", Telefono = "456789123", Direccion = "Av. Pedro Rodriguez 123", DNI = "14762314" }
        );

        modelBuilder.Entity<Venta>().HasData(
            new Venta { IdVenta = 1, FechaVenta = new DateTime(2024, 4, 1), DireccionVenta = "Av. Juan Perez 123", Total = 100, IDCliente = 1, MetodoPago = "Efectivo" },
            new Venta { IdVenta = 2, FechaVenta = new DateTime(2024, 4, 2), DireccionVenta = "Av. Maria Lopez 123", Total = 100, IDCliente = 2, MetodoPago = "Tarjeta de Crédito" },
            new Venta { IdVenta = 3, FechaVenta = new DateTime(2024, 4, 3), DireccionVenta = "Av. Pedro Rodriguez 123", Total = 100, IDCliente = 3, MetodoPago = "Efectivo" }
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
