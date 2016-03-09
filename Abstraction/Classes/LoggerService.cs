using System;
using Abstraction.Classes.Interfaces;

namespace Abstraction.Classes
{
    class LoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
