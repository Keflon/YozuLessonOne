using System;

namespace YozuBasicAlgebra.BadInheritance
{
    public class Player : EntityBase
    {
        public Player()
        {

        }

        /// <summary>
        /// WRONG!
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Player Update called");
        }

        /// <summary>
        /// WRONG!
        /// </summary>
        public void Render()
        {
            Console.WriteLine("Player Render called");
        }
    }
}