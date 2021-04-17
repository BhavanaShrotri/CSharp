using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int custId)
        {
            Customer customer = new Customer(custId);

            if(custId == 1)
            {
                customer.EmailAddress = "bhavana@gmail.com";
                customer.FirstName = "Bhavana";
                customer.LastName = "Shrotri";
                customer.AddressList = addressRepository.RetriveByCustomerId(custId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
            
    }
}
