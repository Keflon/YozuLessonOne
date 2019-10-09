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
        /// Replacing a method like this means we will get this Update method
        /// or the base class Update, depending on what type of reference we have to this object.
        /// That means the method call does something different depending on how you lok at the class instance.
        /// Don't ever do this ;)
        /// See GoodLiskovManager and BadLiskovManager for an explanation.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Player Update called");
        }

        /// <summary>
        /// WRONG!
        /// Replacing a method like this means we will get this Render method
        /// or the base class Render, depending on what type of reference we have to this object.
        /// That means the method call does something different depending on how you lok at the class instance.
        /// Don't ever do this ;)
        /// See GoodLiskovManager and BadLiskovManager for an explanation.
        public void Render()
        {
            Console.WriteLine("Player Render called");
        }
    }
}