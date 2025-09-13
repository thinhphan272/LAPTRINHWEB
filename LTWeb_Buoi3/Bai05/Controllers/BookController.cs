using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai05.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }    


        public ActionResult YourInfor()
        {
            return View();
        }    

        public ActionResult BookInfor()
        {
            return View();
        }    


    }
}