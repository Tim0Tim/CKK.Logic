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


        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            var element = GetProductById(id);


            if (element != null)
            {
                if(element.GetQuantity() - quantity > 0)
                {
                    element.SetQuantity(element.GetQuantity() - quantity);
                }
                else
                {
                    element.SetQuantity(0);
                    Products.Remove(element);
                }

                    return element;
            }
            else
            {
                return null;
            }
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

        public List<ShoppingCartItem> GetProducts() //get item id number
        {
            return Products;
        }     
    }
}
