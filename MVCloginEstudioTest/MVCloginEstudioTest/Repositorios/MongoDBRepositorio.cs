using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyectoClase.Repositorios
{
    public class MongoDBRepositorio
    {
        public MongoClient cliente;

        public IMongoDatabase db;

        public MongoDBRepositorio()
        {
            cliente = new MongoClient("mongodb://localhost:27017");

            db = cliente.GetDatabase("ConsultasMedicas");

        }
    }
}
