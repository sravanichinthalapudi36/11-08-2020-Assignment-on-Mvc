using MvcProductDetAss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProductDetAss.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var Products = GetProducts();
            return View(Products);
        }
        private IEnumerable<Product> GetProducts()
        {
            return new List<Product>{
               new Product{ProductName="fridge",ProductId=101,Rate=37899},
               new Product{ProductName="Ac",ProductId=102,Rate=97273592},
                 new Product{ProductName="Washing Machine", ProductId = 103,Rate=364924}

            };
        }
        public ActionResult Details(int id)
        {
            var Product = GetProducts().SingleOrDefault(d => d.ProductId == id);
            if (Product == null)
                return HttpNotFound();
            return View(Product);

        }
    }
}