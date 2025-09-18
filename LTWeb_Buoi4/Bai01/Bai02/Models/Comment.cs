using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai02.Models
{
    public class Comment
    {
        public string userName {  get; set; }
        public string userAvatar {  get; set; }
        public DateTime commentDate { get; set; }
        public string commentContent { get; set; }
        public int rating { get; set; }

        public string FormattedDate => commentDate.ToString("dd/MM/yyyy");

        public string StarRating
        {
            get
            {
                string stars = "";
                for(int i = 1; i <= 5; i++)
                {
                    if (i <= rating)
                        stars += "★";
                    else
                        stars += "☆";
                }    
                return stars;
            }
        }    
    }
}