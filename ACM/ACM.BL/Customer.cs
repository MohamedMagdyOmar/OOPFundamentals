using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    // using "public" access modifier means that it is accessible by any other "project" in the solution
    // and by any "external component"
    public class Customer
    {
        // a class should encapsulate its data, that is mean that the actual data should be hidden,
        // and access to this data should be provided with accessors.

        // hidding data will be done by defining "private backfield", which store the actual data.
        // this "private backfield" is accessible to other parts of the application using "property"
        private string _lastName;

        public string LastName
        {
            get
            {
                // you can add any code here to do any operation before getting "lastName".
                return _lastName;
            }
            set
            {
                // any code here
                _lastName = value;
            }
        }

        // if you are not going to do any operation before the "getter" and "setter" (as above) you can use feature in c#
        // called "auto implemented properties", in which you will NOT need to create the above "private member"(backfield)
        // (so you are still keeping encapsulation) and C# will create it for you as follow:

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        // here we make "private set" because it will be set by DB, and we do not need other parts of the app to access it
        public int CustomerId { get; private set; }

        // here there is no "backfield" because there is no storage for any data, and we are using "backfield"
        // already defined in "LastName" and "FirstName".
        // Note also there is no "Setter" because it is not allowed for any part of the code to set it, because
        // it is already deduced from prev info.
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(! string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ",";
                    }

                    fullName += FirstName;
                }
                return fullName;
            }
        }

        // Note: if we define "internal" access modifier, this means that it is accessible only inside this project,
        // and NOT by any project in this solution, or any external components.

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if(string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if(string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
    }
}
