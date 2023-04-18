using FoundryWebAPI.Models;
using FoundryWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalController : ControllerBase
    {
        
        public List<Journals>? Journal => JsonConvert.DeserializeObject<List<Journals>>(ReadJournalDb.JournalFile("forgotten-realms"));
       
        public JournalController() { }

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            // return Ok(ReadJournalDb.JournalFile());
            return Ok(Journal);
        }
        // /api/journal/aksjdhaksjhd (id do Journal)
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetById(string id)
        {
            var byJournalId = Journal.FirstOrDefault(j => j.Id == id);
            if (byJournalId == null) return BadRequest("Journal not found");

            return Ok(byJournalId);
        }

        // /api/journal/byName?name=nomedojournal
        [HttpGet("ByName")]
        [Authorize]
        public IActionResult GetByName(string name)
        {
            var byJournalName = Journal.FirstOrDefault(j => j.Name.Contains(name));
            if (byJournalName == null) return BadRequest("Journal not found");

            return Ok(byJournalName);
        }
    }
}