using MVCloginEstudioTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Repositorios
{
    public interface IPacientesCollection
    {
        void InsertPacientes(Pacientes pacientes);

        void UpdatePacientes(Pacientes pacientes);

        void DeletePacientes(string id);

        List<Pacientes> GetAllPacientes();
        Pacientes GetPacientes(string id);

    }
}
