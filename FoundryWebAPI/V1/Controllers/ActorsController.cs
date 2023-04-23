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
        public IActionResult Get(string world)
        {
            var actors = _repo.Actor(world);
            if (actors == null) return BadRequest($"No actors found for world {world}.");

            return Ok(_repo.Actor(world));
        }
        /// <summary>
        /// Method to get actors by id from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/id/{id}")]
        [Authorize]
        public IActionResult GetById(string world, string id)
        {
            var byActorId = _repo.Actor(world).FirstOrDefault(a => a.Id == id);
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
        public IActionResult GetByName(string world, string name)
        {
            var byActorName = _repo.Actor(world).FindAll(a => a.Name.Contains(name));
            if (byActorName == null) return BadRequest("Actor not found.");

            return Ok(byActorName);
        }

        // /api/journal/aksjdhaksjhd (id do Journal)
        /// <summary>
        /// Method to get actors by type (chacters, monsters, npc, etc) from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/type/{type}")]
        [Authorize]
        public IActionResult GetByType(string world, string type)
        {
            var byActorType = _repo.Actor(world).FindAll(a => a.Type.Contains(type));
            if (byActorType == null) return BadRequest("Actor not found.");

            return Ok(byActorType);
        }

        // /api/journal/aksjdhaksjhd (id do Journal)
        /// <summary>
        /// Method to get actors by Class if type is characters from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/class/{class}")]
        [Authorize]
        public IActionResult GetByClass(string world, string cls)
        {
            var byActorType = _repo.Actor(world).FindAll(a => a.Type.Contains(cls));
            if (byActorType == null) return BadRequest("Actor not found.");

            return Ok(byActorType);
        }
    }
}