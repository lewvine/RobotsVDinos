using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Robot
    {
        private string name;
        private int health;
        private int powerLevel;
        private Weapon weapon;
        private int attackPower;

        public Robot(string name, int health, Weapon weapon, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.weapon = weapon;
            this.attackPower = weapon.getAttackPower();
        }

        public string getName()
        {
            return this.name;
        }

        public int getHealth()
        {
            return this.health;
        }

        public void setHealth(int value)
        {
            this.health -= value;
        }

        public string getWeaponType()
        {
            return this.weapon.getType();
        }

        public int getAttackPower()
        {
            return this.attackPower;
        }

        public int getPowerLevel()
        {
            return this.powerLevel;
        }
    }
}
