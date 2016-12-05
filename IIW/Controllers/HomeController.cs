using IIW.DataContext;
using IIW.Models.ProjectModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            int count;
            Random r;
            int rInt1;
            int rInt2;
            string s1;
            string s2;
            string desc1, desc2;
            while (true)
            {
                try
                {
                    count = iiw.Events.Count();
                    r = new Random();
                    rInt1 = r.Next(1, count);
                    rInt2 = r.Next(1, count);
                    while (rInt1 == rInt2)
                    {
                        rInt2 = r.Next(1, count);
                    }
                    s1 = iiw.Events.Where(x => x.EventId == rInt1).FirstOrDefault().EventImgSource;
                    s2 = iiw.Events.Where(x => x.EventId == rInt2).FirstOrDefault().EventImgSource;
                    using (WebClient client = new WebClient())
                    {
                        string e1 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Event1.png";
                        string e2 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Event2.png";
                        client.DownloadFile(new Uri(s1), e1);
                        client.DownloadFile(new Uri(s2), e2);
                        desc1 = "<label>Name : </label>" + iiw.Events.Where(x => x.EventId == rInt1).FirstOrDefault().EventName + "<br/>";
                        desc1 += "<label>Address : </label>" + iiw.Events.Where(x => x.EventId == rInt1).FirstOrDefault().EventAddress + "<br/>";
                        desc1 += "<label>URL : </label><a>" + iiw.Events.Where(x => x.EventId == rInt1).FirstOrDefault().EventURL + "</a><br/>";

                        desc2 = "<label>Name : </label>" + iiw.Events.Where(x => x.EventId == rInt2).FirstOrDefault().EventName + "<br/>";
                        desc2 += "<label>Address : </label>" + iiw.Events.Where(x => x.EventId == rInt2).FirstOrDefault().EventAddress + "<br/>";
                        desc2 += "<label>URL : </label><a>" + iiw.Events.Where(x => x.EventId == rInt2).FirstOrDefault().EventURL + "</a><br/>";
                        TempData["EventDesc1"] = desc1;
                        TempData["EventDesc2"] = desc2;
                    }
                    break;
                }
                catch (Exception e)
                {
                    continue;
                }
            }

            while (true)
            {
                try
                {
                    count = iiw.Attractions.Count();
                    rInt1 = r.Next(1, count);
                    rInt2 = r.Next(1, count);
                    while (rInt1 == rInt2)
                    {
                        rInt2 = r.Next(1, count);
                    }
                    s1 = iiw.Attractions.Where(x => x.AttractionId == rInt1).FirstOrDefault().AttractionImgSource;
                    s1 = s1.Substring(0, s1.Length - 3);
                    s2 = iiw.Attractions.Where(x => x.AttractionId == rInt2).FirstOrDefault().AttractionImgSource;
                    s2 = s2.Substring(0, s2.Length - 3);
                    using (WebClient client = new WebClient())
                    {
                        string e1 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Attraction1.png";
                        string e2 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Attraction2.png";
                        client.DownloadFile(new Uri(s1), e1);
                        client.DownloadFile(new Uri(s2), e2);
                        desc1 = "<label>Name : </label>" + iiw.Attractions.Where(x => x.AttractionId == rInt1).FirstOrDefault().AttractionName + "<br/>";
                        desc1 += "<label>Desciption : </label>" + iiw.Attractions.Where(x => x.AttractionId == rInt1).FirstOrDefault().AttractionDescription + "<br/>";

                        desc2 = "<label>Name : </label>" + iiw.Attractions.Where(x => x.AttractionId == rInt2).FirstOrDefault().AttractionName + "<br/>";
                        desc2 += "<label>Desciption : </label>" + iiw.Attractions.Where(x => x.AttractionId == rInt2).FirstOrDefault().AttractionDescription + "<br/>";
                        TempData["AttractionDesc1"] = desc1;
                        TempData["AttractionDesc2"] = desc2;
                    }
                    break;
                }
                catch (Exception e)
                {
                    continue;
                }
            }

            while (true)
            {
                try
                {
                    count = iiw.Movies.Count();
                    rInt1 = r.Next(1, count);
                    rInt2 = r.Next(1, count);
                    while (rInt1 == rInt2)
                    {
                        rInt2 = r.Next(1, count);
                    }
                    s1 = iiw.Movies.Where(x => x.MovieId == rInt1).FirstOrDefault().MovieImgSource;
                    s2 = iiw.Movies.Where(x => x.MovieId == rInt2).FirstOrDefault().MovieImgSource;
                    using (WebClient client = new WebClient())
                    {
                        string e1 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Movie1.png";
                        string e2 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Movie2.png";
                        client.DownloadFile(new Uri(s1), e1);
                        client.DownloadFile(new Uri(s2), e2);
                        desc1 = "<label>Movie Name : </label>" + iiw.Movies.Where(x => x.MovieId == rInt1).FirstOrDefault().MovieName + "<br/>";
                        desc1 += "<label>Show Times : </label>" + iiw.Movies.Where(x => x.MovieId == rInt1).FirstOrDefault().MovieShowTimes + "<br/>";
                        desc1 += "<label>Theater Name : </label>" + iiw.Movies.Where(x => x.MovieId == rInt1).FirstOrDefault().MovieTheaterName + "<br/>";
                        desc1 += "<label>Theater Address : </label>" + iiw.Movies.Where(x => x.MovieId == rInt1).FirstOrDefault().MovieTheaterAddress + "<br/>";

                        desc2 = "<label>Movie Name : </label>" + iiw.Movies.Where(x => x.MovieId == rInt2).FirstOrDefault().MovieName + "<br/>";
                        desc2 += "<label>Show Times : </label>" + iiw.Movies.Where(x => x.MovieId == rInt2).FirstOrDefault().MovieShowTimes + "<br/>";
                        desc2 += "<label>Theater Name : </label>" + iiw.Movies.Where(x => x.MovieId == rInt2).FirstOrDefault().MovieTheaterName + "<br/>";
                        desc2 += "<label>Theater Address : </label>" + iiw.Movies.Where(x => x.MovieId == rInt2).FirstOrDefault().MovieTheaterAddress + "<br/>";

                        TempData["MovieDesc1"] = desc1;
                        TempData["MovieDesc2"] = desc2;
                    }
                    break;
                }
                catch (Exception e)
                {
                    continue;
                }
            }

            while (true)
            {
                try
                {
                    count = iiw.Restaurants.Count();
                    rInt1 = r.Next(1, count);
                    rInt2 = r.Next(1, count);
                    while (rInt1 == rInt2)
                    {
                        rInt2 = r.Next(1, count);
                    }
                    s1 = iiw.Restaurants.Where(x => x.RestaurantId == rInt1).FirstOrDefault().RestaurantImage;
                    s2 = iiw.Restaurants.Where(x => x.RestaurantId == rInt2).FirstOrDefault().RestaurantImage;
                    using (WebClient client = new WebClient())
                    {
                        string e1 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Restaurant1.png";
                        string e2 = AppDomain.CurrentDomain.BaseDirectory + "/Content/Images/Restaurant2.png";
                        client.DownloadFile(new Uri(s1), e1);
                        client.DownloadFile(new Uri(s2), e2);
                        desc1 = "<label>Restaurant Name : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt1).FirstOrDefault().RestaurantName + "( <b>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt1).FirstOrDefault().RestaurantRating.ToString() + "</b>)<br/>";
                        desc1 += "<label>Cuisine : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt1).FirstOrDefault().RestaurantCuisine + "<br/>";
                        desc1 += "<label>Address : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt1).FirstOrDefault().RestaurantAddress + "<br/>";
                        desc1 += "<label>Telephone : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt1).FirstOrDefault().RestaurantTelephone + "<br/>";

                        desc2 = "<label>Restaurant Name : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt2).FirstOrDefault().RestaurantName + "( <b>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt2).FirstOrDefault().RestaurantRating.ToString() + "</b>)<br/>";
                        desc2 += "<label>Cuisine : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt2).FirstOrDefault().RestaurantCuisine + "<br/>";
                        desc2 += "<label>Address : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt2).FirstOrDefault().RestaurantAddress + "<br/>";
                        desc2 += "<label>Telephone : </label>" + iiw.Restaurants.Where(x => x.RestaurantId == rInt2).FirstOrDefault().RestaurantTelephone + "<br/>";

                        TempData["RestaurantDesc1"] = desc1;
                        TempData["RestaurantDesc2"] = desc2;
                    }
                    break;
                }
                catch (Exception e)
                {
                    continue;
                }
            }

            string json = new WebClient().DownloadString("http://ip-api.com/json");
            JObject y = JObject.Parse(json);
            string city = (string)y["city"];
            TempData["CurrentCity"] = "\'"+city+"\'";

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
            var cityAndZip = iiw.Locations.Where(x => x.CityName == Prefix).Select(x => new { val = x.CityName });
            //iiw.Locations.Where(x => x.CityName.Contains(Prefix)).Select(x => x.CityName).Distinct();
            //cityAndZip.Union(iiw.Locations.Where(x => x.ZipCode.Contains(Prefix)).Select(x=>x.ZipCode)).Distinct();
            return Json(cityAndZip, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetActivities(string City)
        {
            return Json(0);
        }
    }
}