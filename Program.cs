
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyectoef;
using Api_CRUD_Entity_Framework.Models;
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


var builder = WebApplication.CreateBuilder(args);

// Configuracion para la base de datos En memoria 

//builder.Services.AddDbContext<TareasContex>(p => p.UseInMemoryDatabase("TareasDB"));

builder.Services.AddNpgsql<TareasContex>(builder.Configuration.GetConnectionString("CrudTareas"));

// CONFIGURACION para la base de datos 
var app = builder.Build();
app.MapGet("/", () => "Hello World!");


app.MapGet("/dbconexion", async ([FromServices] TareasContex dbContext)=>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de Datos en Memoria : "+dbContext.Database.IsInMemory());
});

app.MapPost("/api/tareas", async ([FromServices] TareasContex dbContext,[FromBody] Tarea tarea)=>
{
    tarea.TareaId=Guid.NewGuid();
    tarea.FechaCreacion=DateTime.Now;
    await dbContext.AddAsync(tarea);
    //await dbContext.Tareas.AddAsync(tarea);
    await dbContext.SaveChangesAsync();
    return Results.Ok();

});

app.MapGet("/api/tareas", async ([FromServices] TareasContex dbContext,[FromBody] Tarea tarea)=>
{
    return Results.Ok(dbContext.Tareas);
});
app.Run();
