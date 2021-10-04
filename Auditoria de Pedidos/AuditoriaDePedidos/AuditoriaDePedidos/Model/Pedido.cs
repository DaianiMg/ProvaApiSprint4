using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditoriaDePedidos.Model
{
    public class Pedido
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        public DateTime EventDate { get; set; }
        public string Descricao { get; set; }
        public string Api { get; set; }
        public string Content { get; set; }

        //orderId: ID do pedido no OCXC;

        //eventDate: Data e hora que o evento ocorreu;

        //description: Descrição do evento;

        //api: API que executou o evento;

        //content: objeto livre para informações adicionais sobre o evento.
    }
}
