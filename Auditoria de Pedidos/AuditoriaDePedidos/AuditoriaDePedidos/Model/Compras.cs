using AuditoriaDePedidos.Controllers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditoriaDePedidos.Model
{
    public class Compras
    {
        MongoDatabase _db;

        public IEnumerable<Paginacao> GetPaginas()
        {
            return _db.GetCollection<Paginacao>("Paginas").FindAll();
        }

        //FALTOU TEMPO



    }
}
