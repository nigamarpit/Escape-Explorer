using IIW.DataContext;
using IIW.Models.ProjectModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IIW.Controllers
{
    public class HomeController : Controller
    {
        private IIWDBContext iiw = new IIWDBContext();
        private ApplicationDBContext db = new ApplicationDBContext();
        public ActionResult Index()
        {
            TempData["Cities"] = (from c in iiw.Locations
                                 select new Cities
                                 {
                                     CityName = c.CityName
                                 }).Distinct();
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

        public JsonResult CityAndZip(string Prefix)
        {
            var cityAndZip = iiw.Locations.Where(x => x.CityName == Prefix).Select(x=>new { val=x.CityName});
            //iiw.Locations.Where(x => x.CityName.Contains(Prefix)).Select(x => x.CityName).Distinct();
            //cityAndZip.Union(iiw.Locations.Where(x => x.ZipCode.Contains(Prefix)).Select(x=>x.ZipCode)).Distinct();
            return Json(cityAndZip, JsonRequestBehavior.AllowGet);
        }
    }
}