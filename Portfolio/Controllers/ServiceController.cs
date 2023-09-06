using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
   
    public class ServiceController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Service.ToList();
            return View(values);
        }
        public ActionResult AddService()
        {
            return View();
        }
    }
}