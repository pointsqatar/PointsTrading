using PointsTradingBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PointsTrading.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.isHomeActive = "active";

            ProdutsManager produtsManager = new ProdutsManager();

            ViewBag.LatestProducts = produtsManager.GetProducts();

            return View();
        }
    }
}