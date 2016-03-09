using System;
using Abstraction.Classes.Interfaces;

namespace Abstraction.Classes
{
    class NotifierService : INotifierService
    {
        public void SendReceipt(OrderInfo info)
        {
            Console.WriteLine("Sending Receipt for class {0}", info);
        }
    }
}
