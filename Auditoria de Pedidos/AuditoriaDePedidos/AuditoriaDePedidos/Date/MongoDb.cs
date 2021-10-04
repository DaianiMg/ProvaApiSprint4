using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditoriaDePedidos.Date
{
    public class MongoDb
    {
        public IMongoDatabase DB { get; }

        public MongoDb(IConfiguration configuration)
        {
            try
            {
                var settings = MongoClientSettings.FromUrl(new MongoUrl(configuration["Connection"]));
                var client = new MongoClient(settings);
                DB = client.GetDatabase(configuration["Pedidos"]);
               
            }
            catch (Exception ex)
            {
                throw new MongoException("Não foi possível conectar", ex);
            }
        }
        
    }
}
