using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafetaria.Cliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private List<string> clientes = new List<string> { "José Carlos", "Miriam",
            "Janice", "Jefferson", "Jessica" };
        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return clientes;
        }
        // GET: api/Cliente/2
        [HttpGet("{id:int}", Name = "Get")]
        public ActionResult Get(int id)
        {
            if (id <= clientes.Count - 1 && id >= 0)
                return Ok(clientes[id]);
            else
                return BadRequest($"{id} inválido");
        }
    }
}