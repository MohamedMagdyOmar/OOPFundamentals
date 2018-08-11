using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    // using "public" access modifier means that it is accessible by any other "project" in the solution
    // and by any "external component"

    // Now we need to define the "composition" relationship between the "customer" and the "address".
    // we have each "customer" "has a" "home address", and "has a" "work address".
    // so we are going to create  the below "list of" address
    public class Customer : EntityBase
    {
        // we add "constructor chaining" so by default this "constructor" call
        // below constructor and pass "0" to it.
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            // this referes to this instance of the class.
            this.CustomerId = customerId;

            // we added this line of code to prevent "null exception" of accessing the list
            // so this will make the "addresslist" as an empty list.
            // we need also to add this line to the above "constructor" as well, but we will have repeated code.
            // so we will make the above constructor call this "constructor" by default using "Constructor Chaining"
            AddressList = new List<Address>();
        }

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

        // but we have a problem when we create a list as one of the "properties" of the class
        // that is the "list" does not have good "default" value (null is the default value)
        // so if any one tried to access this property, "null exception" will be fired
        // so we are going to modify the "constructor" to create an instance of this list(look above in the constructor)
        public List<Address> AddressList { get; set; }

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

        public override bool Validate()
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

        

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = this.CustomerId + ": " + this.FullName + " " + "Email: " + this.EmailAddress + " " + "Status: " + this.EntityState.ToString();
            return logString;
        }
    }
}
