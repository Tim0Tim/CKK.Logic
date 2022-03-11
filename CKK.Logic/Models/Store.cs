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
       // public decimal productPrice;

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
                prod = _product1;
            }
            else
            {
                if (_product2 == null) //if _product2 has no value change value to prod
                {
                    prod = _product2;
                }
                else
                {
                    if (_product3 == null) //if _product3 has no value change value to prod or do nothing
                    {
                        prod = _product3;
                    }
                }
            }
        }

        public void  RemoveStoreItem(int productNum)
        {
            if (_product1 == productNum)
            {
                _product1 = null;
            }
            else
            {
                if(_product2 == productNum)
                {
                    _product2 = null;
                }
                else
                {
                    if(_product3 == productNum)
                    {
                        _product3 = null;
                    }

                }
            }
        }

        public Product GetStoreItem(int productNum)
        {
           if( productNum == _id)//this area needs revising and changes to make it functunal.
            {
                _product1 = null;
                return _product1;
            }
           else
            {
                if (productNum == _id)
                {
                    _product2 = null;
                    return _product2;
                }
                else
                {
                    if (productNum == _id)
                    {
                        _product3 = null;
                        return _product3;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
          
          
            
            //return Product;
        }

        public Product FindStoreItemById(int id)
        {
           if(_product1 == id)
            {
                return _product1;
            }
           else if (_product2 == id)
            {
                return _product2;
            }
           else if(_product3 == id)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }
    }
}
