using KisiselSayfa.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Context = KisiselSayfa.Models.Classes.Context;

namespace KisiselSayfa.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.MainPages.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.MainPages.Find(id);
            return View("AnaSayfaGetir",ag);
        }

        public ActionResult AnaSayfaGuncelle(MainPage x)
        {
            var ag = c.MainPages.Find(x.id);
            ag.isim = x.isim;
            ag.profil = x.profil;
            ag.unvan = x.unvan;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ikonListele()
        {
            var deger = c.Iconses.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult NewIcon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewIcon(Icons p)
        {
            c.Iconses.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListele");
        }

        public ActionResult getIcon(int id) 
        {
            var ig = c.Iconses.Find(id);
            return View("getIcon", ig);
        }

        public ActionResult updateIcon(Icons x)
        {
            var ig = c.Iconses.Find(x.id);
            ig.icon = x.icon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListele");
        }

        public ActionResult deleteIcon(int id) 
        {
            var sl = c.Iconses.Find(id);
            c.Iconses.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListele");
        }

    }
}