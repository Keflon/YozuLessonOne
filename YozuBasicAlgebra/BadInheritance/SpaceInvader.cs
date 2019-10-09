using System;

namespace YozuBasicAlgebra.BadInheritance
{
    public class SpaceInvader : EntityBase
    {
        public SpaceInvader()
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
            Console.WriteLine("SpaceInvader Update called");
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
            Console.WriteLine("SpaceInvader Render called");
        }
    }
}