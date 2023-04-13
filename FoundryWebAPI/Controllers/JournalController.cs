using FoundryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalController : ControllerBase
    {
        public List<Journals> Journal = new List<Journals>() 
        {
            new Journals()
            {
                Name = "Stair",
                _Id = "ikuhasd",
                Folder = "Test"
            },
            new Journals()
            {
                Name = "Fast",
                _Id = "oiuqywoe",
                Folder = "Test"
            },
            new Journals()
            {
                Name = "Taera",
                _Id = "zvzbxcvz",
                Folder = "Test"
            }
            
        };
        public JournalController() { }
        
        [HttpGet]
        public IActionResult Get()
        {
            // return Ok(ReadJournalDb.JournalFile());
            return Ok(Journal);
        }
        
        // /api/journal/aksjdhaksjhd (id do Journal)
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var byJournalId = Journal.FirstOrDefault(j => j._Id == id);
            if(byJournalId == null) return BadRequest("Journal not found");
            
            return Ok(byJournalId);
        }

        // /api/journal/byName?name=nomedojournal
        [HttpGet("ByName")]
        public IActionResult GetByName(string name)
        {
            var byJournalName = Journal.FirstOrDefault(j => j.Name.Contains(name));
            if(byJournalName == null) return BadRequest("Journal not found");
            
            return Ok(byJournalName);
        }
    }
}