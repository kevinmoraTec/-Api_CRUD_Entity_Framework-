using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api_CRUD_Entity_Framework.Models
{
        public class Categoria {

            //[Key] // Datanotations 
            // Defino el modelo de mi tabla 
            public Guid CategoriaId {get; set;}
            //[Required] // Datanotations
            //[MaxLength(150)]
            public string Nombre {get; set;}
            
            public string Descripcion {get;set;}

            public int Peso {get; set;}
            
            [JsonIgnore]
            public virtual ICollection<Tarea> Tareas{get; set;}

        
        }
}