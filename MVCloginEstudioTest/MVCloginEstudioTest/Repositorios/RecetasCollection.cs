using MongoDB.Bson;
using MongoDB.Driver;
using MVCProyectoClase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyectoClase.Repositorios
{
    public class RecetasCollection : IRecetasCollection
    {
        internal MongoDBRepositorio _repository = new MongoDBRepositorio();
        private IMongoCollection<Recetas> Collection;

        public RecetasCollection()
        {
            Collection = _repository.db.GetCollection<Recetas>("Recetas");
        }

        public void DeleteRecetas(string id)
        {
            var filter = Builders<Recetas>.Filter.Eq(s => s.IdReceta, new ObjectId(id));
            Collection.DeleteOneAsync(filter);
        }

        public List<Recetas> GetAllRecetas()
        {
            var query = Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Recetas GetRecetas(string id)
        {
            var recetas = Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
            return recetas;
        }

        public void InsertReceta(Recetas recetas)
        {


            Collection.InsertOneAsync(recetas);
        }

        public void UpdateRecetas(Recetas recetas)
        {
            var filter = Builders<Recetas>.Filter.Eq(s => s.IdReceta, recetas.IdReceta);

            Collection.ReplaceOneAsync(filter, recetas);

        }
        public List<Recetas> GetRecetasRut(string RutPaciente)
        {
            var recetas = Collection.Find(r => r.RutPaciente == RutPaciente).ToList();
            return recetas;
        }
    }
}
