using MongoDB.Driver;
using MVCProyectoClase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyectoClase.Repositorios
{
    public interface IRecetasCollection
    {
        void InsertReceta(Recetas recetas);

        void UpdateRecetas(Recetas recetas);

        void DeleteRecetas(string id);

        List<Recetas> GetAllRecetas();
        Recetas GetRecetas(string id);

        List<Recetas> GetRecetasRut(string RutPaciente);

    }
}
