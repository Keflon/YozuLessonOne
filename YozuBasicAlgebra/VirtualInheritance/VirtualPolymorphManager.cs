using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.VirtualInheritance
{
    /// <summary>
    /// THIS IS NOT THE RIGHT WAY TO DO THINGS!
    /// </summary>
    public class VirtualPolymorphManager
    {
        public void DoYourThing()
        {
            var entityList = new List<EntityBase>();
            entityList.Add(new SpaceInvader());
            entityList.Add(new SpaceInvader());
            entityList.Add(new SpaceInvader());

            entityList.Add(new Player());
            entityList.Add(new Player());

            do
            {
                // Update ...
                foreach (var entity in entityList)
                    entity.Update();

                // Render ...
                foreach (var entity in entityList)
                    entity.Render();

            }
            while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}
