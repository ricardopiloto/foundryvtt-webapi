using FoundryWebAPI.Models;
using FoundryWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorldsController : ControllerBase
    {
        public List<Worlds>? World => JsonConvert.DeserializeObject<List<Worlds>>(ReadWorlds.GetWorlds());
        public WorldsController() { }

        // /api/worlds
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(World);
        }
        
        // /api/worlds/byName?name=nameofworld
        [HttpGet("ByName")]
        public IActionResult GetByName(string name)
        {
            var byWorldName = World.FirstOrDefault(w => w.Name.Contains(name));
            if (byWorldName == null) return BadRequest("World not found");
            return Ok(byWorldName);
        }
    }
}