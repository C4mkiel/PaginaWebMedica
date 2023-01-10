using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MVCProyectoClase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Models
{
    public class Usuario
    {
        [BsonId]
        public ObjectId IdPaciente { get; set; }

        public string Rut { get; set; }

        public string NombrePaciente { get; set; }

        public string CorreoUsuario { get; set; }

        public string Contraseña { get; set; }

        public List<Recetas> Recetas { get; set; }

        public List<Medicamento> Medicamento { get; set; }
    }
}
