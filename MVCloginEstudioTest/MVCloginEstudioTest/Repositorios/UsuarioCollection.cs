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
    public class UsuarioCollection : IUsuarioCollection
    {
        internal MongoDBRepositorio _repository = new MongoDBRepositorio();
        private IMongoCollection<Usuario> Collection;

        public UsuarioCollection() {
            Collection = _repository.db.GetCollection<Usuario>("Usuario");
        }

        public void DeleteUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void DeleteUsuario(string id)
        {
            var filter = Builders<Usuario>.Filter.Eq(s => s.IdPaciente, new ObjectId(id));
            Collection.DeleteOneAsync(filter);
        }

        public List<Usuario> GetAllUsuario()
        {
            var query = Collection.
                Find(new BsonDocument()).ToListAsync();

            return query.Result;
        }

        public Usuario GetUsuario(string id)
        {
            var usuario = Collection.Find(
                new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
            return usuario;
        }

        public void InsertUsuario(Usuario usuario)
        {
            Collection.InsertOneAsync(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            var filter = Builders<Usuario>.Filter.Eq(s => s.IdPaciente, usuario.IdPaciente);

            Collection.ReplaceOneAsync(filter, usuario);
        }
    }
}
