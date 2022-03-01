using System;

namespace CKK.Logic
{
    class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;
        
        private string stuff;

        
        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public int quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = _quantity;
            }
        }

        public string Product
        {
            get
            {
                return Product;
            }
            set
            {
                Product = _product;
            }                     // The Problem Is right here!!
        }

            /*
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
            */
        }
}
