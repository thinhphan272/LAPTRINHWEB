using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai05.Models;
using System.IO;

namespace Bai05.Controllers
{
    public class BookController : Controller
    {
        // GET: Book

        public static List<Book> lstBook = new List<Book>();
        public ActionResult Index()
        {
                
            return View();
        }

        public ActionResult BookList()
        {

            return View(lstBook);
        }

        public ActionResult Login()
        {
            return View();
        }    


        public ActionResult YourInfor(FormCollection fc)
        {
            string username = fc["username"];
            string password = fc["password"];
            ViewBag.Username = "UserName: " + username;
            ViewBag.Password = "Password: " + password;
            return View();
        }    

        public ActionResult BookInfor(Book bookinfor, HttpPostedFileBase ImageUrl)
        {
            var valueForm = bookinfor;
            if(ModelState.IsValid) 
            {
                string FileName = "";
                string Dir = "~/Content/Images";
                if(ImageUrl != null && ImageUrl.ContentLength > 0)
                {
                    FileName = Path.GetFileName(ImageUrl.FileName);
                    string physicalDir = Server.MapPath(Dir);
                    if(!Directory.Exists(physicalDir)) 
                    {
                        Directory.CreateDirectory(physicalDir);
                    }
                    string path = Path.Combine(Server.MapPath(Dir), FileName);
                    ImageUrl.SaveAs(path);
                    bookinfor.ImageUrl = Dir + "/" + FileName;
                      
                }
                
                lstBook.Add(bookinfor);
                return RedirectToAction("BookList");
            }
            return View("Index", bookinfor);
        }    


    }
}