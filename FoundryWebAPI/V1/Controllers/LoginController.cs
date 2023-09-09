using Microsoft.AspNetCore.Mvc;
using FoundryWebAPI.Models;
using FoundryWebAPI.Repositories;
using FoundryWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using FoundryWebAPI.Repositories;

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
    public class LoginController : Controller
    {
        // /api/journal/aksjdhaksjhd (id do Journal)
        /// <summary>
        /// Login method for the API
        ///</summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]User model) 
        {
            var user = UserRepository.Get(model.Username, model.Password);
            if(user == null){
                return NotFound(new { message = "User or password is incorrect!" });
            }else
            {
                var token = TokenService.GenerateToken(user);
                user.Password = "";
                return new 
                {
                    user = user,
                    token = token
                };
            }
        }
        
    }
}