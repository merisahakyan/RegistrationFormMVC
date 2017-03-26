using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvcovie.Models;

namespace Mvcovie.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(User user)
        {
            ViewBag.user = user;
            return View();
        }


        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Include = "Name,Surname,eMail,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome");
            }
            return View(user);
        }
    }
}