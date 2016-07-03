using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using choch_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace choch_api.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;

        public AccountController(
            UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> RegisterUser(string email)
        {
            var user = new User { UserName = email, Email = email};
            var result = await _userManager.CreateAsync(user, "12weTTTfwfe---3456");
            if (result.Succeeded)
            {
                return new StatusCodeResult((int)HttpStatusCode.OK);
            }

            return new StatusCodeResult((int)HttpStatusCode.Unauthorized);
        }
    }
}
