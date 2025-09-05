using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleBuoi1.Models;

namespace SampleBuoi1.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            List<Product> lstProduct = new List<Product>()
            {
                new Product {title = "Hoa cưới 1", imageURL="/Content/Image/cuoi1.jpg", price = 600000 },
                 new Product {title = "Hoa cưới 2", imageURL="/Content/Image/cuoi2.jpg", price = 600000 },
                  new Product {title = "Hoa cưới 3", imageURL="/Content/Image/cuoi3.jpg", price = 600000 },
                   new Product {title = "Hoa cưới 4", imageURL="/Content/Image/cuoi4.jpg", price = 600000 },
                    new Product {title = "Sinh nhật 1", imageURL="/Content/Image/sinhnhat1.jpg", price = 600000 },
                     new Product {title = "Sinh nhật 2", imageURL="/Content/Image/sinhnhat2.jpg", price = 600000 },
                      new Product {title = "Sinh nhật 3", imageURL="/Content/Image/sinhnhat3.jpg", price = 600000 },
                       new Product {title = "Sinh nhật 4", imageURL="/Content/Image/sinhnhat4.jpg", price = 600000 },
            };
            return View(lstProduct);
        }

    }
}
