using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBuoi1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult HienThi(string ID)
        {
            return Content("ID = " + ID);
        }

        public ActionResult Index3(string ID, string Name)
        {
            ViewData["ID"] = ID;
            ViewData["Name"] = Name;

            ViewBag.ID = ID;
            ViewBag.Name = Name;
            return View();
        }

        public ActionResult LayoutPage()
        {
           
            return View();
        }

        public ActionResult IndexIncludeLayout()
        {

            return View();
        }

        public ActionResult TrangChu()
        {

            return View();
        }

        public ActionResult FormDangKy()
        {
            return View();
        }    

        public ActionResult FormDangNhap()
        {
            return View();
        }

    }
}
