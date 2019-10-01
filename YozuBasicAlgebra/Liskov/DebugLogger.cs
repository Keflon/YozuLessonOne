using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace YozuBasicAlgebra.Liskov
{
    public class DebugLogger : ILogger
    {
        /// <summary>
        /// Logs a message to the debugger.
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <returns>true if logging succeeded</returns>
        public bool Log(string message)
        {
            Debug.WriteLine(message);
            return true;
        }
    }
}
