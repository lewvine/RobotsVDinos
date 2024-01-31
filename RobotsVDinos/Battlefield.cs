using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Battlefield
    {
        Herd herd;
        Fleet fleet;

        public Battlefield()
        {
            this.herd = new Herd();
            this.fleet = new Fleet();
        }

        public int Fight(int round, Dino dino, Robot robot)
        {
            while(dino.getHealth() > 0 && robot.getHealth() > 0)
            {
                Console.Clear();
                Console.WriteLine($"Round {round}: {dino.getType()} versus {robot.getName()}");
                Random rand = new Random();

                // Dino attack
                int dinoAttack = dino.getAttackPower() * rand.Next(0, 10);
                Console.WriteLine($"{dino.getType()} attacks with an attack value of {dinoAttack}.");
                dino.setHealth(dinoAttack);
                Console.WriteLine($"{robot.getName()} loses {dinoAttack} health.  {robot.getName()} health at {dino.getHealth()}");

                //Robot attack
                int robotAttack = robot.getAttackPower() * rand.Next(0, 10);
                Console.WriteLine($"{robot.getName()} attacks with an attack value of {robotAttack}.");
                dino.setHealth(robotAttack);
                Console.WriteLine($"{dino.getType()} loses {robotAttack} health.  {dino.getType()} health at {dino.getHealth()}");
                Console.ReadLine();
            }

            if(dino.getHealth() < 0)
            {
                //If dino loses
                return -1;
            } 
            else
            {
                //If robot loses
                return 1;
            }
           
        }

        public void Battle()
        {
            int round = 1;
            while(fleet.robots.Count > 0 && herd.dinos.Count > 0)
            {
                int loser = Fight(round, herd.dinos[0], fleet.robots[0]);
                round++;
                if(loser == -1)
                {
                    //Robot wins dino loses
                    Console.WriteLine($"Congratulations, {fleet.robots[0]} wins!");
                    herd.dinos.Remove(herd.dinos[0]);
                }
                else
                {
                    //Robot loses dino wins
                    Console.WriteLine($"Congratulations, {herd.dinos[0]} wins!");
                    fleet.robots.Remove(fleet.robots[0]);
                }
            }
            if(fleet.robots.Count == 0)
            {
                Console.WriteLine("THE DINOS HAVE VANQUISHED THE ROBOTS!!");
                Console.ReadLine();
            }
            if(herd.dinos.Count == 0)
            {
                Console.WriteLine("THE ROBOTS HAVE VANQUISHED THE DINOS!!");
                Console.ReadLine();
            }
        }




    }
}
