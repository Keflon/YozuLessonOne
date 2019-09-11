using System;

namespace YozuBasicAlgebra.AbstractInheritance
{
    public class Player : EntityBase
    {
        public Player()
        {

        }

        /// <summary>
        /// </summary>
        public override void Update()
        {
            Console.WriteLine("Player Update called");
        }

        /// <summary>
        /// </summary>
        public override void Render()
        {
            Console.WriteLine("Player Render called");
        }
    }
}