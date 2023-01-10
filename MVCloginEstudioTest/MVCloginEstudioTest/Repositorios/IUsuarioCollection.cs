using MVCloginEstudioTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Repositorios
{
    public interface IUsuarioCollection
    {
        void InsertUsuario(Usuario usuario);

        void UpdateUsuario(Usuario usuario);

        void DeleteUsuario(string usuario);

        List<Usuario> GetAllUsuario();
        Usuario GetUsuario(string id);

    }
}
