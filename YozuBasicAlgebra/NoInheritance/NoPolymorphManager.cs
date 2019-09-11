using System;
using System.Collections.Generic;
using System.Text;

namespace YozuBasicAlgebra.NoInheritance
{
    /// <summary>
    /// THIS IS NOT THE RIGHT WAY TO DO THINGS!
    /// </summary>
    public class NoPolymorphManager
    {
        public void DoYourThing()
        {
            var spaceInvader0 = new SpaceInvader();
            var spaceInvader1 = new SpaceInvader();
            var spaceInvader2 = new SpaceInvader();

            var player0 = new Player();
            var player1 = new Player();

            do
            {
                // Update ...
                spaceInvader0.Update();
                spaceInvader1.Update();
                spaceInvader2.Update();

                player0.Update();
                player1.Update();

                // Render ...
                spaceInvader0.Render();
                spaceInvader1.Render();
                spaceInvader2.Render();

                player0.Render();
                player1.Render();
            }
            while (Console.ReadKey().Key != ConsoleKey.Q);
        }

        public void DoYourThing_SlightlyBetter()
        {
            var spaceInvaderList = new List<SpaceInvader>();
            spaceInvaderList.Add(new SpaceInvader());
            spaceInvaderList.Add(new SpaceInvader());
            spaceInvaderList.Add(new SpaceInvader());

            var playerList = new List<Player>();
            playerList.Add(new Player());
            playerList.Add(new Player());

            do
            {
                // Update ...
                foreach (var spaceInvader in spaceInvaderList)
                    spaceInvader.Update();

                foreach (var player in playerList)
                    player.Update();

                // Render ...
                foreach (var spaceInvader in spaceInvaderList)
                    spaceInvader.Render();

                foreach (var player in playerList)
                    player.Render();
            }
            while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}
