using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //ViewBag.Message = "Welcome to ASP.NET MVC!";

            var model = new RestaurantReview()
            {
                Name = "Cili Pica",
                Rating = 4
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Location = "Vilnius, Lithuania";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}