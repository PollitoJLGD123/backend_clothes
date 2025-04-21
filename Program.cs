using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using backend_net.app.models;
using backend_net.app.controllers.api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

/*builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);  //estoooooooo es para migraciones con modelos*/

builder.Services.AddDbContext<DataDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");


app.MapGet("/dbconexion", ([FromServices] DataDbContext context) =>
{
    context.Database.EnsureCreated();
    //await context.Database.MigrateAsync(); corre migraciones :vv
    return Results.Ok("Conexion con la base de datos correcta");
});

app.MapGet("/clientes", ([FromServices] DataDbContext context) =>
{
    return Results.Ok(context.Clientes.Where(c => c.IdCliente == 2));
});

app.MapPost("/clientes", async ([FromServices] DataDbContext context, [FromBody] Cliente cliente) =>
{
    try{
        //otra manera de hacer el guardado es asi: await context.AddAsync(cliente); await context.SaveChangesAsync();
        await context.Clientes.AddAsync(cliente); // o sino normal context.Clientes.Add(cliente); por si no es asincrono
        await context.SaveChangesAsync(); // igualmente sino normal com context.SaveChanges(); por si no es asincrono
        return Results.Ok("Guardado correctamente");

    }catch(Exception e){
        return Results.BadRequest(e.Message);
    }
});

app.MapPut("/clientes/{id}", async ([FromServices] DataDbContext context, [FromBody] Cliente cliente, [FromRoute] int id) =>
{
    try{
        
        var client = context.Clientes.FirstOrDefault(c => c.IdCliente == id);
        if (client == null)
        {
            return Results.NotFound("Cliente no encontrado");
        }
        else
        {
            client.Nombre = cliente.Nombre;
            client.Apellido = cliente.Apellido;
            client.Email = cliente.Email;
            client.Telefono = cliente.Telefono;
            client.Direccion = cliente.Direccion;
            client.DNI = cliente.DNI;  
            await context.SaveChangesAsync();
            return Results.Ok("Actualizado correctamente");
        }

    }catch(Exception e){
        return Results.BadRequest(e.Message);
    }
});

app.MapDelete("/clientes/{id}", async ([FromServices] DataDbContext context, [FromRoute] int id) =>
{
    try{
        //otra manera de hacer la eliminacion es asi: await context.RemoveAsync(cliente); await context.SaveChangesAsync();
        var cliente = await context.Clientes.FindAsync(id);
        if (cliente == null)
        {
            return Results.NotFound("Cliente no encontrado");
        }
        context.Clientes.Remove(cliente); // o sino normal context.Clientes.Remove(cliente); por si no es asincrono
        await context.SaveChangesAsync(); // igualmente sino normal com context.SaveChanges(); por si no es asincrono
        return Results.Ok("Eliminado correctamente");
    }catch(Exception e){
        return Results.BadRequest(e.Message);
    }
});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
