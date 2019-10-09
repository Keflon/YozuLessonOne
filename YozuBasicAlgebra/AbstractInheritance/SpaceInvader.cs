using System;

namespace YozuBasicAlgebra.AbstractInheritance
{
    public class SpaceInvader : EntityBase
    {
        public SpaceInvader()
        {

        }
        /// <summary>
        /// Unless this class is abstract, this method MUST be implemented, because it is marked abstract in the base class.
        /// There is no implementation in the base class.
        /// </summary>
        public override void Update()
        {
            Console.WriteLine("SpaceInvader Update called");
        }
        /// <summary>
        /// Unless this class is abstract, this method MUST be implemented, because it is marked abstract in the base class.
        /// There is no implementation in the base class.
        /// </summary>
        public override void Render()
        {
            Console.WriteLine("SpaceInvader Render called");
        }
    }
}