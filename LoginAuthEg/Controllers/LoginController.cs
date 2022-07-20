using LoginAuthEg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LoginAuthEg.Controllers
{
    public class LoginController : Controller
    {
        private readonly OrgContext db;
        private readonly ISession session;
        public LoginController(OrgContext _db,IHttpContextAccessor httpContextAccessor) //constructor
        {
            db = _db;
            session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User obj)
        {
            var result=(from i in db.users
                        where i.UserId == obj.UserId && i.Password == obj.Password  
                        select i).SingleOrDefault();
            if(result!=null)
            {
                HttpContext.Session.SetString("username", result.UserName);
               
                return RedirectToAction("Index", "Products");
            }
            else
            {
                return View();
            }
           
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User obj)
        {
            db.users.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
        
    }
}
