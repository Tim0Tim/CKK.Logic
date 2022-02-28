using System;

namespace CKK.Logic
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;

        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public GetQuantity()
        {
            return _quantity;
        }

        public SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public GetProduct()
        {
            return _product;
        }

        public SetProduct(Product product)
        {
            _product = product;
        }
    }
}
