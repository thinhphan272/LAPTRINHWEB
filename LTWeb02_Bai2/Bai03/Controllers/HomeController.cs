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
            new Product_Book { maSach = "S01", tenSach = "Toán 10 Nâng cao", gia = 15000, hinhanh = "h1.png", maLoai = 1, tenLoai = "Sách giáo khoa"},
            new Product_Book { maSach = "S02", tenSach = "Ngữ văn 11", gia = 21000, hinhanh = "h2.png", maLoai = 1, tenLoai = "Sách giáo khoa"},
            new Product_Book { maSach = "S03", tenSach = "Từ điển 1000 từ", gia = 56000, hinhanh = "h3.png", maLoai = 2, tenLoai = "Từ điển"},
            new Product_Book { maSach = "S04", tenSach = "Anh - Việt 500 từ", gia = 47000, hinhanh = "h4.png", maLoai = 2, tenLoai = "Từ điển"},
            new Product_Book { maSach = "S05", tenSach = "Anh - Anh", gia = 120900, hinhanh = "h5.png", maLoai = 2, tenLoai = "Từ điển"},
            new Product_Book { maSach = "S011", tenSach = "Cơ sở dữ liệu", gia = 34000, hinhanh = "h11.png", maLoai = 3, tenLoai = "Sách đại học"},
            new Product_Book { maSach = "S014", tenSach = "Doreamon", gia = 45000, hinhanh = "h14.png", maLoai = 4, tenLoai = "Truyện tranh"}

        }; 

        public ActionResult ListProduct() 
        {

            
            return View(lstBook);
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