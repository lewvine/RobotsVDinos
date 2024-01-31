using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Dino
    {
        private string type;
        private int health;
        private int energy;
        private int attackPower;

        public Dino(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        public string getType()
        {
            return this.type;
        }

        public int getHealth()
        {
            return this.health;
        }

        public int getEnergy()
        {
            return this.energy;
        }

        public void setHealth(int value)
        {
            this.health -= value;
        }

        public int getAttackPower()
        {
            return this.attackPower;
        }
    }
}
