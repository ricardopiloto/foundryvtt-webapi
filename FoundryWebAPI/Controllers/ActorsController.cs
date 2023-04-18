using Microsoft.AspNetCore.Mvc;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        public ActorsController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Aqui vai o resultado do arquivo Actors");
        }
    }
}