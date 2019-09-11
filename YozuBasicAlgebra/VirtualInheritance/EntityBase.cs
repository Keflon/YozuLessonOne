using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.VirtualInheritance
{
    public class EntityBase
    {
        public virtual void Update()
        {
            Console.WriteLine("EntityBase::Update called");
        }

        public virtual void Render()
        {
            Console.WriteLine("EntityBase::Render called");
        }
    }
}
