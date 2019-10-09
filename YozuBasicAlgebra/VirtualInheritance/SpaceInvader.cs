using System;

namespace YozuBasicAlgebra.VirtualInheritance
{
    public class SpaceInvader : EntityBase
    {
        public SpaceInvader()
        {

        }
        // Documentation for the base class should tell you whether you need to call the base class implementation.
        // In csharp app development it is usually a requirement.
        public override void Update()
        {
            base.Update();
            Console.WriteLine("SpaceInvader Update called");
        }

        // Documentation for the base class should tell you whether you need to call the base class implementation.
        // In csharp app development it is usually a requirement.
        public override void Render()
        {
            base.Render();
            Console.WriteLine("SpaceInvader Render called");
        }
    }
}