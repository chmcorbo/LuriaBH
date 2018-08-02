using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using Petronas.Exceptions;

namespace clBasePOO.DB
{
    public class ELMongoDB
    {
        private MongoClient _client;
        private IMongoDatabase _database;
        private String _DataBaseName;

        public ELMongoDB(String pDataBaseName)
        {
            _DataBaseName = pDataBaseName;
        }
        public Boolean Conect()
        {
            Boolean _resultado = false;
            try
            {
                _client = new MongoClient("mongodb://localhost:27017");
                _database = _client.GetDatabase(_DataBaseName);
                _database.ListCollections();
                _resultado = true;
            }
            catch (Exception ex)
            {
                throw new ExConnectionError("Erro ao conectar no banco de dados.  " + ex.Message);
            }
            return _resultado;
        }

        public MongoClient getClient()
        {
            if (_client == null)
                Conect();
            return _client;
        }

        public IMongoDatabase getDatabase()
        {
            if (_database==null)
                Conect();
            return _database;
        }
    }
}
