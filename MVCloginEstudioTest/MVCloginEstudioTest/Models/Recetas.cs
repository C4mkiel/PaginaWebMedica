using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyectoClase.Models
{
    public class Recetas
    {
        [BsonId]
        public ObjectId IdReceta { get; set; }

        [DisplayName("Receta")]
        public string RecetaMedicaNombre { get; set; }

        [DisplayName("Rut")]
        public string RutPaciente { get; set; }

        [DisplayName("Nombre")]
        public string NombrePaciente { get; set; }

        [DisplayName("Edad")]
        public string EdadPaciente { get; set; }

        [DisplayName("Domicilio")]
        public string DomicilioPaciente { get; set; }

        [DisplayName("Fecha")]
        public DateTime FechaReceta { get; set; }

        [DisplayName("Comentario")]
        public string ComentarioReceta { get; set; }

        [DisplayName("Doctor")]
        public string NombreDoctor { get; set; }

        //Prueba para añadir remedios
        public List<Medicamento> Medicamento { get; set; }

        public static explicit operator Recetas(List<Recetas> v)
        {
            throw new NotImplementedException();
        }
    }
}
