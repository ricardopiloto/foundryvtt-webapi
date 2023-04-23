using FoundryWebAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoundryWebAPI.V1.Controllers
{
    /// <summary>
    /// 
    ///</summary>
    /// <returns></returns>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{versioning:ApiVersion}/[controller]")]
    public class WorldsController : ControllerBase
    {
        //// <summary>
        /// 
        ///</summary>
        /// <returns></returns>
        private readonly IRepository _repo;
        public WorldsController(IRepository repo) => _repo = repo;

        // /api/worlds
        /// <summary>
        /// Method to get all available worlds
        ///</summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var worlds = _repo.World();
            if (worlds == null) return BadRequest("No worlds found.");
            return Ok(_repo.World());
        }

        // /api/worlds/byName?name=nameo
        /// <summary>
        /// Get worlds by name
        ///</summary>
        /// <returns></returns>
        [HttpGet("{name}")]
        [Authorize]
        public IActionResult GetByName(string name)
        {
            var byWorldName = _repo.World().FirstOrDefault(w => w.Path.Contains(name));
            if (byWorldName == null) return BadRequest("World not found");
            return Ok(byWorldName);
        }
    }
}