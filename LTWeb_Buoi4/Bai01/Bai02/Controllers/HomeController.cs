using Bai02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Bai02.Controllers
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

        public ActionResult ProductDetail(int id = 1)
        {
            var product = new Product
            {
                productID = 1,
                productName = "FLAME $MAKER WASHED TEE IN BLACK",
                productPrice = 550000,
                productDescription = "Unisex Washed 100% Cotton Model wears size L",
                productImg = "/Content/Images/ao1.jpg"

            };

            var feedback = getProductFeedback(id);

            ViewBag.FeedBack = feedback;
            return View(product);

            
        }

        private Feedback getProductFeedback(int productId)
        {
            var comments = new List<Comment>
            {
                new Comment
                {
                    userName = "Lý Quốc Phong",
                    userAvatar = "/Content/Avatars/user1.jpg",
                    commentDate = new DateTime(2025, 7, 12),
                    commentContent = "Áo chất lắm anh em ơi, 10 điểm cho SMAKER và ANDREE.",
                    rating = 5
                },
                new Comment
                {
                    userName = "Trần Lả Lướt",
                    userAvatar = "/Content/Avatars/user2.jpg",
                    commentDate = new DateTime(2025, 7, 12),
                    commentContent = "Con áo này chiến đét, cứ phải gọi là nét cănggg.",
                    rating = 5
                },
                new Comment
                {
                    userName = "Nguyễn Băng Qua",
                    userAvatar = "/Content/Avatars/user3.jpg",
                    commentDate = new DateTime(2025, 7, 12),
                    commentContent = "Delivery hơi trễ nhưng không sao, áo cháy nên vẫn ok.",
                    rating = 4
                },


            };

            var ratingCounts = new Dictionary<int, int>
            {
                {5, 51}, {4, 17}, {3, 9}, {2, 4}, {1, 4}
            };



            return new Feedback
            {
                totalComment = 85,
                averageRating = 4.3,
                RatingCounts = ratingCounts,
                lstComment = comments
            };  
            

        }   
        

        public ActionResult _ProductReviews(int productId = 1)
        {
            var feedback = getProductFeedback(productId);
            return PartialView(feedback);
        }    

        public ActionResult _Comment(int productId = 1) 
        {
            var feedback = getProductFeedback(productId);
            return PartialView(feedback.lstComment);
            
        }
        
    }
}