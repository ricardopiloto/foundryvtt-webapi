using FoundryWebAPI.Models;
using FoundryWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorldsController : ControllerBase
    {
        public List<Worlds>? World => JsonConvert.DeserializeObject<List<Worlds>>(ReadWorldsDb.GetWorlds());
        public WorldsController() { }

        // /api/worlds
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            return Ok(World);
        }
        
        // /api/worlds/byName?name=nameo
        [HttpGet("ByName")]
        [Authorize]
        public IActionResult GetByName(string name)
        {
            var byWorldName = World.FirstOrDefault(w => w.Name.Contains(name));
            if (byWorldName == null) return BadRequest("World not found");
            return Ok(byWorldName);
        }
    }
}