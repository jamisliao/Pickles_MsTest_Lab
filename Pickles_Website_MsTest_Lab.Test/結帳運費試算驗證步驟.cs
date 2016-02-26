using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pickles_Website_MsTest_Lab.Models;
using Pickles_Website_MsTest_Lab.Service;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Pickles_Website_MsTest_Lab.Test
{
    [Binding]
    public class 結帳運費試算驗證步驟
    {
        private ShoppingCart _shoppingCart;
        private bool _isVip;

        public 結帳運費試算驗證步驟()
        {
            this._shoppingCart = new ShoppingCart();
            this._isVip = false;
        }
        [Given(@"購物車中有")]
        public void Given購物車中有(Table table)
        {
            this._shoppingCart.Products = table.CreateSet<Product>().ToList();
        }

        [Given(@"使用者為 (.*)")]
        public void Given使用者為(string userType)
        {
            if (userType.ToLower() == "vipuser")
            {
                this._isVip = true;
            }
        }

        [When(@"計算運費")]
        public void When計算運費()
        {
            var target = new PayService();
            var delivery = target.CalculatorDelivery(this._shoppingCart, this._isVip);

            ScenarioContext.Current.Set(delivery, "delivery");
        }

        [Then(@"運費應為 (.*)")]
        public void Then運費應為(int expectedDelivery)
        {
            var actualDelivery = ScenarioContext.Current.Get<decimal>("delivery");

            Assert.AreEqual(expectedDelivery, actualDelivery);
        }
    }
}
