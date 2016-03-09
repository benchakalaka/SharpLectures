using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Classes
{
    class Logger
    {
        // Just for demo purpose, write to standart log
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
