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
        public async Task<IActionResult> Get(string world)
        {
            // var byWorld = J2(world);
            var journal = await _repo.JournalAsync(world);
            if (journal == null) return BadRequest($"No journals found for world {world}");

            return Ok(journal);
        }

        /// <summary>
        /// Method to get journal entry by id from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/id/{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(string world, string id)
        {
            var byJournalId = await _repo.JournalAsync(world);
            var journalInfo = byJournalId.FindAll(j => j.Id == id);
            if (journalInfo.Count <= 0) return BadRequest("Journal not found.");

            return Ok(journalInfo);
        }

        /// <summary>
        /// Method to get journal entry by name from db file
        ///</summary>
        /// <returns></returns>
        [HttpGet("{world}/name/{name}")]
        [Authorize]
        public async Task<IActionResult> GetByName(string world, string name)
        {
            var byJournalName = await _repo.JournalAsync(world);
            var journalInfo = byJournalName.FindAll(j => j.Name.Contains(name));
            if (journalInfo == null) return BadRequest("Journal not found.");

            return Ok(journalInfo);
        }
    }
}