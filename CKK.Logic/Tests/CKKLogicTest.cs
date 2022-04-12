using System;
using Xunit;
using CKK.Logic.Models;
namespace CKK.Logic.Tests


{
    public class CKKLogicTest
    {
        [Fact]
        public void GetTotalPass()
        {
            var it1 = new Product();
            var it2 = new Product();
            var it3 = new Product();
            var Cu = new Customer();

            it1.SetId(112648); //6 diget
            it1.SetName("Tomato");
            it1.SetPrice(0.99m);

            it2.SetId(112612); //6 diget
            it2.SetName("orange");
            it2.SetPrice(1.02m);

            it3.SetId(112698); //6 diget
            it3.SetName("avacado");
            it3.SetPrice(1.33m);

            Cu.SetName("Dave");
            Cu.SetId(11111111);//8 diget
            Cu.SetAddress("1532 N 2253 W");
        }

        [Fact]
        public void GetTotalFail()
        {

        }

        [Fact]
        public void RemoveProductPass()
        {

        }

        [Fact]
        public void RemoveProductFail()
        {

        }

        [Fact]
        public void AddProductPass()
        {

        }

        [Fact]
        public void AddProductFail()
        {

        }
    }
}
// var ct = new Customer();
// var est = new ShoppingCart(ct);
//notes