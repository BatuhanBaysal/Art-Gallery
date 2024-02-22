using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Group_5.Models;

namespace Group_5.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
        [Authorize]

        [Route("Artist")]
        public ActionResult Artist()
        {
            ViewData["message"] = "ARTISTS";
            return View();
        }

        [Authorize]
        [Route("Exhibitions")]
        public ActionResult Exhibitions()
        {
            ViewData["message"] = "EXHIBITIONS";
            return View();
        }
        [Route("Store")]

        [Authorize]
        public ActionResult Store()
        {
            ViewData["message"] = "STORE";
            return View();
        }
        [Route("About")]
        public ActionResult About()
        {
            ViewData["message"] = "ABOUT";
            return View();
        }
        
        [HttpGet]
        public ActionResult Contact()
        {
            ViewData["message"] = "CONTACT US";
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact cont)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = cont.Name;
                ViewBag.email = cont.Email;
                ViewBag.phone = cont.Phone;
                ViewBag.country = cont.Country;
                ViewBag.message = cont.Message;
                return View("ContactResult", cont);
            }
            else { return View(); }
        }
        
        public ActionResult ContactResult()
        {
            return View();
        }
    }
}