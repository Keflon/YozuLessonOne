using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Logging;

namespace YozuBasicAlgebra.Liskov
{
    public class GoodLiskovLevelOne : GoodLiskovLevelZero
    {
        public GoodLiskovLevelOne(ILogger logger) : base(logger)
        {
        }

        public override void DoLiskovThing(string message)
        {
            Log(message.ToUpper());
        }
    }
}
