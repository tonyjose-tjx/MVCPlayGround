using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter4.Domain.Models;

namespace Chapter4.WebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Product() { Price = 10, Name = "Tonys First Product" });
        }

        public ActionResult NameAndPrice()
        {
            ViewBag.ProductSelected = true;
            ViewBag.InStock = true;
            ViewBag.ProductCount = 10;
            return View(new Product() { Price = 10, Name = "Tonys First Product" });
        }

        public ActionResult List()
        {
            var products = new List<Product>();

            products.Add(new Product() { Name = "Tonys Kayak", Price = 10 });
            products.Add(new Product() { Name = "Tonys Snooker Table", Price = 12 });
            products.Add(new Product() { Name = "Tonys Pigeon Hole", Price = 13 });
            products.Add(new Product() { Name = "Tonys Cricket bat", Price = 14});
            products.Add(new Product() { Name = "Tonys Basket ball", Price = 15 });
            products.Add(new Product() { Name = "Tonys Batminton bat", Price = 16 });

            return View(products);
        }
    }
}