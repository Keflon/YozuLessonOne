using System;
using System.Collections.Generic;
using System.Text;
using YozuBasicAlgebra.Logging;

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

            Lights.ProcessMessage(LightMessage.Reset);

            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;

                if (key == ConsoleKey.R)
                {
                    _logger.Log("TrafficLightManager is resetting traffic lights ...");
                    Lights.ProcessMessage(LightMessage.Reset);
                }
                else
                {
                    _logger.Log("TrafficLightManager is nexting traffic lights ...");
                    Lights.ProcessMessage(LightMessage.Next);
                }
            }
            while (key != ConsoleKey.Q);
        }
    }
}
