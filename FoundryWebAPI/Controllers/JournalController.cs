using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using FoundryWebAPI.Models;
using FoundryWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalController : ControllerBase
    {
        // public List<Journals> Journal = new List<Journals>() { };
        public JournalController() { }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ReadJournalDb.JournalFile());
        }
    }
}