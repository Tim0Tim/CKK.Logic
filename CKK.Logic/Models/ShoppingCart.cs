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
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart(Customer cust)
        {
            _customer = cust;
        }

        public int GetCustomerId()
        {
            return 5;
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            return null;

        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            if (_product1 == null)
            {
                return _product1;
            }
            else if (_product2 == null)
            {
                return _product2;
            }
            else if (_product3 == null)
            {
                return _product3;
            }
            else
            {
                return null;
            }
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
