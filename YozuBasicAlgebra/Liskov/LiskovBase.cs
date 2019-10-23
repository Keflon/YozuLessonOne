using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Logging;

namespace YozuBasicAlgebra.Liskov
{
    public abstract class LiskovBase
    {
        private readonly ILogger _logger;

        public LiskovBase(ILogger logger)
        {
            _logger = logger;
        }
        public abstract void DoLiskovThing(string message);

        public bool Log(string message)
        {
            return _logger.Log(message);
        }
    }
}
