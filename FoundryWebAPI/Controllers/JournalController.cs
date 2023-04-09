using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalController : ControllerBase
    {
        public JournalController() { }
        [HttpGet]
        public IActionResult Get()
        {
            string text = System.IO.File.ReadAllText(@"/home/ricardosobral/Downloads/journal.db");
            // var person = System.Text.Json.JsonSerializer.Deserialize<Person>(text);
            return Ok(text);
        }
    }
}