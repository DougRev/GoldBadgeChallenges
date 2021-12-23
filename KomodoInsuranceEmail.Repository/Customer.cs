using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceEmail.Repository
{
    public class Customer
    {
        public Customer() { }

        public Customer
            (string firstName,
            string lastName,
            string type,
            string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }

    }
}
