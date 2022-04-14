using System;
using Xunit;
using CKK.Logic.Models;


namespace CKK.Logic.Tests
{
    public class CKKLogicTest 
    {
        [Fact]
        public void GetTotalPass() //Complete
        {
            var it1 = new Product();
            var it2 = new Product();
            var it3 = new Product();
            var Cu = new Customer();
            var sh = new ShoppingCart(Cu);

            it1.SetId(1);
            it1.SetName("Tomato");
            it1.SetPrice(0.99m);

            it2.SetId(2);
            it2.SetName("orange");
            it2.SetPrice(1.02m);

            it3.SetId(3);
            it3.SetName("avacado");
            it3.SetPrice(1.33m);

            Cu.SetName("Dave");
            Cu.SetId(11111111);
            Cu.SetAddress("1532 N 2253 W");

            sh.AddProduct(it1, 1);
            sh.AddProduct(it2, 3);
            sh.AddProduct(it3, 1);
            var to = sh.GetTotal();
            Assert.Equal(5.38m, to);
        }

        [Fact]
        public void GetTotalWrong() //Complete
        {
            var it1 = new Product();
            var it2 = new Product();
            var it3 = new Product();
            var Cu = new Customer();
            var sh = new ShoppingCart(Cu);

            it1.SetId(1);
            it1.SetName("Tomato");
            it1.SetPrice(0.99m);

            it2.SetId(2);
            it2.SetName("orange");
            it2.SetPrice(1.02m);

            it3.SetId(3);
            it3.SetName("avacado");
            it3.SetPrice(1.33m);

            Cu.SetName("Dave");
            Cu.SetId(11111111);
            Cu.SetAddress("1532 N 2253 W");

            sh.AddProduct(it1, 1);
            sh.AddProduct(it2, 3);
            sh.AddProduct(it3, 1);
            var to = sh.GetTotal();
            Assert.NotEqual(5.00m, to);
        }

        [Fact]
        public void RemoveProductPass()
        {
            var it1 = new Product();
            var it2 = new Product();
            var it3 = new Product();
            var Cu = new Customer();
            var sh = new ShoppingCart(Cu);

            it1.SetId(1);
            it1.SetName("Tomato");
            it1.SetPrice(0.99m);
            
            it2.SetId(2);
            it2.SetName("orange");
            it2.SetPrice(1.02m);

            it3.SetId(3);
            it3.SetName("avacado");
            it3.SetPrice(1.33m);

            Cu.SetName("Dave");
            Cu.SetId(11111111);
            Cu.SetAddress("1532 N 2253 W");

            sh.AddProduct(it1, 2);
            sh.AddProduct(it2, 1);
            sh.AddProduct(it3, 4);

            sh.RemoveProduct(it1, 1);
            sh.RemoveProduct(it2, 1);
            sh.RemoveProduct(it3, 1);

            var ro1 = sh.GetProduct(1).GetQuantity();
            var ro2 = sh.GetProduct(2).GetQuantity();
            var ro3 = sh.GetProduct(3).GetQuantity();

            Assert.Equal(1, ro1);
            Assert.Equal(0, ro2);
            Assert.Equal(3, ro3);

        }

        [Fact]
        public void RemoveProductWrong()
        {

        }

        [Fact]
        public void AddProductPass()
        {

        }

        [Fact]
        public void AddProductWrong()
        {

        }
    }
}
// var ct = new Customer();
// var est = new ShoppingCart(ct);
//notes
//more junk