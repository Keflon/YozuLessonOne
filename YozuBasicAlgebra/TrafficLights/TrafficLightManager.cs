using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Liskov;

namespace YozuBasicAlgebra.TrafficLights
{
    public class TrafficLightManager
    {
        public TrafficLightManager(ILogger logger, ITrafficLight lights)
        {
            _logger = logger;
            Lights = lights;
        }

        private ILogger _logger;

        public ITrafficLight Lights { get; }

        internal void DoYourThing()
        {
            _logger.Log("TrafficLightManager is resetting traffic lights ...");

            Lights.Reset();
            do
            {
                _logger.Log("TrafficLightManager is nexting traffic lights ...");
                Lights.Next();
            }
            while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}
