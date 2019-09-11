using System;

namespace YozuBasicAlgebra.VirtualInheritance
{
    public class SpaceInvader : EntityBase
    {
        public SpaceInvader()
        {

        }
        public override void Update()
        {
            base.Update();
            Console.WriteLine("SpaceInvader Update called");
        }

        public override void Render()
        {
            base.Render();
            Console.WriteLine("SpaceInvader Render called");
        }
    }
}