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
            return _customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if(_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
                _product1.SetQuantity(_product1.GetQuantity() + quantity);
                return _product1;
            }
            if(_product1 == null)
            {
                _product1 = new ShoppingCartItem(prod, quantity);
                return _product1;
            }
            if(_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() + quantity);
            }
            if(_product2 == null)
            {
                _product2 = new ShoppingCartItem(prod, quantity);
                return _product2;
            }
            if(_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() + quantity);
            }
            if(_product3 == null)
            {
                _product3 = new ShoppingCartItem(prod, quantity);
                return _product3;
            }
            else
            {
                return null;
            }
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
                return AddProduct(prod,1);
        }

        public  ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {

            if(_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
               _product1.SetQuantity(_product1.GetQuantity() - quantity);
                return _product1;
            }
            if(_product1 != null && _product1.GetQuantity() <= 0)
            {
                _product1.SetQuantity(0);
                return _product1;
            }
            if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() - quantity);
                return _product2;
            }
            if (_product2 != null && _product2.GetQuantity() <= 0)
            {
                _product2.SetQuantity(0);
                return _product2;
            }
            if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() - quantity);
                return _product3;
            }
            if (_product3 != null && _product3.GetQuantity() <= 0)
            {
                _product3.SetQuantity(0);
                return _product3;
            }
            else
            {
                return null;
            }
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
