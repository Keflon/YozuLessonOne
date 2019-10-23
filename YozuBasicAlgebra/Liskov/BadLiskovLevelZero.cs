using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Logging;

namespace YozuBasicAlgebra.Liskov
{
    public class BadLiskovLevelZero : LiskovBase
    {
        public BadLiskovLevelZero(ILogger logger) : base(logger)
        {
        }

        public override void DoLiskovThing(string message)
        {
            Log(message.ToLower());
        }
    }
}
