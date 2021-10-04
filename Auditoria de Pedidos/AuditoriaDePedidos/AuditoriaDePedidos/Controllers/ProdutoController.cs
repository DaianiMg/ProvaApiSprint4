using AuditoriaDePedidos.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditoriaDePedidos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController
    {
        [Route("api/[controller]")]
        public class ProductAPIController : Controller
        {
            Compras compra;


            //FALTOU TEMPO IGNOREM

            public ProductAPIController(Compras c)
            {
                compra = c;
            }

            [HttpPost]
            public IActionResult Post([FromBody] Paginacao p)
            {
                compra.Create(p);
                return;
            }

            [HttpGet]
            public IEnumerable<Paginacao> Get()
            {
                
            }

            [HttpGet("{id}")]
            public IActionResult Get(string id)
            {
                
            }

           

        }
    }
}
