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
using Microsoft.AspNetCore.Authentication.Cookies;

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

        public async Task<IActionResult> Index(LoginDto model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName.Equals("kaan") && model.Password.Equals("123"))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.UserName)
                    };

                    var userIdentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                } 
                else
                {
                    ModelState.AddModelError("", "User name or password is wrong.");
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Login", new { area = "" });
        }
    }
}
