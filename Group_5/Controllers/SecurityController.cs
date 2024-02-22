using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Group_5.Models;

namespace Group_5.Controllers
{
    public class SecurityController : Controller
    {
        DbPersonel db = new DbPersonel();
        [HttpGet]
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userInDb = db.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password); //Is it available in the incoming user db?
            if (userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(userInDb.UserName, false); //The user is now authenticated, so the pages can be browsed.
                return RedirectToAction("Home", "Default");
            }
            else
            {
                ViewBag.Message = "Invalid Username or Password";
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}