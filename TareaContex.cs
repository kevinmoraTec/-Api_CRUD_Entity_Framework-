using Api_CRUD_Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;

namespace Proyectoef;

public class TareasContex:DbContext
{
    // Representamos las Tablas 

    public  DbSet<Categoria> Categorias {get; set;}
    public DbSet<Tarea> Tareas {get; set;}

    public TareasContex(DbContextOptions<TareasContex> options) : base(options){}
    
    // Hacemos uso de Fluent Api para crear los Moedelos en Posgressql 
    protected override void OnModelCreating(ModelBuilder modelBuilder){

        // Creamos los datos semilla 
         List<Categoria> categoriasInit = new List<Categoria>();
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), Nombre = "Actividades pendientes", Peso = 20});
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb402"), Nombre = "Actividades personales", Peso = 50});

    // configuracion de la tabla Categoria

        modelBuilder.Entity<Categoria>(categoria => {
            categoria.ToTable("Categoria");
            categoria.HasKey(p=> p.CategoriaId);
            categoria.Property(p=>p.Nombre).IsRequired().HasMaxLength(150);
            categoria.Property(p=> p.Descripcion).IsRequired(false);
            categoria.Property(p=>p.Peso);
            categoria.HasData(categoriasInit);
        });

        List<Tarea> tareaList = new List<Tarea>();
        tareaList.Add(new Tarea(){TareaId=Guid.Parse("c707c5a6-b9ac-4992-b1f4-d01294f3d421"),/*Vinculamos la Tarea con la categoria */ CategoriaId=Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),Titulo="Lenguaje Resumen pg:50",Descripcion="Resumir con Cuadros Sipnoticos",PrioridadTarea=Prioridad.Alta,FechaCreacion=DateTime.Now});
        tareaList.Add(new Tarea(){TareaId=Guid.Parse("c707c5a6-b9ac-4992-b1f4-d01294f3d422"),/*Vinculamos la Tarea con la categoria */ CategoriaId=Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb402"),Titulo="Matematicas Operaciones pg:90",Descripcion="Realizarlas con una hoja de papel Bom",PrioridadTarea=Prioridad.Baja,FechaCreacion=DateTime.Now});


        modelBuilder.Entity<Tarea>(tarea =>{
            tarea.ToTable("Tarea");
            tarea.HasKey(t=>t.TareaId);
            tarea.HasOne(t=>t.Categoria).WithMany(t=>t.Tareas).HasForeignKey(t=>t.CategoriaId);
            tarea.Property(t=>t.Titulo).IsRequired().HasMaxLength(200);
            tarea.Property(t=> t.Descripcion);
            tarea.Property(t=> t.PrioridadTarea);
            tarea.Property(t=> t.FechaCreacion).HasDefaultValue(DateTime.Now);
            tarea.Ignore(t=> t.Resumen);
            tarea.Property(t=> t.HorasOcupadas);
            tarea.HasData(tareaList);
        });
    }
}