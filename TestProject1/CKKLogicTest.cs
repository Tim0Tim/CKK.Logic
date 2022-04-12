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
            Product it1 = new Product();
            var it2 = new Product();
            var it3 = new Product();
            var Cu = new Customer();
           // var po1 = new ShoppingCartItem(it1, 1);
           // var po2 = new ShoppingCartItem(it2, 3);
          //  var po3 = new ShoppingCartItem(it3, 1);
            var sh = new ShoppingCart(Cu);


            it1.SetId(1); //6 diget
            it1.SetName("Tomato");
            it1.SetPrice(0.99m);
          //  po1.GetQuantity();
          //  po1.

            it2.SetId(2); //6 diget
            it2.SetName("orange");
            it2.SetPrice(1.02m);
        //    po2.GetQuantity();

            it3.SetId(3); //6 diget
            it3.SetName("avacado");
            it3.SetPrice(1.33m);
         //   po3.GetQuantity();

            Cu.SetName("Dave");
            Cu.SetId(11111111);//8 diget
            Cu.SetAddress("1532 N 2253 W");

            sh.AddProduct(it1, 1);
            sh.AddProduct(it2, 3);
            sh.AddProduct(it3, 1);
            var to = sh.GetTotal();
            Assert.Equal(5.38m, to);
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