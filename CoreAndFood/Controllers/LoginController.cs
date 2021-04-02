using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CoreAndFood.Controllers
{
    public class LoginController : Controller
    {
        Context db=new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Admin p)
        {
            var dataValue = db.Admins.FirstOrDefault(x => x.userName == p.userName && x.password == p.password);
            if (dataValue!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.userName)
                };
            var userIdentity=new ClaimsIdentity(claims,"Login");
            ClaimsPrincipal principal=new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
                //RedirectToAction("Index","Category");
                return Redirect("~/Category/Index");
            }

                return View();
            
            }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

    }
}
