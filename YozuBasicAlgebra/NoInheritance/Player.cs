using System;

namespace YozuBasicAlgebra.NoInheritance
{
    internal class Player
    {
        public Player()
        {
        }

        public void Update()
        {
            Console.WriteLine("Player Update called");
        }

        public void Render()
        {
            Console.WriteLine("Player Render called");
        }
    }
}