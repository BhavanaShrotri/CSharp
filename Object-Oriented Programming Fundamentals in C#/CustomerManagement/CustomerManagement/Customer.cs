using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set;}
        private string _lastName;

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ",";
                    }
                    fullname += FirstName;
                }

                return fullname;
            }
        }

        public static int InstantCount { get; set; }

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
    }
}
