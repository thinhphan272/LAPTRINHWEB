using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai02.Models
{
    public class Product
    {
        public int productID {  get; set; }
        public string productName {  get; set; }
        public string productDescription { get; set; }
        public string productImg { get; set; }
        public double productPrice { get; set; }

        public string FormattedPrice => productPrice.ToString("N0") + "đ";
    }
}