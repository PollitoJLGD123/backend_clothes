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
}