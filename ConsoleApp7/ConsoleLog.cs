using System;

namespace Logging
{
    public class ConsoleLog : ILog
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
