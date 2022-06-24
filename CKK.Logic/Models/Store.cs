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

            var a1 = FindStoreItemById(prod.GetId());

                if (a1 == null && quantity > 0)
                {
                    var a2 = new StoreItem(prod, quantity);
                    Items.Add(a2);
                    return a2;
                }
                else if (a1 != null && quantity != 0)
                {
                    a1.SetQuantity(a1.GetQuantity() + quantity);
                    return a1;
                }
                else
                {
                    return null;
                }
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var r1 = FindStoreItemById(id);

            if (r1.GetQuantity() <= 0)
            {
                r1.SetQuantity(0);
                return r1;
            }
            else if (r1.GetQuantity() > 0 && r1.GetQuantity() >= quantity)
            {
                r1.SetQuantity(r1.GetQuantity() - quantity);
                return r1;
            }
            else if (r1.GetQuantity() > 0 && r1.GetQuantity() <= quantity)
            {
                r1.SetQuantity(0);
                return r1;
            }

            else
            {
                return null;
            }

        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

        public StoreItem FindStoreItemById(int id)
        {

                var si =
                from e in Items
                where (e.GetProduct().GetId() == id)
                select e;

            return si.FirstOrDefault();



        }
    }
}
//https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?view=net-6.0