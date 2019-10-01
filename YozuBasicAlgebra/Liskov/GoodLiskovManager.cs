using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.Liskov
{
    public class GoodLiskovManager
    {
        private ILogger _logger;

        public GoodLiskovManager(ILogger logger)
        {
            _logger = logger;
        }

        public void DoYourThing()
        {
            string message = "Method Does Same Things To This String";

            LiskovBase thing = new GoodLiskovLevelOne(_logger);
            GoodLiskovLevelZero thingAsLevelZero = (GoodLiskovLevelZero)thing;
            GoodLiskovLevelOne thingAsLevelOne = (GoodLiskovLevelOne)thing;

            thing.DoLiskovThing(message);
            thingAsLevelZero.DoLiskovThing(message);
            thingAsLevelOne.DoLiskovThing(message);
        }
    }
}
