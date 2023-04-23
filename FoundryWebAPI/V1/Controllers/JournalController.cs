using FoundryWebAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoundryWebAPI.V1.Controllers
{
    // /api/journal/aksjdhaksjhd (id do Journal)
    /// <summary>
    /// 
    ///</summary>
    /// <returns></returns>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{versioning:ApiVersion}/[controller]")]
    public class JournalController : ControllerBase
    {

        /// <summary>
        /// 
        ///</summary>
        /// <returns></returns>
        private readonly IRepository _repo;
        public JournalController(IRepository repo) => _repo = repo;
        /// <summary>
        /// Method to get all journal entries
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/")]
        [Authorize]
        public IActionResult Get(string world)
        {
            // var byWorld = J2(world);
            var journal = _repo.Journal(world);
            if (journal == null) return BadRequest($"No journals found for world {world}");

            return Ok(_repo.Journal(world));
        }

        /// <summary>
        /// Method to get journal entry by id from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/id/{id}")]
        [Authorize]
        public IActionResult GetById(string world, string id)
        {
            var byJournalId = _repo.Journal(world).FirstOrDefault(j => j.Id == id);
            if (byJournalId == null) return BadRequest("Journal not found");

            return Ok(byJournalId);
        }

        /// <summary>
        /// Method to get journal entry by name from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/name/{name}")]
        [Authorize]
        public IActionResult GetByName(string world, string name)
        {
            var byJournalName = _repo.Journal(world).FirstOrDefault(j => j.Name.Contains(name));
            if (byJournalName == null) return BadRequest("Journal not found");

            return Ok(byJournalName);
        }
    }
}