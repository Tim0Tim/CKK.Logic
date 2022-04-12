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
            _customer.GetId();
            return 5;
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if(_product1.GetProduct() == prod)
            {
               _product1.GetQuantity();
            }
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

        public  ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if(_product1 != null)
            {
                _product1.SetQuantity(quantity - 1);
                if(quantity <= 1)
                {
                    _product1 = null;
                }
                return _product1;
            }
            else if(_product2 != null)
            {
                _product2.SetQuantity(quantity - 1);
                if(quantity <= 1)
                {
                    _product2 = null;
                }
                return _product2;
            }
            else if(_product3 != null)
            {
                _product3.SetQuantity(quantity - 1);
                if(quantity <= 1)
                {
                    _product3 = null;
                }
                return _product3;
            }
            else
            {
                return null;
            }//possibly complete
        }

        public ShoppingCartItem GetProductById(int id)
        {
             if (_product1.GetProduct().GetId() == id)
            {
                return _product1;
            }
             else if(_product2.GetProduct().GetId() == id)
            {
                return _product2;
            }
             else if(_product3.GetProduct().GetId() == id)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }//complete

        public decimal GetTotal() //Get total price
        {
            return (_product1.GetTotal() + _product2.GetTotal() + _product3.GetTotal());
// probally complete
        }

        public ShoppingCartItem GetProduct(int productNum) //get item id number
        {
            if(productNum == 1)
            {
                return _product1;
            }
            else if(productNum == 2)
            {
                return _product2;
            }
            else if(productNum == 3)
            {
                return _product3;
            }
            else
            {
                return null;
            }//believed to be complete
        }     
    }
}
