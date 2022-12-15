using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStartV1.Models;

namespace WebStartV1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
           if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            return View();
        }
    }
}