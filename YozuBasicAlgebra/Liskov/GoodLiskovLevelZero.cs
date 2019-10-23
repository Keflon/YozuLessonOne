using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Logging;

namespace YozuBasicAlgebra.Liskov
{
    public class GoodLiskovLevelZero : LiskovBase
    {
        public GoodLiskovLevelZero(ILogger logger) : base(logger)
        {
        }

        public override void DoLiskovThing(string message)
        {
            Log(message.ToLower());
        }
    }
}
