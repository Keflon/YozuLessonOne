using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.Logging
{
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Logs a message to the debugger.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <returns>true if logging succeeded</returns>
        public bool Log(string message)
        {
            Console.WriteLine(message);
            return true;
        }
    }
}
