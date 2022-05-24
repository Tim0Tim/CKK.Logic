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
        //var Products = new List<ShoppingCartItem>();
        //private ShoppingCartItem _product1;
        //private ShoppingCartItem _product2;
        //private ShoppingCartItem _product3;

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
            foreach (var element in Products)
            if(prod.GetId() != 0 && quantity > 0 && element.GetProduct().GetId()== prod.GetId())
            {
                    var ai =
                        from e in Products
                        where (e != null && e.GetProduct().GetId() == prod.GetId())
                        select e;

                    if(quantity > 0)
                    {
                        element.SetQuantity(element.GetQuantity() + quantity);
                        return element;
                    }

             }
            return null;
            //if(prod.GetId() && quantity > 0 == Products.GetId() && Products.GetQuantity() > 0)
            //{

            //}
            //if(_product1 != null && _product1.GetProduct().GetId() == prod.GetId() && quantity > 0)
            //{
            //        _product1.SetQuantity(_product1.GetQuantity() + quantity);
            //        return _product1;
            //}
            //if(_product1 == null && quantity > 0)
            //{
            //    _product1 = new ShoppingCartItem(prod, quantity);
            //    return _product1;
            //}
            //if(_product2 != null && _product2.GetProduct().GetId() == prod.GetId() && quantity > 0)
            //{
            //    _product2.SetQuantity(_product2.GetQuantity() + quantity);
            //}
            //if(_product2 == null && quantity > 0)
            //{
            //    _product2 = new ShoppingCartItem(prod, quantity);
            //    return _product2;
            //}
            //if(_product3 != null && _product3.GetProduct().GetId() == prod.GetId() && quantity > 0)
            //{
            //    _product3.SetQuantity(_product3.GetQuantity() + quantity);
            //}
            //if(_product3 == null && quantity > 0)
            //{
            //    _product3 = new ShoppingCartItem(prod, quantity);
            //    return _product3;
            //}
            //else
            //{
            //    return null;
            //}
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

            //if(_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            //{
            //   _product1.SetQuantity(_product1.GetQuantity() - quantity);
            //    return _product1;
            //}
            //if(_product1 != null && _product1.GetQuantity() <= 0)
            //{
            //    _product1.SetQuantity(0);
            //    return _product1;
            //}
            //if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            //{
            //    _product2.SetQuantity(_product2.GetQuantity() - quantity);
            //    return _product2;
            //}
            //if (_product2 != null && _product2.GetQuantity() <= 0)
            //{
            //    _product2.SetQuantity(0);
            //    return _product2;
            //}
            //if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            //{
            //    _product3.SetQuantity(_product3.GetQuantity() - quantity);
            //    return _product3;
            //}
            //if (_product3 != null && _product3.GetQuantity() <= 0)
            //{
            //    _product3.SetQuantity(0);
            //    return _product3;
            //}
            //else
            //{
            //    return null;
            //}
        }

        public ShoppingCartItem GetProductById(int id)
        {
            /*IEnumerable<StoreItem>*//*var*/
            var si =
            from e in Products
            where (e.GetProduct().GetId() == id)
            select e;

            return si.FirstOrDefault();
            // if (_product1.GetProduct().GetId() == id)
            //{
            //    return _product1;
            //}
            // else if(_product2.GetProduct().GetId() == id)
            //{
            //    return _product2;
            //}
            // else if(_product3.GetProduct().GetId() == id)
            //{
            //    return _product3;
            //}
            //else
            //{
            //    return null;
            //}
        }

        public decimal GetTotal() //Get total price
        {
            decimal t = 0;
            // return 0;
            //return (_product1.GetTotal() + _product2.GetTotal() + _product3.GetTotal());
            //return prod.GetTotal();
            foreach (var e in Products)
            {
               t = e.GetProduct().GetPrice() + t;
            }
            return t;
        }

        public ShoppingCartItem GetProduct(int productNum) //get item id number
        {
            //    from e in Products
            //    where (e.GetProductById() == productNum)
            //    select e;
            //return gp;

            for (int t = 0; t < productNum; t++)
            {

                if (t == productNum)
                {
                   var m = Products[t];
                    return m;
                }
            }
            return null;
                
                

 
            //foreach(var element in Products)
            //{
            //    if(productNum == Products.FindIndex(element))
            //    {
            //        return element;
            //    }
            //}
            //return null;

            //if(productNum == 1)
            //{
            //    return _product1;
            //}
            //else if(productNum == 2)
            //{
            //    return _product2;
            //}
            //else if(productNum == 3)
            //{
            //    return _product3;
            //}
            //else
            //{
            //    return null;
            //}
        }     
    }
}
