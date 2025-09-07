using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4.Models;  

namespace Bai4.Controllers
{
    public class HomeController : Controller
    {

        public List<Product> lstproduct = new List<Product>()
        {
            new Product{tenSP = "ỐNG ĐỒNG LUVATA DẠNG CUỘN", maSP = "SP01", imgURL = "/Content/Image/ongD1.jpg", moTa = "Ống đồng LHCT dạng cuộn chất lượng cao dành cho ngành công nghiệp lạnh"},
            new Product{tenSP = "ỐNG ĐỒNG LUVATA DẠNG BÀNH", maSP = "SP02",  imgURL = "/Content/Image/ongD2.jpg", moTa = "Ống đồng Luvata dạng bành được sử dụng nhiều trong việc lắp đặt"},
            new Product{tenSP = "ỐNG ĐỒNG METTUBE DẠNG CUỘN", maSP = "SP03",imgURL = "/Content/Image/ongD3.png", moTa = "Ống đồng Mettube dạng cuộn sử dụng trong máy lạnh đạt tiêu chuẩn cao"},
            
                
        };

      
    
        public ActionResult _LayoutPage() 
        {
            return View(lstproduct);
        }

        public ActionResult TrangChu()

        {
            return View(lstproduct);
        }    

    
    }
}