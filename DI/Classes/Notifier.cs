using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Classes
{
    class Notifier
    {
        public void SendReceipt(OrderInfo info)
        {
            Console.WriteLine("Sending Receipt for class {0}", info);
        }
    }
}
