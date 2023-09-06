using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {

            var values = db.Skill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            db.Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteSkill(int id)
        {
            var value = db.Skill.Find(id);
            db.Skill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var value = db.Skill.Find(skill.SkillID);
            value.Title = skill.Title;
            value.Value = skill.Value;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}