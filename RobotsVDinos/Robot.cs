using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Robot
    {
        string name;
        int health;
        int powerLevel;
        Weapon weapon;
        int attackPower;

        public Robot(string name, int health, Weapon weapon, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.weapon = weapon;
            this.attackPower = attackPower;
        }
    }
}
