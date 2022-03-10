using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;
        public decimal productPrice;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int Id)
        {
            _id = Id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string Name)
        {
            _name = Name;
        }

        public AddStoreItem(Product prod)
        {
            ;
        }

        public void  RemoveStoreItem(int productNum)
        {
            return productNum;
        }

        public Product GetStoreItem(int productNum)
        {
           return productNum;
        }

        public Product FindStoreItemById(int id)
        {
           return id;
        }
    }
}
