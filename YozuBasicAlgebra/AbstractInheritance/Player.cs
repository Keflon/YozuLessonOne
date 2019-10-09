using System;

namespace YozuBasicAlgebra.AbstractInheritance
{
    public class Player : EntityBase
    {
        public Player()
        {

        }

        /// <summary>
        /// Unless this class is abstract, this method MUST be implemented, because it is marked abstract in the base class.
        /// There is no implementation in the base class.
        /// </summary>
        public override void Update()
        {
            Console.WriteLine("Player Update called");
        }

        /// <summary>
        /// Unless this class is abstract, this method MUST be implemented, because it is marked abstract in the base class.
        /// There is no implementation in the base class.
        /// </summary>
        public override void Render()
        {
            Console.WriteLine("Player Render called");
        }
    }
}