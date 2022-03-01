using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
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

        public int CId
        {
            get
            {
                return CId;
            }
            set
            {
                CId = CustomerId;
            }
        }

        public string CName
        {
            get
            {
                return CName;
            }
            set
            {
                CName = Name;
            }
        }

        public string CAddress
        {
            get
            {
                return CAddress;
            }
            set
            {
                CAddress = Address;
            }
        }
        /*
        public int GetId()
        {
           return Id;
        }

        public int SetID(int Id)
        {
            Id = customerId;
        }

        public GetName()
        {
            return Name;
        }

        public SetName(string Name)
        {
            Name = name;
        }

        public GetAddress()
        {
            return Address;
        }

        public SetAddress(string address)
        {
            Address = custaddress;
        }
        */
    }
}
