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

        public List<Product_Book> lstBook = new List<Product_Book>()
        {
            new Product_Book { maSach = "S01", tenSach = ""}
        }; 

        public ActionResult ListProduct() 
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
    }
}