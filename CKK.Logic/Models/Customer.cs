using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Customer
    {
        private int CustomerId;
        private string Name;
        private string Address;

        public Customer(string custname, string custaddress, int custId)
        {
            CustomerId = custId;
            Name = custname;
            Address = custaddress;
        }

        public int GetId()
        {
            return CustomerId;
        }

        public void SetId(int custId)
        {
            CustomerId = custId;
        }

        public string GetName()
        {
                return Name;
        }

        public void SetName(string custname)
        {
            Name = custname;
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string custaddress)
        {
            Address = custaddress;
        }

    }
}
