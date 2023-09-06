﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Portfolio.Models;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class RegisterController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            db.Admin.Add(admin);
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}