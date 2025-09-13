using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTWeb_Buoi3.Models;
using System.IO;

namespace LTWeb_Buoi3.Controllers
{
    public class HomeController : Controller
    {
        
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


        public ActionResult Search()
        {


            return View();
        }

        public ActionResult SubmitName(string productName)
        {
            ViewBag.Message = "Tên sản phẩm: " + productName;
            return View();
        }


        public ActionResult FormLogin()
        {
            return View();
        }

        public ActionResult Login(FormCollection fc)
        {
            string username = fc["username"];
            string password = fc["password"];

            ViewBag.Message = "Đăng nhập với user: " + username + ",pass: " + password;
            return View();
        }

        public ActionResult FromProductModel()
        {
            return View();
        }

        public ActionResult Add(ProductModel sp)
        {
            ViewBag.Message = "Tên: " + sp.Name + ", Giá: " + sp.Price;
            return View();
        }
        public ActionResult Index()
        {
            List<string> LCourse = new List<string>() { "1. HTML", "2. SQL" };
            ViewBag.LCourse = new SelectList(LCourse);
            return View();
        }


        public ActionResult MHXacNhan(Information infor, HttpPostedFileBase File)
        {
            var valueForm = infor;
            if (ModelState.IsValid)
            {
                string FileName = "";
                string Dir = "~/Content/Images";
                if(File != null && File.ContentLength > 0)
                {
                    FileName = Path.GetFileName(File.FileName);
                    string physicalDir = Server.MapPath(Dir);
                    if(!Directory.Exists(physicalDir))
                    {
                        Directory.CreateDirectory(physicalDir);
                    }
                    string path = Path.Combine(Server.MapPath(Dir), FileName);
                    File.SaveAs(path);
                }
                ViewBag.MyImage = Dir + "/" + FileName;
                return View(valueForm);
            }
            return View("Index", infor);
        }

    }
}