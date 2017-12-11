using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSportsStorePractice.Domain.Abstract;


namespace MVCSportsStorePractice.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRespository _productRepsitory;

        public ProductsController(IProductRespository productRepository)
        {
            _productRepsitory = productRepository;
        }

        // GET: Products
        public ActionResult List()
        {
            return View(_productRepsitory.GetAllProducts());
        }
    }
}