using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pickles_Website_MsTest_Lab.Models;

namespace Pickles_Website_MsTest_Lab.Service
{
    public class PayService
    {
        private Dictionary<ProductSizeEnum, int> _deliveryDict;

        public PayService()
        {
            this._deliveryDict = new Dictionary<ProductSizeEnum, int>()
            {
                {ProductSizeEnum.Small, 100},
                {ProductSizeEnum.Medium, 200},
                {ProductSizeEnum.Big, 300}
            };    
        }

        public decimal CalculatorDelivery(ShoppingCart shoppingCart, bool isVip)
        {
            var delivery = 0;
            var bookCount = shoppingCart.Products.Count(p => p.ProductType == ProductTypeEnum.Book);
            var containOther = shoppingCart.Products.Exists(p => p.ProductType != ProductTypeEnum.Book);

            var isFreeDelivery = bookCount > 4 && containOther == false && isVip;

            if (!isFreeDelivery)
            {
                var mostBigSize = shoppingCart.Products.OrderByDescending(p => this._deliveryDict[p.ProductSize]).First().ProductSize;
                delivery = this._deliveryDict[mostBigSize];
            }

            return delivery;
        }
    }
}