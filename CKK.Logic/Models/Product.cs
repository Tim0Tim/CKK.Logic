using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _Id;
        private string _Name;
        private decimal _price;


        public Product(string Name, int Id, decimal Price)
        {
            _Id = Id;
            _Name = Name;
            _price = Price;
        }

        public decimal Getprice()
        {
                return _price;
        }

        public void Setprice(decimal Price)
        {
            _price = Price;
        }

        public int GetId()
            {
                return _Id;
            }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public string GetName()
            {
                return _Name;
            }

        public void SetName(string Name)
        {
            _Name = Name;
        }


    }
}
