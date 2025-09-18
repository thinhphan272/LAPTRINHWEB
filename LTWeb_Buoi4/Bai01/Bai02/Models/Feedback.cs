using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai02.Models
{
    public class Feedback
    {
        public int totalComment { get; set; }
        public double averageRating { get; set; }
        public Dictionary<int, int> RatingCounts { get; set; }
        public List<Comment> lstComment { get; set; }

        public double ratingPercent(int stars)
        {
            if(totalComment == 0) return 0;
            return (double)RatingCounts[stars] / totalComment * 100;
        }    

    }
}