using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class CustomerRepository
    {
        public Customer Retrieve(int custId)
        {
            Customer customer = new Customer(custId);

            if(custId == 1)
            {
                customer.EmailAddress = "bhavana@gmail.com";
                customer.FirstName = "Bhavana";
                customer.LastName = "Shrotri";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
            
    }
}
