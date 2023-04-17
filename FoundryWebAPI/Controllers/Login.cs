using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoundryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Login : Controller
    {
        private readonly ILogger<Login> _logger;

        public Login(){}
        
        public IActionResult GetById()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}