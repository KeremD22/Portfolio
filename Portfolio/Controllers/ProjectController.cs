using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Project.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProject()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddProject(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}