using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.Liskov
{
    public class BadLiskovLevelOne : BadLiskovLevelZero
    {
        public BadLiskovLevelOne(ILogger logger) : base(logger)
        {
        }

        public new void DoLiskovThing(string message)
        {
            Log(message.ToUpper());
        }
    }
}
