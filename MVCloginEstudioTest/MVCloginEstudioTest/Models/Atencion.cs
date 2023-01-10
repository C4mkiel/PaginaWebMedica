using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Models
{
    public class Atencion
    {
        [DisplayName("Alergias")]
        public string Alergias { get; set; }

        [DisplayName("Signos vitales")]
        public string SignoVital { get; set; }

        [DisplayName("Enfermedad cronica")]
        public string EnfermedadCronica { get; set; }

        [DisplayName("Diagnostico")]
        public string Diagnostico { get; set; }

        [DisplayName("Tratamiento")]
        public string Tratamiento { get; set; }
    }
}
