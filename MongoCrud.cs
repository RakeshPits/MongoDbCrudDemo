using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace MongoDbConsolDemo
{
    public class MongoCrud<T> where T : class
    {
        #region Private
        private readonly IMongoCollection<T> _collection;
        #endregion

        #region Construtor
        public MongoCrud(IDataBaseSettings dataBaseSettings)
        {           
            var mongoClient = new MongoClient(dataBaseSettings.ConnectionString);
            var db = mongoClient.GetDatabase(dataBaseSettings.DatabaseName);
            
            _collection = db.GetCollection<T>(dataBaseSettings.CollectionName);
        }
        #endregion

        #region Public
        public void Insert(T document)
        {            
            _collection.InsertOne(document);
        }

      
        public IEnumerable<T> Select()
        {
            return _collection.Find(new BsonDocument()).ToList();
        }

        public T SelectById(Guid id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            return _collection.Find(filter).First();
        }

        public void Update(Guid id, T document)
        {
            var result = _collection.ReplaceOne(new BsonDocument("_id", id), document);
        }

        public void Delete(Guid id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            _collection.DeleteOne(filter);
        }
        #endregion
    }
}
