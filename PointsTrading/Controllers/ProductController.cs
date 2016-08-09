using PointsTradingBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PointsTrading.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Category(string id)
        {
            ProdutsManager produtsManager = new ProdutsManager();
            ViewBag.Product = produtsManager.GetProducts(id);

            ViewBag.CatagoryName = produtsManager.GetProductCategories(id);

            return View();
        }


        public ActionResult Test()
        {
            return View();
        }
    }
}