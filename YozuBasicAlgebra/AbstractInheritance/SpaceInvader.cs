using System;

namespace YozuBasicAlgebra.AbstractInheritance
{
    public class SpaceInvader : EntityBase
    {
        public SpaceInvader()
        {

        }
        public override void Update()
        {
            Console.WriteLine("SpaceInvader Update called");
        }

        public override void Render()
        {
            Console.WriteLine("SpaceInvader Render called");
        }
    }
}