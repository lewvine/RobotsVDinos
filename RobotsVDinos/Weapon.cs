using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Weapon
    {
        private string type;
        private int attackPower;

        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }

        public string getType()
        {
            return this.type;
        }

        public int getAttackPower()
        {
            return this.attackPower;
        }
    }
}
