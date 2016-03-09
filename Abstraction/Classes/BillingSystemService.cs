using System;
using Abstraction.Classes.Interfaces;

namespace Abstraction.Classes
{
    class BillingSystemService : IBillingSystemService
    {
        public void ProcessPayment(string customer, string productName, double price)
        {
            Console.WriteLine("Process payment for customer {0} on product {1} with price {2}", customer, productName, price);
        }
    }
}
