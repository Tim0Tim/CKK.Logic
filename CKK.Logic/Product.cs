using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    class Product
    {
        private int Id;
        private string name;
        private decimal price;


        public Product(string ProductName, int ProductId, decimal ProductPrice)
        {
            Id = ProductId;
            name = ProductName;
            price = ProductPrice;
        }

        public decimal Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = price;
            }
        }

        public int ProductId
        {
            get
            {
                return ProductId;
            }
            set
            {
                ProductId = Id;
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = name;
            }
        }




        /*
        public GetProductId()
        {
            return Id;
        }

        public SetId(int Id)
        {
            Id;
        }

        public GetName()
        {
            return Name;
        }

        public SetName(string Name)
        {
            ;
        }

        public GetPrice()
        {
            return Price;
        }

        public SetPrice(decimal Price)
        {
            Price = price;
        }
        */
    }
}
