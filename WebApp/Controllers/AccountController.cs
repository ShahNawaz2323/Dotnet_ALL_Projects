using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(string Username, string Password)
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            return View();
        }
    }
}