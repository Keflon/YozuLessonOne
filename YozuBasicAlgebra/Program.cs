using System;
using YozuBasicAlgebra.BadInheritance;

namespace YozuBasicAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

#if false
            var manager = new NoInheritance.NoPolymorphManager();
            manager.DoYourThing();
#elif false
            var manager = new BadPolymorphManager();
            manager.DoYourThing();
#elif false
            var manager = new VirtualInheritance.VirtualPolymorphManager();
            manager.DoYourThing();
#elif true
            var manager = new AbstractInheritance.AbstractPolymorphManager();
            manager.DoYourThing();
#endif
        }
    }
}
