using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class rats : attackers
    {
        public rats()
        {
            attackerHp = 55;
            maxBite = 5;
        }

        int ad = 0;

        protected int biteDam()
        {
            Random r = new Random();
            return r.Next(1, maxBite);
        }

        protected int AttDam()
        {
            if (Program.foundDagger == true)
            {
                maxAtt = 35;
                Random r = new Random();
                return r.Next(25, maxAtt);
            }
            else if (Program.foundBones == true)
            {
                maxAtt = 25;
                Random r = new Random();
                return r.Next(15, maxAtt);
            }
            else
            {
                maxAtt = 15;
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

        public void Run()
        {
            while (playerHp > 0 && attackerHp > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("player hp - " + playerHp);
                Console.WriteLine("rat hp - " + attackerHp);
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
                    playerHp += Heal();
                    Console.WriteLine("");
                }
                else if (choice == "QUIT")
                {
                    Console.WriteLine("");
                    Console.WriteLine("you cannot QUIT during combat.");
                    Console.WriteLine("");
                }

                if (attackerHp > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("player hp - " + playerHp);
                    Console.WriteLine("rat hp - " + attackerHp);
                    Console.WriteLine("");

                    Console.WriteLine(base.attackSound());
                    playerHp -= biteDam();
                    Console.WriteLine("the rat bit you for " + biteDam() + " health!");
                    Console.WriteLine("");
                }

              
            }

            if(playerHp > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("you have defeated the rat.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("you have died to the rat.");
                Console.WriteLine("");
            }
        }
    }
}
