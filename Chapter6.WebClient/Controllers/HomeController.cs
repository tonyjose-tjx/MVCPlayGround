using Chapter6.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
namespace Chapter6.WebClient.Controllers
{
    public class HomeController : Controller
    {

        List<Product> products = new List<Product>();

        private IValueCalculator _calc;

        public HomeController(IValueCalculator calc)
        {
            _calc = calc;
            products.Add(new Product() { Name = "Tonys Kayak", Price = 10 });
            products.Add(new Product() { Name = "Tonys Snooker Table", Price = 12 });
            products.Add(new Product() { Name = "Tonys Pigeon Hole", Price = 13 });
            products.Add(new Product() { Name = "Tonys Cricket bat", Price = 14 });
            products.Add(new Product() { Name = "Tonys Basket ball", Price = 15 });
            products.Add(new Product() { Name = "Tonys Batminton bat", Price = 16 });
        }
        

        public ActionResult Index()
        {
            decimal value =  _calc.GetTotalValueOfProducts(products);
            return View(value);
        }
    }
}