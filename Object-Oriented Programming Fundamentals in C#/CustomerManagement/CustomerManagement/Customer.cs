using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int custId)
        {
            CustomerID = custId;

            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set;}
        public static int InstantCount { get; set; }
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }

                return fullname;
            }
        }

        public bool Validate()
        {
            var isvalid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isvalid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isvalid = false;

            return isvalid;
        }
    }

   
}
