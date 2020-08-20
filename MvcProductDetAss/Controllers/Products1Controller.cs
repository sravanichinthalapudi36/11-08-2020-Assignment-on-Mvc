using MvcProductDetAss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProductDetAss.Controllers
{
    public class Products1Controller : Controller
    {
        // GET: Products1
        public ActionResult Index1()
        {
            var Products1 = GetProducts1();
            return View(Products1);
           
        }
        private IEnumerable<Product1> GetProducts1()
        {
            return new List<Product1>{
               new Product1{id=101,name="Ac",rate=82391},
               new Product1{id=102,name="Fridge",rate=735283},
                new Product1{id=103,name="washing machine",rate=734283}

            };
        }
        public ActionResult Details(int id)
        {
            var Product = GetProducts1().SingleOrDefault(d => d.id == id);
            if (Product == null)
                return HttpNotFound();
            return View(Product);

        }
    }
}