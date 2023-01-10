using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyectoClase.Models
{
    public class Medicamento
    {
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public string Comprimido { get; set; }
        public string HoraConsumo { get; set; }
        public string TiempoConsumo { get; set; }
    }
}
