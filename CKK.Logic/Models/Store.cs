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

        public void AddStoreItem(Product prod)
        {
            if (_product1 == null) //if _product1 has no value change value to prod
            {
                _product1 = prod;
            }
            else
            {
                if (_product2 == null) //if _product2 has no value change value to prod
                {
                    _product2 = prod;
                }
                else
                {
                    if (_product3 == null) //if _product3 has no value change value to prod or do nothing
                    {
                        _product3 = prod;
                    }
                }
            }
           /* if() //if _product1 is ocupied skip
            {
                if() // if _product2 is occupied skip
                {
                    if() //if _product3 is occupied do nothing
                }
            }*/
        }

        public void  RemoveStoreItem(int productNum)
        {
            
        }

        public Product GetStoreItem(int productNum)
        {
           return Product;
        }

        public Product FindStoreItemById(int id)
        {
           return Product;
        }
    }
}
