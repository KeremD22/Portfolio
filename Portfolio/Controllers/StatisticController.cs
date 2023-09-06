﻿using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();

        public ActionResult Index()
        {
            ViewBag.totalProjectCount = db.Project.Count();
            ViewBag.totalProjectCount = db.Testimonial.Count();
            ViewBag.sumWorkDay = db.Project.Sum(x=>x.CompleteDay);
            ViewBag.avgWorkDay = db.Project.Average(x => x.CompleteDay);
            var value1 = ViewBag.avgPrice = db.Project.Average(x => x.Price);
            String.Format("{0:0.##}",value1);
            var value = db.Project.Max(x => x.Price);
            ViewBag.maxPriceProject = db.Project.Where(x => x.Price == value).Select(y=>y.Title).FirstOrDefault();
            var value2 = db.Category.Where(x => x.CategoryName == "AspNet Core Web Geliştirme").Select(y => y.CategoryID).FirstOrDefault();
            ViewBag.categoryCountByName = db.Project.Where(x => x.ProjectCategory == value2).Count();
            return View();
           
        }
    }
}