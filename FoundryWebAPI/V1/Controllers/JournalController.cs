using FoundryWebAPI.Helpers;
using FoundryWebAPI.Models;
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Journals))]
        public async Task<IActionResult> Get(string world)
        {
            // var byWorld = J2(world);
            var journal = await _repo.JournalAsync(world, null, null);
            if (journal == null) return BadRequest($"No journals found for world {world}");

            return Ok(journal);
        }

        /// <summary>
        /// Method to get journal entry by id from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/id/{id}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Journals))]
        public async Task<IActionResult> GetById([FromQuery] PageParams p, string world, string id)
        {
            var byJournalId = await _repo.JournalAsync(world, id, "byId");
            // var journalInfo = byJournalId.FindAll(j => j.Id == id);
            if (byJournalId == null) return BadRequest("Journal not found.");

            return Ok(byJournalId);
        }

        /// <summary>
        /// Method to get journal entry by name from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/name/{name}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Journals))]
        public async Task<IActionResult> GetByName(string world, string name)
        {
            var byJournalName = await _repo.JournalAsync(world, name, "byName");
            // var journalInfo = byJournalName.FindAll(j => j.Name.Contains(name));
            if (byJournalName == null) return BadRequest("Journal not found.");

            return Ok(byJournalName);
        }
    }
}