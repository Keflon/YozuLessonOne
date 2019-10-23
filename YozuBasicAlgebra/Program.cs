using System;
using YozuBasicAlgebra.BadInheritance;
using YozuBasicAlgebra.Logging;
using YozuBasicAlgebra.ObserverFun;
using YozuBasicAlgebra.TrafficLights;

namespace YozuBasicAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
#if false
            var manager = new NoInheritance.NoPolymorphManager();
            manager.DoYourThing();
#elif false
            var manager = new BadPolymorphManager();
            manager.DoYourThing();
#elif false
            var manager = new VirtualInheritance.VirtualPolymorphManager();
            manager.DoYourThing();
#elif false
            var manager = new AbstractInheritance.AbstractPolymorphManager();
            manager.DoYourThing();
#elif false
            //ILogger logger = new DebugLogger();
            ILogger logger = new ConsoleLogger();
            var manager = new GoodLiskovManager(logger);
            manager.DoYourThing();
#elif false
            //ILogger logger = new DebugLogger();
            ILogger logger = new ConsoleLogger();
            var manager = new BadLiskovManager(logger);
            manager.DoYourThing();
#elif false
            var manager = new ObserverManager();
            manager.DoYourThing();
#elif true
            //ILogger logger = new DebugLogger();
            ILogger logger = new ConsoleLogger();
            ITrafficLight lights = new RawTrafficLight(logger);
            //ITrafficLight lights = new CoolTrafficLight(logger);
            var manager = new TrafficLightManager(logger, lights);
            manager.DoYourThing();

#endif
        }
    }
}
