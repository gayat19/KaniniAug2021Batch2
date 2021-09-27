using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoreMVCApplication.Models;
using Microsoft.AspNetCore.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MoreMVCApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        public IActionResult UserLogin()
        {
            _logger.LogInformation("Login hit "+DateTime.Now.ToString());
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Username.Length == 3 && user.Password.Length == 4)
                {
                    //TempData["username"] = user.Username;
                    HttpContext.Session.SetString("username", user.Username);
                    return RedirectToAction("Index", "Home");
                }
                else
                    _logger.LogError("Invalid login attempt " + DateTime.Now);
            }
            
            return View();
        }
    }
}
