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
        private string Name;
        private decimal price;


        public Product(string ProductName, int ProductId, decimal ProductPrice)
        {
            Id = ProductId;
            Name = ProductName;
            price = ProductPrice;
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                ;
            }
        }

        public int ProductId
        {
            get
            {
                return Id;
            }
            set
            {
                ;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                ;
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
