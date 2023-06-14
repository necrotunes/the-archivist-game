using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class findings
    {

        public findings()
        { 

        }
        public int skeleton(int bone)
        {
            Console.WriteLine("you find an old skeleton propped against the wall. you hope it is fake.");
            Console.WriteLine("you reach out to grab its hand, but its arm falls off.");
            Console.WriteLine("you have " + bone + " arm!");
            Console.WriteLine("");
            Console.WriteLine("you are curious, so you attempt to break the bones apart.");
            Console.WriteLine("they are brittle, and break apart easily.");
            return bone * 2;
        }
        public void flashlight()
        {
            Console.WriteLine("inside one of the compartments under the desk, you find a flashlight.");
            Console.WriteLine("this should prove to be useful.");
        }
        public void coffee()
        {
            Console.WriteLine("you decide to try and make a cup of coffee.");
            Console.WriteLine("despite its old age, it works remarkably well.");
        }
        public void skull()
        {
            Console.WriteLine("you find a skull buried in the mess. it looks to be that of a human adult. it is still warm.");
            Console.WriteLine("you decide to take it with you.");
        }
        public void page1()
        {
            Console.WriteLine("you find a handwritten page amongst the scattered torn books. it reads:");
            Console.WriteLine("     day 89");
            Console.WriteLine("         i have found that writing these journals keeps me sane throughout the choas of my work. it is the only way i can keep track of the days anymore. i have not allowed myself to think of home. if i don't, then it seems quite nice here, actually. other than the screams.");
            Console.WriteLine("");
            Console.WriteLine("you decide to take the page with you.");
        }
        public void page2()
        {
            Console.WriteLine("you find another handwritten page. it reads:");
            Console.WriteLine("     day 154");
            Console.WriteLine("         how am i meant to archive this? they're all dead. every. single. one. i can't help but feel like it's my fault. i never tried to help them. i heard them cry and i just covered my ears. what could i have done, anyway? the poor, lonely archivist. i guess the only thing i can do is wait...");
            Console.WriteLine("");
            Console.WriteLine("you decide to take the page with you.");
        }
        public void folder()
        {
            Console.WriteLine("underneath a fallen shelf, you find a pale manilla folder. inside was a multitude of strange drawings, some depicting a very tall man being stabbed repeatedly by numerous other people, while others seemed to show executions by electric chair.");
            Console.WriteLine("you decide to take the folder with you.");
        }
        public void dagger()
        {
            Console.WriteLine("sticking out of a pile of other artifacts, you find a dagger. its blade is sharp, seemingly kept in perfect condition.");
            Console.WriteLine("you decide to take it with you.");
        }
    }
}
