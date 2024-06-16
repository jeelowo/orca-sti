using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PT1.Models;

namespace PT1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult List()
        {
            var products = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Product A", Brand = "Brand A", Price = 10.99 },
                new Product { ProductID = 2, ProductName = "Product B", Brand = "Brand B", Price = 20.99 },
                new Product { ProductID = 3, ProductName = "Product C", Brand = "Brand C", Price = 30.99 },
                new Product { ProductID = 4, ProductName = "Product D", Brand = "Brand D", Price = 40.99 },
                new Product { ProductID = 5, ProductName = "Product E", Brand = "Brand E", Price = 50.99 }

            };

            return View(products);

        }
        
    }
}
