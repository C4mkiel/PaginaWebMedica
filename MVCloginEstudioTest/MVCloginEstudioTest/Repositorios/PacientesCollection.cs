using MongoDB.Bson;
using MongoDB.Driver;
using MVCloginEstudioTest.Models;
using MVCProyectoClase.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCloginEstudioTest.Repositorios
{
    public class PacientesCollection : IPacientesCollection
    {
        internal MongoDBRepositorio _repository = new MongoDBRepositorio();
        private IMongoCollection<Pacientes> Collection;

        public PacientesCollection()
        {
            Collection = _repository.db.GetCollection<Pacientes>("Pacientes");
        }

        public void DeletePacientes(string id)
        {
            var filter = Builders<Pacientes>.Filter.Eq(s => s.IdPaciente, new ObjectId(id));
            Collection.DeleteOneAsync(filter);
        }

        public List<Pacientes> GetAllPacientes()
        {
            var query = Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Pacientes GetPacientes(string id)
        {
            var pacientes = Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
            return pacientes;
        }

        public void InsertPacientes(Pacientes pacientes)
        {
            Collection.InsertOneAsync(pacientes);
        }

        public void UpdatePacientes(Pacientes pacientes)
        {
            var filter = Builders<Pacientes>.Filter.Eq(s => s.IdPaciente, pacientes.IdPaciente);

            Collection.ReplaceOneAsync(filter, pacientes);
        }
    }
}
