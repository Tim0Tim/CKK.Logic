using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private List<ShoppingCartItem> Products;


        public ShoppingCart(Customer cust)
        {
            _customer = cust;
            Products = new List<ShoppingCartItem>();
        }

        public int GetCustomerId()
        {
            return _customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            var ai =
            from e in Products
            where (e != null && e.GetProduct().GetId() == prod.GetId())
            select e;

            foreach (var element in ai)
            {
                if (prod.GetId() != 0 && quantity > 0 && element.GetProduct().GetId() == prod.GetId())
                {


                    if (quantity > 0)
                    {
                        element.SetQuantity(element.GetQuantity() + quantity);
                        return element;
                    }

                }
               
            }
            if (prod.GetId() != 0 && quantity > 0)
            {
                var tt = new ShoppingCartItem(prod, quantity);
                Products.Add(tt);
                return tt;
            }
            return null;
           
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
                return AddProduct(prod,1);
        }

        public  ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            var ri =
                from e in Products
                where (e != null && e.GetProduct().GetId() == prod.GetId())
                select e;

            foreach(var element in ri)
            {
                if(element.GetQuantity() <= 0)
                {
                    element.SetQuantity(0);
                }
                else
                {
                     element.SetQuantity(element.GetQuantity() - quantity);
                }
                return element;
            }
            return null;

        }

        public ShoppingCartItem GetProductById(int id)
        {

            var si =
            from e in Products
            where (e.GetProduct().GetId() == id)
            select e;

            return si.FirstOrDefault();
           
        }

        public decimal GetTotal() //Get total price
        {
            decimal t = 0;

            foreach (var e in Products)
            {
               t = e.GetTotal() + t;
            }
            return t;
        }

        public ShoppingCartItem GetProducts(int productNum) //get item id number
        {
            var gp =
            from e in Products
            where (e.GetProduct().GetId() == productNum)
            select e;


            for (int t = 0; t <= productNum; t++)
            {

                if (t == productNum)
                {


                    return Products[t - 1];

                }
            }
            return null;

        }     
    }
}
