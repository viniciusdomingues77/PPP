using Microsoft.AspNetCore.Mvc;

namespace Cafetaria.Catalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        List<string> catalogo = new List<string> { "Latte", "Americano",
            "Expresso", "Mocha", "Chá" };
        // GET: api/catalogo
        [HttpGet]
        public List<string> Get()
        {
            return catalogo;
        }
    }
}