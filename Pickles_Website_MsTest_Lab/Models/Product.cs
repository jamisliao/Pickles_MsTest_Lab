using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pickles_Website_MsTest_Lab.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public ProductTypeEnum ProductType { get; set; }

        public ProductSizeEnum ProductSize { get; set; }
    }
}