using System;
using YozuBasicAlgebra.BadInheritance;
using YozuBasicAlgebra.Liskov;
using YozuBasicAlgebra.ObserverFun;

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
#elif true
            var manager = new ObserverManager();
            manager.DoYourThing();

#endif
        }
    }
}
