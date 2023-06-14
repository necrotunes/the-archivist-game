using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Program
    {
        public static List<string> inventory = new List<string>();

        public static rooms[] roomsArray =
        {

            new rooms(-1, 2, -1, 1, -1, -1, -1, -1, "the lobby.", "it is dark. it takes your eyes a moment to adjust. when they do, you see an open area with a few benches against the walls. there are doors to your RIGHT and DOWN, waiting to be opened."),
            new rooms(-1, -1, 0, 3, -1, -1, -1, -1, "the front desk.", "there is a large desk to the side of you. atop of it sits three monitors, all with printer paper stuck to them that reads 'out of order.' there is a doorway to your RIGHT, leading to the library."),
            new rooms(0, 7, -1, 6, -1, 8, -1, -1, "the institute hallway.", "there are three doors in this hallway, one to the RIGHT, one DOWN, and one DOWN RIGHT. they are labelled, but in the darkness, you cannot see the names of the first two. the third door, however, is illumnated with a small light. it reads 'ARCHIVE ENTRANCE.'"),
            new rooms(-1, 5, 1, 4, -1, 5, -1, -1, "the nonfiction section.", "this library is a mess. there are books scattered along the ground, some with pages ripped out. a few of the shelves have even been knocked over."),
            new rooms(-1, 5, 3, -1, -1, -1, -1, 5, "the fiction section.", "this section is almost worse than the nonfiction section. the shelves are broken, the books are scattered, and there are even more pages ripped out."),
            new rooms(-1, -1, -1, -1, 4, -1, 3, -1, "the study rooms.", "there are desks and tables placed erratically throughout the area. there is paperwork strewn across the floor."),
            new rooms(-1, -1, 2, -1, -1, -1, -1, -1, "the break room.", "there isn't much to this room. a few tables and a coffee machine that has long since been abandoned."),
            new rooms(2, -1, -1, -1, -1, -1, -1, -1, "the bathroom.", "this room is vile. it is crawling with critters that have seemingly come through the small window high on the wall. there is mold and moss growing from the cracks in the tile. you do not wish to come back to this room."),
            new rooms(-1, -1, -1, 9, -1, -1, 2, -1, "the ARCHIVE ENTRANCE.", "this seems like a foyer of some kind. there are benches here, just like in the lobby. there is an ominous black door to your RIGHT. are you sure you want to continue? once you do, you cannot go back..."),
            new rooms(-1, 11, -1, 10, -1, 12, -1, -1, "the archive hallway.", "there are three rooms. one to the RIGHT, one DOWN, and one DOWN RIGHT. this seems awfully familiar. the doors are once again labelled, but this time, they are all lit. the first door is labelled 'small artifacts.' the second is labelled 'large artifacts.' the third is... 'human. artifacts.' are you sure you want to continue? once you go to human artifacts, you cannot go back..."),
            new rooms(-1, -1, 9, -1, -1, -1, -1, -1, "the small artifacts.", "there is barely any semblance of organization here. there are broken shelves with artifacts strewn about the room. there is broken glass covering the floor. you need to be cautious of your steps."),
            new rooms(9, -1, -1, -1, -1, -1, -1, -1, "the large artifacts.", "there are large glass cases lining the walls, holding suits of armor. some of them are shattered, the armor scattered on the floor with the glass. there are also things like strange tables and even a coffin."),
            new rooms(-1, 14, -1, 13, -1, 15, -1, -1, "the human artifacts.", "once again, there are three rooms: 'bone artifacts,' 'organ artifacts,' and 'current patients.' are you sure you want to continue? if you go to the current patients ward, you cannot go back..."),
            new rooms(-1, -1, 12, -1, -1, -1, -1, -1, "the bone artifacts.", "this room is exactly what you would expect. there are various human bones hanging from the walls, mainly spines. the rest of the bones are scattered across the floor in unorganized piles."),
            new rooms(12, -1, -1, -1, -1, -1, -1, -1, "the organ artifacts.", "this room is disgusting. of course, it look ransacked. there are broken jars everywhere, spilling some sort of liquid onto the ground. the organs that were stored here are lying on the ground. you have to look away."),
            new rooms(-1, 16, -1, -1, -1, -1, -1, -1, "the current patients ward.", "again, this room acts as a foyer. you finally begin to see a faint light from behind the door."),
            new rooms(-1, -1, -1, 17, -1, -1, -1, -1, "the asylum hallway.", "the hallway leads RIGHT. it dimly lit, a few fluorescent lights hanging from the ceiling. there are doors lining the hall as far as the eye can see, but they are all open with the lights off, seemingly unused. all except one, at the end of the hall. it is tightly shut, a sliver of light eminating from under the door."),
            new rooms(-1, -1, -1, -1, -1, -1, -1, -1, "room 073.", "the lights in this room are almost blinding compared to the rest of the building. you look around and see a man hunched over in the corner. he is mumbling something to himself, quiet enough to where you cannot hear him, but you can just make out the words 'dead' and 'sorry.'")

        };
        
        public static int playerPos = 0;

        public static string input = "";
        public static string name = "";

        public static bool hasRun0 = false;
        public static bool hasRun1 = false;
        public static bool hasRun2 = false;
        public static bool hasRun3 = false;
        public static bool hasRun4 = false;
        public static bool hasRun5 = false;
        public static bool hasRun6 = false;
        public static bool hasRun7 = false;
        public static bool hasRun8 = false;
        public static bool hasRun9 = false;
        public static bool hasRun10 = false;

        public static bool foundBones = false;
        public static bool foundDagger = false;

        static void Main(string[] args)
        {
            
            Console.WriteLine("welcome to:");
            Console.WriteLine("the archivist");
            Console.WriteLine("");
            Console.WriteLine("if you wish to quit at any time, please type QUIT.");
            Console.WriteLine("");
            Console.WriteLine("press ENTER to continue.");
            Console.ReadLine();

            while (input != "QUIT")
            {
                findings f = new findings();

                rats rat = new rats();
                bats bat = new bats();
                raccoons raccoon = new raccoons();

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("you have reached " + roomsArray[playerPos].roomName);
                Console.WriteLine("");
                Console.WriteLine(roomsArray[playerPos].roomDesc);
                Console.WriteLine("");

                if (playerPos == 0)
                {
                    while (input != "YES" && input != "NO" && input != "QUIT" && !hasRun0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("do you wish to sit on the bench?");
                        input = Console.ReadLine().ToUpper();

                        if (input == "YES")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you sit on the bench. it is not comfortable in the slightest.");
                            Console.WriteLine("");
                            Console.WriteLine("do you wish to stay longer?");
                            input = Console.ReadLine().ToUpper();

                            if (input == "YES")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("you stay on the bench for a little while longer. the air begins to feel a little thin. you close your eyes. you feel a hand brush against your shoulder. you jolt up and turn around, but there is nothing there. strange. you decide not to sit on any more benches.");
                                Console.WriteLine("");
                                hasRun9 = true;
                            }
                            else if (input == "NO")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("you get up, not wishing to waste more time on trivial bench-sitting.");
                                Console.WriteLine("");
                            }
                            else if (input == "QUIT")
                            {
                                goto credits;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("it's a yes or no question.");
                                Console.WriteLine("");
                            }

                        }
                        else if (input == "NO")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("fine by me.");
                            Console.WriteLine("");
                        }
                        else if (input == "QUIT")
                        {
                            goto credits;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("it's a yes or no question.");
                            Console.WriteLine("");
                        }
                    }
                    hasRun0 = true;
                }

                if (playerPos == 1 && !hasRun1)
                {
                    Console.WriteLine(""); 
                    Console.WriteLine("you have " + f.skeleton(1) + " arm bones!");
                    foundBones = true;
                    Console.WriteLine("");
                    f.flashlight();
                    Console.WriteLine("you found a flashlight!");
                    inventory.Add("flashlight");
                    Console.WriteLine("");
                    hasRun1 = true;
                }

                if (playerPos == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have encountered a rat!");
                    Console.WriteLine("");
                    rat.Run();
                }

                if (playerPos == 3 && !hasRun2)
                {
                    f.page1();
                    Console.WriteLine("");
                    Console.WriteLine("you found a page!");
                    inventory.Add("page1");
                    Console.WriteLine("");
                    hasRun2 = true;
                }

                if (playerPos == 4 && !hasRun3)
                {
                    f.page2();
                    Console.WriteLine("");
                    Console.WriteLine("you found a page!");
                    inventory.Add("page2");
                    Console.WriteLine("");
                    hasRun3 = true;
                }

                if (playerPos == 5 && !hasRun4)
                {
                    f.folder();
                    Console.WriteLine("");
                    Console.WriteLine("you found a folder!");
                    inventory.Add("folder");
                    Console.WriteLine("");
                    hasRun4 = true;
                }

                if (playerPos == 6 && !hasRun5)
                {
                    f.coffee();
                    Console.WriteLine("");
                    Console.WriteLine("you found a coffee!");
                    inventory.Add("coffee");
                    Console.WriteLine("");
                    hasRun5 = true;
                }

                if (playerPos == 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have encountered a bat!");
                    Console.WriteLine("");
                    bat.Run();
                    Console.WriteLine("");
                    Console.WriteLine("you have encountered a raccoon!");
                    Console.WriteLine("");
                    raccoon.Run();
                }

                if (playerPos == 8)
                {
                    while (input != "YES" && input != "NO" && input != "QUIT" && !hasRun6)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("do you wish to sit on the bench?");
                        input = Console.ReadLine().ToUpper();

                        if (input == "YES")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you sit on the bench. it is not comfortable in the slightest.");
                            Console.WriteLine("");
                            Console.WriteLine("do you wish to stay longer?");
                            input = Console.ReadLine().ToUpper();

                            if (input == "YES")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("you stay on the bench for a little while longer. the air begins to feel a little thin. you look up and see a distorted face staring back at you. you rub your eyes and look again, but nothing is there. strange. you decide not to sit on any more benches.");
                                Console.WriteLine("");
                                hasRun10 = true;
                            }
                            else if (input == "NO")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("you get up, not wishing to waste more time on trivial bench-sitting.");
                                Console.WriteLine("");
                            }
                            else if (input == "QUIT")
                            {
                                goto credits;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("it's a yes or no question.");
                                Console.WriteLine("");
                            }

                        }
                        else if (input == "NO")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("fine by me.");
                            Console.WriteLine("");
                        }
                        else if (input == "QUIT")
                        {
                            goto credits;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("it's a yes or no question.");
                            Console.WriteLine("");
                        }
                    }
                    hasRun6 = true;
                }

                if (playerPos == 9)
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have encountered a bat!");
                    Console.WriteLine("");
                    bat.Run();
                }

                if (playerPos == 10 && !hasRun7)
                {
                    f.dagger();
                    Console.WriteLine("");
                    Console.WriteLine("you found a dagger!");
                    foundDagger = true;
                    Console.WriteLine("");
                    hasRun7 = true;
                }

                if (playerPos == 11)
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have encountered a raccoon!");
                    Console.WriteLine("");
                    raccoon.Run();
                }

                if (playerPos == 12)
                {

                }

                if (playerPos == 13 && !hasRun8)
                {
                    f.skull();
                    Console.WriteLine("");
                    Console.WriteLine("you found a skull!");
                    inventory.Add("skull");
                    Console.WriteLine("");
                    hasRun8 = true;
                }

                if (playerPos == 14)
                {

                }

                if (playerPos == 15)
                {

                }

                if (playerPos == 16)
                {

                }

                if (playerPos == 17)
                {
                    Console.WriteLine("");
                    Console.WriteLine("you try to quietly exit the room, but the floor creaks as you step.");
                    Console.WriteLine("the man's head whips around, and you get a good look at his face. his hair is long and greying in some areas. other than that, his hair is a beautiful dark brown.");
                    Console.WriteLine("his hands are thin and veiny, with spindly fingers holding onto his suit vest for dear life. his eyes, though seemingly dead and lifeless, shine an emerald green.");
                    Console.WriteLine("he's wearing glasses. they are thin and round, with a chain on them that goes around his neck.");
                    Console.WriteLine("");

                    while (input != "1" && input != "2" && input != "QUIT")
                    {
                       
                        Console.WriteLine("1. what is your name?");
                        Console.WriteLine("2. why are you here by yourself?");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("he does not answer for a long time. you wait patiently.");
                            Console.WriteLine("");
                            Console.WriteLine("'Gordon. my name is Gordon. what's yours?'");
                            name = Console.ReadLine().ToUpper();
                            Console.WriteLine("");
                            Console.WriteLine("'" + name + " huh? that's a nice name. so, what are you doing here, " + name + "?'");
                            Console.WriteLine("");
                            Console.WriteLine("1. just exploring what i thought was an abandoned building.");
                            Console.WriteLine("2. none of your business.");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("he nods.");
                                Console.WriteLine("");
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("'sorry for asking.'");
                                Console.WriteLine("");
                                Console.WriteLine("he looks away awkwardly.");
                                Console.WriteLine("");
                            }
                            else if (input == "QUIT")
                            {
                                goto credits;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("please choose a number listed.");
                                Console.WriteLine("");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("you ask him what he is doing here all by himself.");
                            Console.WriteLine("");
                            Console.WriteLine("he takes a while to answer. you wait patiently.");
                            Console.WriteLine("");
                            Console.WriteLine("'you see, i was the archivist here. it was not only a library, but a research facility. the doctors would run experiments on their test subjects, and i would archive the results.'");
                            Console.WriteLine("");
                            Console.WriteLine("you listen intently.");
                            Console.WriteLine("");
                            Console.WriteLine("'now, i was not allowed into the testing, so i never found out what happened, but one day, all the subjects went mad. maybe it was because of some crazy serum the doctors were testing, but i'm not sure.'");
                            Console.WriteLine("");
                            Console.WriteLine("'i do know, however, what happened to subjects that did not cooperate...'");
                            Console.WriteLine("");
                            Console.WriteLine("he pauses for a moment.");
                            Console.WriteLine("");
                            Console.WriteLine("'they were...recycled. into artifacts.'");
                            if (inventory.Contains("skull"))
                            {
                                Console.WriteLine("");
                                Console.WriteLine("'i see you have found a remnant of such acts.'");
                                Console.WriteLine("");
                                Console.WriteLine("he motions to the skull you are carrying.");
                                Console.WriteLine("");
                            }
                            Console.WriteLine("'i wanted to stop it. i really did. but...i couldn't. once all the patients were...gone, the scientists were forced to shut the facility down, putting me out of a job. i lost it. i went ballistic on the place, as i'm sure you've seen. i broke things, turned over tables, everything i could do to get my anger out.'");
                            Console.WriteLine("");
                            Console.WriteLine("he pauses, seemingly embarrassed about sharing so much.");
                            Console.WriteLine("");
                            Console.WriteLine("'so...'");
                            Console.WriteLine("");
                            Console.WriteLine("he attempts to change the subject.");
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("he takes a while to answer. you wait patiently.");
                            Console.WriteLine("");
                            Console.WriteLine("'you see, i was the archivist here. it was not only a library, but a research facility. the doctors would run experiments on their test subjects, and i would archive the results.'");
                            Console.WriteLine("");
                            Console.WriteLine("you listen intently.");
                            Console.WriteLine("");
                            Console.WriteLine("'now, i was not allowed into the testing, so i never found out what happened, but one day, all the subjects went mad. maybe it was because of some crazy serum the doctors were testing, but i'm not sure.'");
                            Console.WriteLine("");
                            Console.WriteLine("i do know, however, what happened to subjects that did not cooperate...'");
                            Console.WriteLine("");
                            Console.WriteLine("he pauses for a moment.");
                            Console.WriteLine("");
                            Console.WriteLine("'they were...recycled. into artifacts.'");
                            Console.WriteLine("");
                            if (inventory.Contains("skull"))
                            {
                                Console.WriteLine("");
                                Console.WriteLine("'i see you have found a remnant of such acts.'");
                                Console.WriteLine("");
                                Console.WriteLine("he motions to the skull you are carrying.");
                                Console.WriteLine("");
                            }
                            Console.WriteLine("'i wanted to stop it. i really did. but...i couldn't. once all the patients were...gone, the scientists were forced to shut the facility down, putting me out of a job. i lost it. i went ballistic on the place, as i'm sure you've seen. i broke things, turned over tables, everything i could do to get my anger out.'");
                            Console.WriteLine("");
                            Console.WriteLine("he pauses, seemingly embarrassed about sharing so much.");
                            Console.WriteLine("");
                            Console.WriteLine("'so...'");
                            Console.WriteLine("");
                            Console.WriteLine("he attempts to change the subject.");
                            Console.WriteLine("");
                            Console.WriteLine("'what is your name?'");
                            name = Console.ReadLine().ToUpper();
                            Console.WriteLine("");
                            Console.WriteLine("'" + name + " huh? that's a nice name. my name is Gordon. so, what are you doing here, " + name + "?'");
                            Console.WriteLine("");

                            Console.WriteLine("1. just exploring what i thought was an abandoned building.");
                            Console.WriteLine("2. none of your business.");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("he nods.");
                                Console.WriteLine("");
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("'sorry for asking.'");
                                Console.WriteLine("");
                                Console.WriteLine("he looks away awkwardly.");
                                Console.WriteLine("");
                            }
                            else if (input == "QUIT")
                            {
                                goto credits;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("please choose a number listed.");
                                Console.WriteLine("");
                            }
                        }
                        else if (input == "QUIT")
                        {
                            goto credits;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("please choose a number listed.");
                            Console.WriteLine("");
                        }
                    }
                    if (inventory.Contains("page1") & !inventory.Contains("page2"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Gordon seems to notice the page tucked into your pocket.");
                        Console.WriteLine("");
                        Console.WriteLine("'i see you found a page of my journals. there is another one missing as well. i guess you didn't catch it. that's alright, though. i'll find it eventually.'");
                        Console.WriteLine("");
                    }
                    else if (inventory.Contains("page1") && inventory.Contains("page2"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Gordon seems to notice the pages tucked into your pocket.");
                        Console.WriteLine("");
                        Console.WriteLine("'oh! you found my journal pages. i've been looking for those. thank you.'");
                        Console.WriteLine("");
                    }
                    if (inventory.Contains("folder"))
                    {
                        Console.WriteLine("you remember the folder you picked up from the study rooms. Gordon might know something about it.");
                        Console.WriteLine("");
                        Console.WriteLine("do you ask him about the folder?");
                        input = Console.ReadLine().ToUpper();
                        if (input == "YES")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you show him the folder of strange drawings.");
                            Console.WriteLine("he looks embarrassed.");
                            Console.WriteLine("");
                            Console.WriteLine("'i had a habit of sleep walking for a while. i would get up, go to my desk, and draw, all while i was asleep. my drawings seemed to be some sort of flow of consciousness. all my nightmares, scribbled onto scraps of paper.'");
                            Console.WriteLine("");
                            Console.WriteLine("he pauses for a moment.");
                            Console.WriteLine("");
                            Console.WriteLine("'i have not slept well in a long time.'");
                            Console.WriteLine("");
                        }
                        else if (input == "NO")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("fine by me.");
                            Console.WriteLine("");
                        }
                        else if (input == "QUIT")
                        {
                            goto credits;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("it's a yes or no question.");
                            Console.WriteLine("");
                        }
                    }
                    if (inventory.Contains("coffee"))
                    {
                        Console.WriteLine("Gordon looks tired.");
                        Console.WriteLine("");
                        Console.WriteLine("do you offer him your coffee?");
                        input = Console.ReadLine().ToUpper();
                        if (input == "YES")
                        {
                            Console.WriteLine("you offer Gordon your cup of coffee.");
                            Console.WriteLine("he seems taken aback.");
                            Console.WriteLine("");
                            Console.WriteLine("'for me?'");
                            Console.WriteLine("");
                            Console.WriteLine("you nod.");
                            Console.WriteLine("");
                            Console.WriteLine("'thank you, " + name + ".'");
                        }
                        else if (input == "NO")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you do not offer him the coffee. you are selfish and want it for yourself.");
                            Console.WriteLine("");
                        }
                        else if (input == "QUIT")
                        {
                            goto credits;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("it's a yes or no question.");
                            Console.WriteLine("");
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("there is a prolonged period of complete silence, save for the incessant buzzing of the flourescent lights above.");
                    Console.WriteLine("finally, Gordon speaks.");
                    Console.WriteLine("");
                    Console.WriteLine("'don't laugh, but i think this place might be haunted.'");
                    if (hasRun9 == true || hasRun10 == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("you think back to when you sat on the bench.");
                        Console.WriteLine("");
                        Console.WriteLine("do you tell him what happened?");
                        input = Console.ReadLine().ToUpper();
                        if (input == "YES")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you tell him what happened to you on the bench.");
                            Console.WriteLine("");
                            Console.WriteLine("'that is quite troubling.'");
                            Console.WriteLine("");
                            Console.WriteLine("he thinks for a moment before continuing.");
                            Console.WriteLine("");
                            Console.WriteLine("'i'm not sure what they want, but, if their intentions are...sinister...i implore you to leave at once, before they can hurt you.'");
                            Console.WriteLine("");
                            Console.WriteLine("1. what about you?");
                            Console.WriteLine("2. okay, i'll leave.");
                            input = Console.ReadLine().ToUpper();
                            if (input == "1")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Gordon seems shocked that you even considered him.");
                                Console.WriteLine("");
                                Console.WriteLine("'i'll be fine, " + name + ". i promise.'");
                                Console.WriteLine("");
                                Console.WriteLine("he smiles. it's a sad smile. one that doesn't quite reach his eyes.");
                                Console.WriteLine("");
                                Console.WriteLine("1. okay, i'll leave.");
                                Console.WriteLine("2. what if you come with me?");
                                input = Console.ReadLine().ToUpper();
                                if (input == "1")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("this seems to make Gordon happy.");
                                    Console.WriteLine("");
                                    Console.WriteLine("'good. now hurry. i feel the air getting colder already.'");
                                    Console.WriteLine("");
                                    Console.WriteLine("you turn on your heels and quickly walk away.");
                                    Console.WriteLine("before you exit, you wave goodbye. Gordon smiles another sad sort of smile, waving back weakly.");
                                    Console.WriteLine("");
                                    Console.WriteLine("'it was nice meeting you, " + name + ".'");
                                    Console.WriteLine("");
                                    Console.WriteLine("press ENTER to continue.");
                                    Console.ReadLine();
                                    goto credits;
                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Gordon once again seems shocked at your proposal.");
                                    Console.WriteLine("");
                                    Console.WriteLine("'do you mean that?'");
                                    Console.WriteLine("");
                                    Console.WriteLine("you tell him of course you mean it.");
                                    Console.WriteLine("");
                                    Console.WriteLine("out of all the things you think he might do, you do not expect Gordon to cry.");
                                    Console.WriteLine("");
                                    Console.WriteLine("'i've been trapped here for so long. i thought i would die in here. thank you, " + name + ", oh thank you!'");
                                    Console.WriteLine("");
                                    Console.WriteLine("he runs to you and hugs you. his tall, slender frame wraps around yours. his skin is as cold as it looks, yet his hug is warm.");
                                    Console.WriteLine("");
                                    Console.WriteLine("'let's go, dear friend.'");
                                    Console.WriteLine("");
                                    Console.WriteLine("press ENTER to continue.");
                                    Console.ReadLine();
                                    goto credits;
                                }
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("this seems to make Gordon happy.");
                                Console.WriteLine("");
                                Console.WriteLine("'good. now hurry. i feel the air getting colder already.'");
                                Console.WriteLine("");
                                Console.WriteLine("you turn on your heels and quickly walk away.");
                                Console.WriteLine("before you exit, you wave goodbye. Gordon smiles a sad sort of smile, waving back weakly.");
                                Console.WriteLine("");
                                Console.WriteLine("'it was nice meeting you, " + name + ".'");
                                Console.WriteLine("");
                            }
                            else if (input == "QUIT")
                            {
                                goto credits;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("please choose a number listed.");
                                Console.WriteLine("");
                            }
                        }
                        else if (input == "NO")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("you do not tell him what happened. you are afraid he will think you are crazy.");
                            Console.WriteLine("");
                        }
                        else if (input == "QUIT")
                        {
                            goto credits;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("it's a yes or no question.");
                            Console.WriteLine("");
                        }
                    }
                    else if (!hasRun9 && !hasRun10)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("you ask him why he thinks this to be true.");
                        Console.WriteLine("");
                        Console.WriteLine("'well, for starters, before i locked myself in this room, i heard strange noises coming from the bathroom. i'll admit, i was far too afraid to go in and check.'");
                        Console.WriteLine("");
                        Console.WriteLine("'i have also felt the air go very cold back here in the patient ward, which is where the...recycling...happened. i did some research, before i broke the computers, and everything i read said that the air can go very cold when spirits are around.'");
                        Console.WriteLine("");
                        Console.WriteLine("you nod, agreeing with his reasoning.");
                        Console.WriteLine("");
                        Console.WriteLine("'i'm not sure what they want, but, if their intentions are...sinister...i implore you to leave at once, before they can hurt you.'");
                        Console.WriteLine("");
                        Console.WriteLine("1. what about you?");
                        Console.WriteLine("2. okay, i'll leave.");
                        input = Console.ReadLine().ToUpper();
                        if (input == "1")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Gordon seems shocked that you even considered him.");
                            Console.WriteLine("");
                            Console.WriteLine("'i'll be fine, " + name + ". i promise.'");
                            Console.WriteLine("");
                            Console.WriteLine("he smiles. it's a sad smile. one that doesn't quite reach his eyes.");
                            Console.WriteLine("");
                            Console.WriteLine("1. okay, i'll leave.");
                            Console.WriteLine("2. what if you come with me?");
                            input = Console.ReadLine().ToUpper();
                            if (input == "1")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("this seems to make Gordon happy.");
                                Console.WriteLine("");
                                Console.WriteLine("'good. now hurry. i feel the air getting colder already.'");
                                Console.WriteLine("");
                                Console.WriteLine("you turn on your heels and quickly walk away.");
                                Console.WriteLine("before you exit, you wave goodbye. Gordon smiles another sad sort of smile, waving back weakly.");
                                Console.WriteLine("");
                                Console.WriteLine("'it was nice meeting you, " + name + ".'");
                                Console.WriteLine("");
                                Console.WriteLine("press ENTER to continue.");
                                Console.ReadLine();
                                goto credits;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Gordon once again seems shocked at your proposal.");
                                Console.WriteLine("");
                                Console.WriteLine("'do you mean that?'");
                                Console.WriteLine("");
                                Console.WriteLine("you tell him of course you mean it.");
                                Console.WriteLine("");
                                Console.WriteLine("out of all the things you think he might do, you do not expect Gordon to cry.");
                                Console.WriteLine("");
                                Console.WriteLine("'i've been trapped here for so long. i thought i would die in here. thank you, " + name + ", oh thank you!'");
                                Console.WriteLine("");
                                Console.WriteLine("he runs to you and hugs you. his tall, slender frame wraps around yours. his skin is as cold as it looks, yet his hug is warm.");
                                Console.WriteLine("");
                                Console.WriteLine("'let's go, dear friend.'");
                                Console.WriteLine("");
                                Console.WriteLine("press ENTER to continue.");
                                Console.ReadLine();
                                goto credits;
                            }
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("this seems to make Gordon happy.");
                            Console.WriteLine("");
                            Console.WriteLine("'good. now hurry. i feel the air getting colder already.'");
                            Console.WriteLine("");
                            Console.WriteLine("you turn on your heels and quickly walk away.");
                            Console.WriteLine("before you exit, you wave goodbye. Gordon smiles a sad sort of smile, waving back weakly.");
                            Console.WriteLine("");
                            Console.WriteLine("'it was nice meeting you, " + name + ".'");
                            Console.WriteLine("");
                            Console.WriteLine("press ENTER to continue.");
                            Console.ReadLine();
                            goto credits;
                        }
                        else if (input == "QUIT")
                        {
                            goto credits;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("please choose a number listed.");
                            Console.WriteLine("");
                        }
                    }
                }

                PlayerMove();

            }

         credits:
            Console.Clear();
            Console.WriteLine("thank you for playing:");
            Console.WriteLine("the archivist");
            Console.WriteLine("");
            Console.WriteLine("written and produced by Nikolas Cain");
            Console.WriteLine("");
            Console.WriteLine("story inspired by 'DEVISER' by Harlan Guthrie , 'RED VALLEY' by Orpheus Studio Productions , and 'THE MAGNUS ARCHIVES' by Rusty Quill");
            Console.WriteLine("");
            Console.WriteLine("press ENTER to exit.");
            Console.ReadLine();

        }

        static void PlayerMove()
        {       
            Console.WriteLine("type UP, DOWN, LEFT, RIGHT, UP RIGHT, DOWN RIGHT, UP LEFT, and DOWN LEFT to move. type QUIT to exit the game.");
            input = Console.ReadLine().ToUpper();

            if (input == "UP")
            {
                if (roomsArray[playerPos].up >= 0)
                {
                    playerPos = roomsArray[playerPos].up;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "DOWN")
            {
                if (roomsArray[playerPos].down >= 0)
                {
                    playerPos = roomsArray[playerPos].down;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "LEFT")
            {
                if (roomsArray[playerPos].left >= 0)
                {
                    playerPos = roomsArray[playerPos].left;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "RIGHT")
            {
                if (roomsArray[playerPos].right >= 0)
                {
                    playerPos = roomsArray[playerPos].right;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "UP RIGHT")
            {
                if (roomsArray[playerPos].upRight >= 0)
                {
                    playerPos = roomsArray[playerPos].upRight;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "DOWN RIGHT")
            {
                if (roomsArray[playerPos].downRight >= 0)
                {
                    playerPos = roomsArray[playerPos].downRight;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "UP LEFT")
            {
                if (roomsArray[playerPos].upLeft >= 0)
                {
                    playerPos = roomsArray[playerPos].upLeft;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "DOWN LEFT")
            {
                if (roomsArray[playerPos].downLeft >= 0)
                {
                    playerPos = roomsArray[playerPos].downLeft;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("you have run into the wall. nice going.");
                    Console.WriteLine("");
                    Console.WriteLine("press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            else if (input == "QUIT")
            {
                Console.Clear();
                Console.WriteLine("thank you for playing:");
                Console.WriteLine("the archivist");
                Console.WriteLine("");
                Console.WriteLine("written and produced by Nikolas Cain");
                Console.WriteLine("");
                Console.WriteLine("story inspired by 'DEVISER' by Harlan Guthrie , 'RED VALLEY' by Orpheus Studio Productions , and 'THE MAGNUS ARCHIVES' by Rusty Quill");
                Console.WriteLine("");
                Console.WriteLine("press ENTER to exit.");
                Console.ReadLine();

            }

            else if (input != "QUIT")
            {
                Console.WriteLine("");
                Console.WriteLine("you must choose a direction to travel.");
                Console.WriteLine("");
                Console.WriteLine("press ENTER to continue.");
                Console.ReadLine();
            }
        }
    }
}
