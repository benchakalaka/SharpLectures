using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Classes
{
    class BillingSystem
    {
        public void ProcessPayment(string customer, string productName, double price)
        {
            Console.WriteLine("Process payment for customer {0} on product {1} with price {2}", customer, productName, price);
        }
    }
}
