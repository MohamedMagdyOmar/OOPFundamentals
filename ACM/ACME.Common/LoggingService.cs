using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    // now both "Customer" class and "Product" Class has "Log" Method, now we need a service that consume these methods and write 
    // logged info into a file. so we create this class
   public class LoggingService
    {
        // in this function we will pass a list of all objects that need to be logged.
        // this list we contain objects from class "Customer", and from class "Product", so it takes list of "Object"
        public static void WriteToFile(List<ILoggable> changedItems)
        {
            foreach (var item in changedItems)
            {
                // when you write "item." the list of members does not include properties of "Customer" class, or "Product Class", and we do not have access 
                // to log message method that we just created
                // so to solve this problem we have to "cast" it firstly as in below comment

                // var customer = item as Customer

                // but you find that "Customer" is unknow to him, and in same time we can not refernce the "ACM.BL" project here
                // because we will have "circular reference"
                // even this solution is not good because in every added new object we have to create casting for it here which is not good.

                // so what if we create an "Interface" !!! and implement this interface in each class, and acess each one using the interface !!!
                // Console.WriteLine(item.);

                // look now we have the "log" method
                Console.WriteLine(item.Log());
            }

        }
    }
}
