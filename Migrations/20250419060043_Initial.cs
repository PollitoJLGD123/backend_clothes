using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend_net.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "char(9)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "char(8)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    IdContacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "char(9)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mensaje = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.IdContacto);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "char(8)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.IdProveedor);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reclamaciones",
                columns: table => new
                {
                    IdReclamacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ciudad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Distrito = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "char(9)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoDocumento = table.Column<string>(type: "ENUM('DNI', 'RUC', 'Pasaporte')", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroDocumento = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaIncidente = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reclamaciones", x => x.IdReclamacion);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.IdRol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tallas",
                columns: table => new
                {
                    IdTalla = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTalla = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tallas", x => x.IdTalla);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaVenta = table.Column<DateTime>(type: "datetime", nullable: false),
                    DireccionVenta = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IDCliente = table.Column<int>(type: "int", nullable: false),
                    MetodoPago = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_IDCliente",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    IdEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaEntrada = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.IdEntrada);
                    table.ForeignKey(
                        name: "FK_Entradas_Proveedores_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pedidos_Proveedores",
                columns: table => new
                {
                    IdPedidoProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaPedido = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "ENUM('Pendiente', 'Enviado', 'Recibido', 'Anulado')", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos_Proveedores", x => x.IdPedidoProveedor);
                    table.ForeignKey(
                        name: "FK_Pedidos_Proveedores_Proveedores_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Token = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RolIdRol = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_Rols_RolIdRol",
                        column: x => x.RolIdRol,
                        principalTable: "Rols",
                        principalColumn: "IdRol");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prendas",
                columns: table => new
                {
                    IdPrenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: true),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdTalla = table.Column<int>(type: "int", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prendas", x => x.IdPrenda);
                    table.ForeignKey(
                        name: "FK_Prendas_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prendas_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prendas_Proveedores_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prendas_Tallas_IdTalla",
                        column: x => x.IdTalla,
                        principalTable: "Tallas",
                        principalColumn: "IdTalla",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "char(9)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DNI = table.Column<string>(type: "char(8)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenPerfil = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenPerfilUrl = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Rols_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Rols",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detalles_Entradas",
                columns: table => new
                {
                    IdDetalleEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdEntrada = table.Column<int>(type: "int", nullable: false),
                    IdPrenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles_Entradas", x => x.IdDetalleEntrada);
                    table.ForeignKey(
                        name: "FK_Detalles_Entradas_Entradas_IdEntrada",
                        column: x => x.IdEntrada,
                        principalTable: "Entradas",
                        principalColumn: "IdEntrada",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalles_Entradas_Prendas_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "Prendas",
                        principalColumn: "IdPrenda",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detalles_Pedidos",
                columns: table => new
                {
                    IdDetallePedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdPedidoProveedor = table.Column<int>(type: "int", nullable: false),
                    IdPrenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles_Pedidos", x => x.IdDetallePedido);
                    table.ForeignKey(
                        name: "FK_Detalles_Pedidos_Pedidos_Proveedores_IdPedidoProveedor",
                        column: x => x.IdPedidoProveedor,
                        principalTable: "Pedidos_Proveedores",
                        principalColumn: "IdPedidoProveedor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalles_Pedidos_Prendas_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "Prendas",
                        principalColumn: "IdPrenda",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Detalles_Ventas",
                columns: table => new
                {
                    IdDetalleVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioVentaReal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    IdPrenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles_Ventas", x => x.IdDetalleVenta);
                    table.ForeignKey(
                        name: "FK_Detalles_Ventas_Prendas_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "Prendas",
                        principalColumn: "IdPrenda",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalles_Ventas_Ventas_IdVenta",
                        column: x => x.IdVenta,
                        principalTable: "Ventas",
                        principalColumn: "IdVenta",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategoria", "Nombre" },
                values: new object[,]
                {
                    { 1, "Camisas" },
                    { 2, "Pantalones" },
                    { 3, "Chaquetas" },
                    { 4, "Zapatos" },
                    { 5, "Accesorios" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "IdCliente", "Apellido", "DNI", "Direccion", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Perez", "74162314", "Av. Juan Perez 123", "jose@gmail.com", "Juan", "123456789" },
                    { 2, "Lopez", "52462314", "Av. Maria Lopez 123", "maria@gmail.com", "Maria", "987654321" },
                    { 3, "Rodriguez", "14762314", "Av. Pedro Rodriguez 123", "pedro@gmail.com", "Pedro", "456789123" }
                });

            migrationBuilder.InsertData(
                table: "Contactos",
                columns: new[] { "IdContacto", "Apellido", "Email", "Mensaje", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Pari", "rosa@gmail.com", "Hola, tengo una consulta sobre un producto", "Rosa", "985632147" },
                    { 2, "Rodriguez", "pedro@gmail.com", "Hola, tengo una consulta sobre un producto", "Pedro", "456789123" },
                    { 3, "Lopez", "maria@gmail.com", "Hola, tengo una consulta sobre un producto", "Maria", "987654321" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "IdMarca", "Nombre" },
                values: new object[,]
                {
                    { 1, "Nike" },
                    { 2, "Reebok" },
                    { 3, "Adidas" },
                    { 4, "Puma" },
                    { 5, "Element" },
                    { 6, "Vans" },
                    { 7, "Converse" },
                    { 8, "Fila" },
                    { 9, "Nike" }
                });

            migrationBuilder.InsertData(
                table: "Proveedores",
                columns: new[] { "IdProveedor", "Apellido", "DNI", "Direccion", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Perez", "23456789", "Av. Juan Perez 123", "jose@gmail.com", "Juan", "123456789" },
                    { 2, "Lopez", "87654321", "Av. Maria Lopez 123", "maria@gmail.com", "Maria", "987654321" },
                    { 3, "Rodriguez", "45689123", "Av. Pedro Rodriguez 123", "pedro@gmail.com", "Pedro", "456789123" }
                });

            migrationBuilder.InsertData(
                table: "Reclamaciones",
                columns: new[] { "IdReclamacion", "Apellido", "Ciudad", "Direccion", "Distrito", "Email", "FechaIncidente", "FechaSolicitud", "Nombre", "NumeroDocumento", "Telefono", "TipoDocumento" },
                values: new object[,]
                {
                    { 1, "García", "Lima", "Av. Primavera 123", "Miraflores", "carlos@gmail.com", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 1, 0, 43, 637, DateTimeKind.Local).AddTicks(3916), "Carlos", "12345678", "987654321", "DNI" },
                    { 2, "Sánchez", "Arequipa", "Jr. Los Álamos 456", "Cercado", "ana.sanchez@gmail.com", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 1, 0, 43, 637, DateTimeKind.Local).AddTicks(3936), "Ana", "20123456789", "923456789", "RUC" },
                    { 3, "Torres", "Cusco", "Calle Las Flores 789", "Wanchaq", "luis.torres@gmail.com", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 1, 0, 43, 637, DateTimeKind.Local).AddTicks(3939), "Luis", "P1234567", "956321478", "Pasaporte" }
                });

            migrationBuilder.InsertData(
                table: "Rols",
                columns: new[] { "IdRol", "Nombre" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Usuario" }
                });

            migrationBuilder.InsertData(
                table: "Tallas",
                columns: new[] { "IdTalla", "Descripcion", "NombreTalla" },
                values: new object[,]
                {
                    { 1, "Talla Small", "S" },
                    { 2, "Talla Medium", "M" },
                    { 3, "Tala Large", "L" },
                    { 4, "Talla Extra Large", "XL" },
                    { 5, "Talla Extra Extra Large", "XXL" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Email", "Nombre", "Password", "RolIdRol", "Token" },
                values: new object[,]
                {
                    { 1, "jose@gmail.com", "Juan", "$2a$11$daR4uA4EVomN8a4jsTp9p.R3Y2tDTd/xcZlqfVGztQpZ6b/jNTU7i", null, null },
                    { 2, "maria@gmail.com", "Maria", "$2a$11$meWU7/CehvCx852B1CX7P.WMP6P1qv1qtzEJOr1mZq9.Sm.kCFz/m", null, null },
                    { 3, "pedro@gmail.com", "Pedro", "$2a$11$MYqJx.EOJ2DuxBwgsjoH2uKpBmzLL025YiBUkWBavffnSw/CMbYQu", null, null }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "IdEmpleado", "Apellido", "DNI", "Direccion", "Email", "IdRol", "IdUser", "ImagenPerfil", "ImagenPerfilUrl", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Perez", "23456789", "Av. Juan Perez 123", "jose@gmail.com", 1, 1, null, null, "Juan", "123456789" },
                    { 2, "Lopez", "87654321", "Av. Maria Lopez 123", "maria@gmail.com", 1, 2, null, null, "Maria", "987654321" },
                    { 3, "Rodriguez", "45789123", "Av. Pedro Rodriguez 123", "pedro@gmail.com", 1, 3, null, null, "Pedro", "456789123" }
                });

            migrationBuilder.InsertData(
                table: "Entradas",
                columns: new[] { "IdEntrada", "FechaEntrada", "IdProveedor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Pedidos_Proveedores",
                columns: new[] { "IdPedidoProveedor", "Estado", "FechaPedido", "IdProveedor" },
                values: new object[,]
                {
                    { 1, "Pendiente", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Pendiente", new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Recibido", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Prendas",
                columns: new[] { "IdPrenda", "Color", "Descripcion", "IdCategoria", "IdMarca", "IdProveedor", "IdTalla", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, "Negro", "Camisa de Jean para varón", 3, 2, 1, 2, "Camisa Jean", 100m, 10 },
                    { 2, "Negro", "Camiseta de Jean para varón", 3, 2, 1, 2, "Camiseta Jean", 100m, 10 },
                    { 3, "Negro", "Casaca de Jean Oversize", 3, 2, 1, 2, "Casaca Jean", 100m, 10 },
                    { 4, "Negro", "Pantalon exacto para hombre", 3, 2, 1, 2, "Pantalon exacto", 100m, 10 },
                    { 5, "Negro", "Camisa Elegante para Hombre", 3, 2, 1, 2, "Camisa Elegante", 100m, 10 },
                    { 6, "Negro", "Zapatos de vestir para hombre", 3, 2, 1, 2, "Zapatos de Vestir", 100m, 10 },
                    { 7, "Negro", "Zapatillas Adidas para hombre", 3, 2, 1, 2, "Zapatillas Adidas", 100m, 10 },
                    { 8, "Negro", "Polo de estampado para hombre", 3, 2, 1, 2, "Polo Estampado", 100m, 10 },
                    { 9, "Negro", "Polo de oversize para hombre", 3, 2, 1, 2, "Polo Oversize", 100m, 10 },
                    { 10, "Negro", "Camiseta de Maria para varón", 3, 2, 1, 2, "Camiseta Maria", 100m, 10 },
                    { 11, "Negro", "Chompa abrigadora para hombre", 3, 2, 1, 2, "Chompa Abrigadora", 100m, 10 },
                    { 12, "Negro", "Pantalon para pedir peticiones", 3, 2, 1, 2, "Pantalon Axios", 100m, 10 },
                    { 13, "Negro", "Pantalon comodo para hombre", 3, 2, 1, 2, "Pantalon Dress", 100m, 10 }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "IdVenta", "DireccionVenta", "FechaVenta", "IDCliente", "MetodoPago", "Total" },
                values: new object[,]
                {
                    { 1, "Av. Juan Perez 123", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Efectivo", 100m },
                    { 2, "Av. Maria Lopez 123", new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tarjeta de Crédito", 100m },
                    { 3, "Av. Pedro Rodriguez 123", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Efectivo", 100m }
                });

            migrationBuilder.InsertData(
                table: "Detalles_Entradas",
                columns: new[] { "IdDetalleEntrada", "Cantidad", "IdEntrada", "IdPrenda", "PrecioCompra" },
                values: new object[,]
                {
                    { 1, 30m, 1, 1, 100m },
                    { 2, 10m, 1, 2, 100m },
                    { 3, 10m, 1, 3, 100m },
                    { 4, 20m, 2, 4, 100m },
                    { 5, 10m, 2, 5, 100m },
                    { 6, 10m, 2, 6, 100m },
                    { 7, 22m, 2, 7, 100m },
                    { 8, 20m, 3, 8, 100m },
                    { 9, 11m, 3, 9, 100m },
                    { 10, 8m, 3, 10, 100m }
                });

            migrationBuilder.InsertData(
                table: "Detalles_Pedidos",
                columns: new[] { "IdDetallePedido", "Cantidad", "IdPedidoProveedor", "IdPrenda" },
                values: new object[,]
                {
                    { 1, 30m, 1, 1 },
                    { 2, 10m, 1, 2 },
                    { 3, 10m, 1, 3 },
                    { 4, 20m, 2, 4 },
                    { 5, 10m, 2, 5 },
                    { 6, 10m, 2, 6 },
                    { 7, 22m, 2, 7 },
                    { 8, 20m, 3, 8 },
                    { 9, 11m, 3, 9 },
                    { 10, 8m, 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "Detalles_Ventas",
                columns: new[] { "IdDetalleVenta", "Cantidad", "IdPrenda", "IdVenta", "PrecioVentaReal" },
                values: new object[,]
                {
                    { 1, 30m, 1, 1, 100m },
                    { 2, 10m, 2, 1, 100m },
                    { 3, 10m, 3, 1, 100m },
                    { 4, 20m, 4, 2, 100m },
                    { 5, 10m, 5, 2, 100m },
                    { 6, 10m, 6, 2, 100m },
                    { 7, 22m, 7, 2, 100m },
                    { 8, 20m, 8, 3, 100m },
                    { 9, 11m, 9, 3, 100m },
                    { 10, 8m, 10, 3, 100m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Entradas_IdEntrada",
                table: "Detalles_Entradas",
                column: "IdEntrada");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Entradas_IdPrenda",
                table: "Detalles_Entradas",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Pedidos_IdPedidoProveedor",
                table: "Detalles_Pedidos",
                column: "IdPedidoProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Pedidos_IdPrenda",
                table: "Detalles_Pedidos",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Ventas_IdPrenda",
                table: "Detalles_Ventas",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Ventas_IdVenta",
                table: "Detalles_Ventas",
                column: "IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdRol",
                table: "Empleados",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdUser",
                table: "Empleados",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_IdProveedor",
                table: "Entradas",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Proveedores_IdProveedor",
                table: "Pedidos_Proveedores",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_IdCategoria",
                table: "Prendas",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_IdMarca",
                table: "Prendas",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_IdProveedor",
                table: "Prendas",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_IdTalla",
                table: "Prendas",
                column: "IdTalla");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolIdRol",
                table: "Users",
                column: "RolIdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_IDCliente",
                table: "Ventas",
                column: "IDCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Detalles_Entradas");

            migrationBuilder.DropTable(
                name: "Detalles_Pedidos");

            migrationBuilder.DropTable(
                name: "Detalles_Ventas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Reclamaciones");

            migrationBuilder.DropTable(
                name: "Entradas");

            migrationBuilder.DropTable(
                name: "Pedidos_Proveedores");

            migrationBuilder.DropTable(
                name: "Prendas");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Tallas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Rols");
        }
    }
}
