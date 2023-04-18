using System.Linq;
using FoundryWebAPI.Models;
using FoundryWebAPI.Repositories;
using FoundryWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        
        public List<Actors>? Actor => JsonConvert.DeserializeObject<List<Actors>>(ReadActorsDB.ActorFile("forgotten-realms"));
       
        public ActorsController() { }

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            // return Ok(ReadJournalDb.JournalFile());
            return Ok(Actor);
        }
        // /api/journal/aksjdhaksjhd (id do Journal)
        [HttpGet("id/{id}")]
        [Authorize]
        public IActionResult GetById(string id)
        {
            var byActorId = Actor.FirstOrDefault(a => a.Id == id);
            if (byActorId == null) return BadRequest("Actor not found");

            return Ok(byActorId);
        }

        // /api/journal/byName?name=nomedojournal
        [HttpGet("name/{name}")]
        [Authorize]
        public IActionResult GetByName(string name)
        {
            var byActorName = Actor.FindAll(a => a.Name.Contains(name));
            if (byActorName == null) return BadRequest("Actor not found");

            return Ok(byActorName);
        }

        [HttpGet("type/{type}")]
        [Authorize]
        public IActionResult GetByType(string type)
        {
            var byActorType = Actor.FindAll(a => a.Type.Contains(type));
            if (byActorType == null) return BadRequest("Actor not found");

            return Ok(byActorType);
        }

        [HttpGet("class/{class}")]
        [Authorize]
        public IActionResult GetByClass(string cls)
        {
            var byActorType = Actor.FindAll(a => a.Type.Contains(cls));
            if (byActorType == null) return BadRequest("Actor not found");

            return Ok(byActorType);
        }
    }
}