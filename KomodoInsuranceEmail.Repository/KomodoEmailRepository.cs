using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceEmail.Repository
{
    public class KomodoEmailRepository
    {
        private readonly List<Customer> _customerDirectory = new List<Customer>();

        public bool AddACustomer(Customer customer)
        {
            int startingcount = _customerDirectory.Count;
            _customerDirectory.Add(customer);

            bool wasAdded = (_customerDirectory.Count > startingcount);
            return wasAdded;
        }

        public List<Customer> ViewAllCustomers()
        {
            return _customerDirectory;
        }

        public Customer GetCustomerByLastName(string lastName)
        {
            foreach (Customer customer in _customerDirectory)
                if (customer.LastName == lastName)
                {
                    return customer;
                }
            return null;
        }
        //Update.
        public bool UpdateExistingCustomer(string lastName, Customer customer)
        {
            //find the old content...
            Customer oldInfo = GetCustomerByLastName(lastName);

            if (oldInfo != null)
            {
                oldInfo.FirstName = customer.FirstName;
                oldInfo.LastName = customer.LastName;
                oldInfo.Type = customer.Type;
                oldInfo.Email = customer.Email;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customer existingcustomer)
        {
            bool deleteResult = _customerDirectory.Remove(existingcustomer);
            return deleteResult;
        }
    }
}

