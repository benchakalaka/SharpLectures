using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Classes;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example withou using DI, without using interfaces
            OrderInfo order = new OrderInfo()
            {
                CustomerName = "Andrii Potapenko",
                ProductName = "--Mac Book Pro--"
            };

            // UNTESTABLE !!!
            Commerce commerce = new Commerce();
            commerce.ProcessOrder(order);

            Console.ReadKey();
        }
    }
}
