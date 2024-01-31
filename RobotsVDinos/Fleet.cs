using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            //Create weapons;
            Weapon mindray = new Weapon("mindray", 10);
            Weapon laser = new Weapon("laser", 50);
            Weapon gun = new Weapon("gun", 25);

            //Create robots
            Robot c3p0 = new Robot("c3p0", 100, mindray, 10);
            Robot r2d2 = new Robot("r2d2", 100, laser, 10);
            Robot robocop = new Robot("robocop", 100, gun, 10);

            //Create robots list
            this.robots = new List<Robot>();

            //Add robots
            robots.Add(c3p0);
            robots.Add(r2d2);
            robots.Add(robocop);

        }
    }
}
