using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api_CRUD_Entity_Framework.Models
{
    public class Tarea
    {

        // Defino el modelo de mi tabla  
       // [Key]
        public Guid TareaId {get; set;}
        //[ForeignKey("CategoriaId")]
        public Guid CategoriaId {get; set;}

        //[MaxLength(200)]
        public string Titulo {get; set;}

        public string Descripcion {get; set;}

        public Prioridad PrioridadTarea {get; set;}

        public DateTime FechaCreacion{get; set;}

        public virtual Categoria Categoria {get; set;}
        //[NotMapped]
        public string Resumen {get; set;}

        public int HorasOcupadas {get; set;}
    }

    public enum  Prioridad
    {
        Baja,
        Media,
        Alta 
    }

}

// datanotations ; https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations


