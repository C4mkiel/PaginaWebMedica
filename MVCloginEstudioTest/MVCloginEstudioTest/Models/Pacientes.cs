using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Models
{
    public class Pacientes
    {
        [BsonId]
        public ObjectId IdPaciente { get; set; }

        [DisplayName("Rut")]
        public string Rut { get; set; }

        [DisplayName("Nombre")]
        public string NombrePaciente { get; set; }

        [DisplayName("Apellido")]
        public string ApellidoPaciente { get; set; }

        [DisplayName("Fecha nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Motivo consulta")]
        public string MotConsulta { get; set; }

        [DisplayName("Consulta")]
        public string Consulta { get; set; }

        public List<Atencion> Atencion { get; set; }
    }
}
