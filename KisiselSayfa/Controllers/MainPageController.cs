using KisiselSayfa.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselSayfa.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage 
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.MainPages.ToList();
            return View(deger);
        }

        public PartialViewResult Icon()
        {
            var deger = c.Iconses.ToList();
            return PartialView(deger);
        }
    }
}