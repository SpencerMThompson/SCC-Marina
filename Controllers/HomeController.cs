﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCC_Marina.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var loggedInUser = Session["Username"];

            ViewBag.Username = loggedInUser;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }
    }
}