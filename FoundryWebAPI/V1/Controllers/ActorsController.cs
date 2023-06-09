using FoundryWebAPI.Helpers;
using FoundryWebAPI.Models;
using FoundryWebAPI.V1.Repositories;
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
    public class ActorsController : ControllerBase
    {
        /// <summary>
        /// 
        ///</summary>
        /// <returns></returns>
        private readonly IRepository _repo;
        public ActorsController(IRepository repo) => _repo = repo;
        /// <summary>
        /// Method to get all actors from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Actors))]
        public async Task<IActionResult> Get([FromQuery]PageParams p,string world)
        {
            var actors = await _repo.ActorAsync(p, world, null, null);
            if (actors == null) return BadRequest($"No actors found for world {world}.");

            return Ok(actors);
        }
        /// <summary>
        /// Method to get actors by id from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/id/{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Actors))]
        
        public async Task<IActionResult> GetById([FromQuery]PageParams p,string world, string id)
        {
            var byActorId = await _repo.ActorAsync(p, world, id, "byId");
            // var actorInfo = byActorId.FindAll(a => a.Id == id);
            if (byActorId == null) return BadRequest("Actor not found.");
        
            return Ok(byActorId);
        }

        // /api/journal/byName?name=nomedojournal
        // /api/journal/aksjdhaksjhd (id do Journal)
        /// <summary>
        /// Method to get actors by name from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/name/{name}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Actors))]
        public async Task<IActionResult> GetByName([FromQuery]PageParams p, string world, string name)
        {
            var byActorName = await _repo.ActorAsync(p, world, name, "byName");
            // var actorInfo = byActorName.FindAll(a => a.Name.Contains(name));
            if (byActorName == null) return BadRequest("Actor not found.");

            return Ok(byActorName);
        }

        /// <summary>
        /// Method to get actors by type (chacters, monsters, npc, etc) from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/type/{type}")]
        [Authorize]
        public async Task<IActionResult> GetByType([FromQuery]PageParams p, string world, string type)
        {
            var byActorType = await _repo.ActorAsync(p, world, type, "byType");
            // var actorInfo = byActorType.FindAll(a => a.Type.Contains(type));
            if (byActorType == null) return BadRequest("Actor not found.");

            return Ok(byActorType);
        }

        /// <summary>
        /// Method to get actors by Class IF type is characters from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/class/{cls}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Actors))]
        public async Task<IActionResult> GetByClass([FromQuery]PageParams p,string world, string cls)
        {
            var byActorType = await _repo.ActorAsync(p,world, cls, "byClass");
            // var actorInfo = byActorType.FindAll(a => a.Items.Any(i => i.Name.ToLower() == cls.ToLower()));
            if (byActorType == null) return BadRequest("Actor not found.");

            return Ok(byActorType);
        }
    }
}