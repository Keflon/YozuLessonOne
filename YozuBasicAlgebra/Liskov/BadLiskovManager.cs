using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Logging;

namespace YozuBasicAlgebra.Liskov
{
    public class BadLiskovManager
    {
        private ILogger _logger;

        public BadLiskovManager(ILogger logger)
        {
            _logger = logger;
        }

        public void DoYourThing()
        {
            string message = "Method Does Different Things To This String";

            LiskovBase thing = new BadLiskovLevelOne(_logger);
            BadLiskovLevelZero thingAsLevelZero = (BadLiskovLevelZero)thing;
            BadLiskovLevelOne thingAsLevelOne = (BadLiskovLevelOne)thing;

            thing.DoLiskovThing(message);
            thingAsLevelZero.DoLiskovThing(message);
            thingAsLevelOne.DoLiskovThing(message);
        }
    }
}
