using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    
    public class Address
    {
        public Address()
        {
            
        }
        public Address(int addrId)
        {
            AddressID = addrId;
        }
        public int AddressID { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set;}
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

     
        public bool Validate()
        {
            var isvalid = true;

            if (PostalCode == null) isvalid = false;
          
            return isvalid;
        }
    }

   
}
