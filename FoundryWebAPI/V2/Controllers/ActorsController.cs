using FoundryWebAPI.Helpers;
using FoundryWebAPI.Models;
using FoundryWebAPI.Repositories;
using FoundryWebAPI.Services.DBConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoundryWebAPI.V2.Controllers
{
    /// <summary>
    /// 
    ///</summary>
    /// <returns></returns>
    [ApiController]
    [ApiVersion("2.0")]
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
            var actors = DBConnect.SetConnection(world,"actors");

            return Ok(actors);
        }
    }
}