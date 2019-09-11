using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.BadInheritance
{
    public class EntityBase
    {
        public void Update()
        {
            Console.WriteLine("EntityBase::Update called");
        }

        public void Render()
        {
            Console.WriteLine("EntityBase::Render called");
        }
    }
}
