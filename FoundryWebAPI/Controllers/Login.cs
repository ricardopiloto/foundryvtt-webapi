using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FoundryWebAPI.Models;
using FoundryWebAPI.Repositories;
using FoundryWebAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Login : Controller
    {
        [HttpPost]
        [AllowAnonymous]        
        public async Task<ActionResult<dynamic>> Authenticate([FromBody]User model) 
        {
            var user = UserRepository.Get(model.Username, model.Password);
            if(user == null){
                return NotFound(new { message = "Usuário ou senha inválidos!" });
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