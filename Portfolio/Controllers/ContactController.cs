using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
       [HttpGet]
        public ActionResult Index()
        {
            ViewBag.description = db.Address.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Address.Select(x => x.Phone).FirstOrDefault();
            ViewBag.mail = db.Address.Select(x => x.Mail).FirstOrDefault();
            ViewBag.addressdetail = db.Address.Select(x => x.AddressDetail).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

    }
}