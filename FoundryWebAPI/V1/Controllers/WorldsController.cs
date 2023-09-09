using FoundryWebAPI.Models;
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
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WorldsModel))]
        public IActionResult Get()
        {
            var worlds = _repo.World();
            if (worlds == null) return BadRequest("No worlds found.");
            return Ok(worlds);
        }

        // /api/worlds/byName?name=nameo
        /// <summary>
        /// Get worlds by name
        ///</summary>
        /// <returns></returns>
        [HttpGet("{name}")]
        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WorldsModel))]
        public IActionResult GetByName(string name)
        {
            var byWorldName = _repo.World().FirstOrDefault(w => w.Title.Contains(name));
            if (byWorldName == null) return BadRequest("World not found");
            return Ok(byWorldName);
        }
    }
}