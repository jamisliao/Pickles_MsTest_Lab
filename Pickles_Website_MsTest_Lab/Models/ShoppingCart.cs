using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pickles_Website_MsTest_Lab.Models
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }

        public ShoppingCart()
        {
            this.Products = new List<Product>();
        }
    }
}