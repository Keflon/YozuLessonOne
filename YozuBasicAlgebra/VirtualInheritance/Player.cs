using System;

namespace YozuBasicAlgebra.VirtualInheritance
{
    public class Player : EntityBase
    {
        public Player()
        {

        }

        /// <summary>
        /// WRONG!
        /// </summary>
        public override void Update()
        {
            base.Update();
            Console.WriteLine("Player Update called");
        }

        /// <summary>
        /// WRONG!
        /// </summary>
        public override void Render()
        {
            base.Render();
            Console.WriteLine("Player Render called");
        }
    }
}