using System;

namespace YozuBasicAlgebra.BadInheritance
{
    public class SpaceInvader : EntityBase
    {
        public SpaceInvader()
        {

        }
        public void Update()
        {
            Console.WriteLine("SpaceInvader Update called");
        }

        public void Render()
        {
            Console.WriteLine("SpaceInvader Render called");
        }
    }
}