using System;

namespace YozuBasicAlgebra.VirtualInheritance
{
    public class Player : EntityBase
    {
        public Player()
        {

        }

        public override void Update()
        {
            // Documentation for the base class should tell you whether you need to call the base class implementation.
            // In csharp app development it is usually a requirement.
            base.Update();
            Console.WriteLine("Player Update called");
        }

        public override void Render()
        {
            // Documentation for the base class should tell you whether you need to call the base class implementation.
            // In csharp app development it is usually a requirement.
            base.Render();
            Console.WriteLine("Player Render called");
        }
    }
}