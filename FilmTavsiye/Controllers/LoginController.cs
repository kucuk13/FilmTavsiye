using FilmTavsiye.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FilmTavsiye.Models.Dtos;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace FilmTavsiye.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Index(LoginDto loginDto)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginDto.UserName)
            };

            var userIdentity = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
            
            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
    }
}
