using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai03.Models;

namespace Bai03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public Data data = new Data()
        {
            lstCategory = new List<Category>(){
                new Category(){categoryID = "1", categoryName = "Nước uống"},
                new Category(){categoryID = "2", categoryName = "Ăn vặt"},
                new Category(){categoryID = "3", categoryName = "Giải trí"},
            },
            lstProduct = new List<Product>(){
                new Product(){productTypeID = "1", price = 25000 ,productName = "Trà sữa chân châu"},
                new Product(){productTypeID = "2", price = 20000  ,productName = "Bánh tráng trộn"},
                new Product(){productTypeID = "3", price = 35000 ,productName = "Tô tượng"},
            }
        };

        public ActionResult _Category()
        {
            return PartialView(data);

        }
        public ActionResult _ProductList()
        {
            return PartialView(data);
        }

        public ActionResult Product()
        {
            return View();
        }
    }
}