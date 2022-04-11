using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer Customer;
        private ShoppingCartItem Product1;
        private ShoppingCartItem Product2;
        private ShoppingCartItem Product3;

        public ShoppingCart(Customer cust)
        {
            Customer = cust;
        }

        public int GetCustomerId()
        {
            return 0;
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            return null;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return null;
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            return null;
        }

        public ShoppingCartItem GetProductById(int id)
        {
            return null;
        }

        public decimal GetTotal()
        {
            return 0;
        }

        public ShoppingCartItem GetProduct(int productNum)
        {
            return null;
        }     
    }
}
