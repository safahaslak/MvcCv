using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity; // bu library i eklemezsek veritabanını kullanamayız.

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities(); // db nesnesini ekledik
        public ActionResult Index()
        {
            var degerler = db.TblHakkimdas.ToList();
            return View(degerler);
        }
    }
}