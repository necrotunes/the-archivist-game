using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class attackers
    {
        protected int attackerHp = 75;
        protected int maxClaw = 15;
        protected int maxBite = 10;

        protected int playerHp = 100;
        protected int maxAtt = 35;
        protected int maxHeal = 15;

        public attackers()
        {
            if (Program.foundDagger == true)
            {
                maxAtt = 35;
            }
            else if (Program.foundBones == true)
            {
                maxAtt = 25;
            }
            else
            {
                maxAtt = 15;
            }
        }

        protected virtual string attackSound()
        {
            return "squeak!";
        }

    }
}
