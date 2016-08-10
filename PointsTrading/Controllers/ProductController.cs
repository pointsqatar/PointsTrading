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
            ViewBag.CatagoryName = produtsManager.GetProductCategories(id);

            if (Request.QueryString["productID"] != null && Request.QueryString["productID"] != string.Empty)
            {
                string productID = Request.QueryString["productID"];

                ViewBag.Product = produtsManager.GetProductById(productID);

                return View("~/Views/Product/ProductDetail.cshtml");
            }
            else
            {
                ViewBag.Products = produtsManager.GetProducts(id);

                return View();
            }
        }
    }
}