﻿using System;
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

        public decimal Getprice()
        {
                return price;
        }

        public void Setprice(decimal ProductPrice)
        {
            price = ProductPrice;
        }

        public int GetId()
            {
                return Id;
            }

        public void SetId(int ProductId)
        {
            Id = ProductId;
        }

        public string GetName()
            {
                return name;
            }

        public void SetName(string ProductName)
        {
            name = ProductName;
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
