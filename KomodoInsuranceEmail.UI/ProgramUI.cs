using KomodoInsuranceEmail.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceEmail.UI
{
    public class ProgramUI
    {
        private readonly List<Customer> _customerDirectory = new List<Customer>();
        public void Run()
        {
            OpeningMenu();

        }

        public void OpeningMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:\n" +
                    "1. Create Customer\n" +
                    "2. Update Customer Status\n" +
                    "3. View All Customers\n" +
                    "4. Delete Customer\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateNewCustomer();
                        break;
                    case "2":
                        UpdateCustomerStatus();
                        break;
                    case "3":
                        ViewAllCustomers();
                        break;
                    case "4":
                        DeleteCustomer();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Number Between 1-4.\n" +
                            "Press any key to continue......");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void UpdateCustomerStatus(string OriginalInfo Customer customer)
        {
            Customer oldInfo = GetCustomerByName(OriginalInfo);

            if (oldInfo != null)
            {
                oldInfo.FirstName = customer.FirstName;
                oldInfo.LastName = customer.LastName;
                oldInfo.Type = customer.Type;
                oldInfo.Email = customer.Email;
            }
            Console.WriteLine(customer);
        }
        public Customer GetCustomerByName(string firstName)
        {
            foreach (Customer customer in _customerDirectory)
                if (customer.FirstName.ToLower() == firstName.ToLower())
                {
                    return customer;
                }     
            return null;
        }

        public List<Customer> ViewAllCustomers()
        {
            return _customerDirectory;
        }
        public void CreateNewCustomer()
        {
            Console.Clear();
            Customer customer;

            Console.WriteLine("What is the customer's First Name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is the customer's Last Name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is the customer type(Past, Current, Future)?");
            string type = Console.ReadLine();

            Console.WriteLine("What is the customer's email?");
            string email = Console.ReadLine();

            Console.ReadKey();
        }

        public bool DeleteCustomer(Customer existingcustomer)
            {
                bool deleteResult = _customerDirectory.Remove(existingcustomer);
                return deleteResult;
            }
    public void EmailCustomer()
    {
            if(Customer.Type ==  "Current")
            {
                Console.WriteLine("Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
            }
            else if (Customer.Type == "Past")
            {
                Console.WriteLine("It's been a long time since we've heard from you. we want you  back.");
            }
            else
            {
                Console.WriteLine("We currently have the lowest rates on Helicopter Insurance!");
            }
    }
    }
}