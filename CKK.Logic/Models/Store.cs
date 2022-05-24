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
        private List<StoreItem> Items;
        //private var Items = new List<StoreItem>();
        //private Product _product1;
        //private Product _product2;
        //private Product _product3;
        // public decimal productPrice;

        public Store()
        {
            Items = new List<StoreItem>();
           // int _Id = _id;
        }

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

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            //if (Items.Contains<>
          //  foreach 
            var a1 = FindStoreItemById(prod.GetId());
            if (a1 == null)
            {   
                var a2 = new StoreItem(prod, quantity);
                Items.Add(a2);
                return a2;
            }
            else
            {
                a1.SetQuantity(a1.GetQuantity() + quantity);
                return a1;
            }
                                                       // false return
           // new { e.List<StoreItem>.Add }
           //// Product prod ,quantity
           // Items.Add(test);
           // //List<StoreItem>.Add(AddStoreItem(prod, quantity);
           // return Items;
            //if (_product1 == null) //if _product1 has no value change value to prod
            //{
            //    //prod = _product1;
            //    _product1 = prod;
            //}
            //else
            //{
            //    if (_product2 == null) //if _product2 has no value change value to prod
            //    {
            //        //prod = _product2;
            //        _product2 = prod;
            //    }
            //    else
            //    {
            //        if (_product3 == null) //if _product3 has no value change value to prod or do nothing
            //        {
            //            //prod = _product3;
            //            _product3 = prod;
            //        }
            //    }
            //}
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var r1 = FindStoreItemById(id);

            if (r1.GetQuantity() <= 0)
            {
                r1.SetQuantity(0);
                return r1;
            }
            if (r1.GetQuantity() > 0)
            {
                r1.SetQuantity(r1.GetQuantity() - quantity);
                return r1;
            }
            //if (r1 != null)
            //{
            //    r1.SetQuantity(r1.GetQuantity() - quantity);
            //}
            else
            {
                return null;
                //quantity = 0;
                //r1.SetQuantity(quantity);
            }
            //foreach(var item in Items)
            //{
            //    if(Items._Id == id)
            //    {
            //        Items._quantity - quantity;
            //        if(Items._quantity < 0)
            //        {
            //            Items.quantity = 0;
            //        }
          
            //    }
            //    return Items;//._quantity;
            //}
            //if(1 == productNum)
            //{
            //    _product1 = null;
            //}
            //else
            //{
            //    if(2 == productNum)
            //    {
            //        _product2 = null;
            //    }
            //    else
            //    {
            //        if( 3/*_product3.GetId() */== productNum)
            //        {
            //            _product3 = null;
            //        }

            //    }
            //}
        }

        public Product GetStoreItem(int productNum)
        {

            for (int t = 0; t < productNum; t++)
            {

                if (t == productNum)
                {
                    var m = Items[t].GetProduct();
                    return m;
                }
            }
            return null;


            //where (e.GetProduct().GetId() == id)
            //select e;

            //if( productNum == 1)//this area needs revising and changes to garentee it is functunal.
            // {

            //     return _product1;
            // }
            //else
            // {
            //     if (productNum == 2)
            //     {

            //         return _product2;
            //     }
            //     else
            //     {
            //         if (productNum == 3)
            //         {
            //           //  _product3 = null;
            //             return _product3;
            //         }
            //         else
            //         {
            //             return null;
            //         }
            //     }

            //}



            //return Product;
        }

        public StoreItem FindStoreItemById(int id)
        {

            /*IEnumerable<StoreItem>*//*var*/ var si =
                from e in Items
                where (e.GetProduct().GetId() == id)
                select e;

            return si.FirstOrDefault();


            //foreach(var item in Items)
            //{
            //    if(Items.Product._Id == id)
            //    {
            //        return Items.Product;
            //    }
            //}
            // if (_product1.GetId() == id)
            // {
            //     return _product1;
            // }
            //else if (_product2.GetId() == id)
            // {
            //     return _product2;
            // }
            //else if(_product3.GetId() == id)
            // {
            //     return _product3;
            // }
            // else
            // {
            //     return null;
            // }
        }
    }
}
//https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?view=net-6.0