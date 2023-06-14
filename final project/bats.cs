using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class bats : attackers
    {
        public bats()
        {
            attackerHp = 65;
            maxClaw = 10;
        }

        int ad = 0;

        protected int clawDam()
        {
            Random r = new Random();
            return r.Next(1, maxClaw);
        }

        protected int AttDam()
        {
            if (Program.foundDagger == true)
            {
                Random r = new Random();
                return r.Next(25, maxAtt);
            }
            else if (Program.foundBones == true)
            {
                Random r = new Random();
                return r.Next(15, maxAtt);
            }
            else
            {
                Random r = new Random();
                return r.Next(10, maxAtt);
            }
        }

        protected int Heal()
        {
            Random r = new Random();
            return r.Next(5, maxHeal);
        }

        protected override string attackSound()
        {
            return "hya!";
        }

        protected virtual string attackSound1()
        {
            return "screech!";
        }

        public void Run()
        {
            while (playerHp > 0 && attackerHp > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("player hp - " + playerHp);
                Console.WriteLine("bat hp - " + attackerHp);
                Console.WriteLine("");
                Console.WriteLine("type 'A' to attack or 'H' to heal.");

                string choice = Console.ReadLine().ToUpper();

                if (choice == "A")
                {
                    Console.WriteLine("");
                    Console.WriteLine(attackSound());
                    ad = AttDam();
                    attackerHp -= ad;
                    Console.WriteLine("you attack for " + ad + " health!");
                    Console.WriteLine("");
                }
                else if (choice == "H")
                {
                    Console.WriteLine("");
                    Console.WriteLine("you quickly bandage yourself and heal for " + Heal() + " health.");
                    Console.WriteLine("");
                }

                if (attackerHp > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("player hp - " + playerHp);
                    Console.WriteLine("bat hp - " + attackerHp);
                    Console.WriteLine("");

                    Console.WriteLine(attackSound1());
                    playerHp -= clawDam();
                    Console.WriteLine("the bat clawed you for " + clawDam() + " health!");
                    Console.WriteLine("");
                }
            }

            if (playerHp > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("you have defeated the bat.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("you have died to the bat.");
                Console.WriteLine("");
            }
        }

    }
}
