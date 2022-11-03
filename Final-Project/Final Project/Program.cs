using System;
using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args)
    {
        
        int goodendingcount = 0;
        int badendingcount = 0;
        bool FinishedPlaying = false;
        int room = 1; //This keeps track of what room the player is in. 
        string response = ""; //This keeps track of what the player wants to do
        bool anspos1 = false; //keeps the yes/no section tidy
        bool anspos2 = false;
        bool anspos3 = false;
        bool ansneg1 = false;
        bool ansneg2 = false;
        bool ansneg3 = false;
        bool hasKey = false;
        bool seenplaque = false;
        bool badending = false;
        bool goodending = false;
        bool Bep = true;
        bool newgame = true;

        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine("Welcome to the Choose Your Own Adventure Game!");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("");

        Console.WriteLine(" You wake up to find yourself in a weird dungeon or stronghold of some sort, it seems like you should get out of here...");
        
        Console.WriteLine(" type 'see' or 'look' to see what is in a room, 'help' to get more controls, and 'i' to see your inventory!");
        
        Console.WriteLine(" Have Fun! :D");

        //While they are still playing let them type in new responses
       
            
            
            
            
            
            
            while (FinishedPlaying == false)
            {

                if (newgame == true)
                {
                    anspos1 = false; //keeps the yes/no section tidy
                    anspos2 = false;
                    anspos3 = false;
                    ansneg1 = false;
                    ansneg2 = false;
                    ansneg3 = false;
                    hasKey = false;
                    seenplaque = false;
                    badending = false;
                    goodending = false;
                    Bep = true;
                    newgame = false;
                    FinishedPlaying = false;
                }
               
                
                
                



                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                response = Console.ReadLine().ToLower();




                if (response.Equals("help"))
                {
                    Console.WriteLine("Controls: Verbs like: 'use', 'go'/'go to', 'look at' and many more! Remember to use context clues and common sense to figure out a puzzle");
                    Console.WriteLine("Also! remember to use all available controls, espescially 'see'/'look', and use them in every room, they are very important!");
                }
                else if (response.Equals("i"))
                {
                    if (hasKey == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("You have a key");
                    }
                    else if (hasKey == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("your inventory is currently empty");
                    }
                }
                else
                {
                    switch (room)
                    {
                        case 1:




                            switch (response)
                            {
                                case "go forward":
                                case "use door":
                                case "use key":
                                case "use key on door":
                                case "open door":
                                case "unlock door":



                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    if (hasKey == true & newgame == false)
                                    {
                                        Console.WriteLine("You go forward and unlock the door.");

                                        Thread.Sleep(1500);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("You made it out! but... wheres the win screen?");
                                        Thread.Sleep(3000);
                                        Console.Clear();




                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Uh");
                                        Thread.Sleep(4000);
                                        Console.Clear();


                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("hehe....");
                                        Thread.Sleep(4200);
                                        Console.Clear();


                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("HeHE....");
                                        Thread.Sleep(4500);
                                        Console.Clear();


                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("HAhAHAHaAHAAHAhahA");
                                        Thread.Sleep(4500);
                                        Console.Clear();


                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("You didn't think it'd be that easy, did you?");
                                        Thread.Sleep(5000);
                                        Console.Clear();


                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("I'll let you go... ");
                                        Thread.Sleep(4500);
                                        Console.Clear();


                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("for now");
                                        Thread.Sleep(4000);
                                        Console.Clear();

                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("The smell of the outdoors hits you");

                                        room = 3;
                                    }
                                if (hasKey == true & newgame == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("No no, stay in there, we aren't going to do this >:(");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("you are shoved back into the room forcefully by a gust of air");
                                    room = 1;
                                }

                                else if (hasKey == false)
                                {
                                    Console.WriteLine("The door is locked. Look for a key.");
                                }
                                    break;



                                case "go right":
                                case "move right":
                                case "go to the right":
                                case "right":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("You go to the right.");
                                    room = 2;
                                    break;

                                case "see":
                                case "look":

                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("You are in a room with a locked door in front of you and an entryway to the right.");
                                    break;
                                default:
                                    Console.WriteLine("reword that?");
                                    break;
                            }
                            break;
                        case 2:
                            switch (response)
                            {
                                case "see":
                                case "look":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    if (hasKey == false)
                                    {
                                        Console.WriteLine("You are in a room with a key on the floor and an entryway to the left");
                                    }
                                    else if (hasKey == true)
                                    {
                                        Console.WriteLine("You are in a room with the inprint of the key left on the floor from where you took it, and an entryway to the left, where you just came from");
                                    }
                                    break;

                                case "get key":
                                case "pick up key":
                                case "pickup key":
                                case "grab key":
                                case "reach for key":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    if (hasKey == false & newgame == false)
                                    {
                                        Console.WriteLine("You pick up a key");
                                        hasKey = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You look down at the recently disturbed dust where the key just was, then look down at your inventory to see that you already picked up the key... stupid.");
                                    }
                                    break;



                                case "go left":
                                case "move left":
                                case "go to the left":
                                case "go back":
                                case "go backwards":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("You go left.");
                                    room = 1;
                                    break;
                                default:
                                    Console.WriteLine("reword that?");
                                    break;
                            }
                            break;



                        case 3:
                            
                            


                            Console.ForegroundColor = ConsoleColor.Cyan;
                            switch (response)
                            {
                                case "see":
                                case "look":
                                    {
                                        if (seenplaque == false)
                                        {
                                            Console.WriteLine("You see that you are outside, surrounded by a dense line of trees on all sides blocking you into a large space, its not cramped, but you definitely feel claustrophobic, there must be some sort of way to get out of here");
                                            Console.WriteLine("");
                                            Console.WriteLine("Just as you think that, you see one of the trees has a shiny thing on it?");
                                        }
                                        else if (seenplaque == true)
                                        {
                                            Console.WriteLine("looking around, you notice a handful of decent-sized stones on the ground");

                                        }

                                    }
                                    break;
                                case "go to tree":
                                case "go to trees":
                                case "look at tree":
                                case "look at trees":
                                case "look at shiny":
                                case "look at shiny thing":
                                case "use tree":
                                case "use trees":
                                case "use shiny":
                                case "use shiny thing":
                                case "interact with tree":
                                case "interact with trees":
                                case "interact with shiny":
                                case "interact with shiny thing":

                                    {
                                        Console.WriteLine("The plaque reads: Gray, cold and often overlooked. Only prettied by the moss and lichens of the world... or are they? Take a look and find out, and leave no st...");
                                        Console.WriteLine("the rest is weathered away... maybe you should take another look at the area?");
                                        seenplaque = true;


                                    }
                                    break;

                                case "go to rocks":
                                case "look at rocks":
                                case "turn over rocks":
                                case "interact with rocks":
                                case "move rocks":
                                case "pick up rocks":
                                case "pickup rocks":
                                case "use rocks":
                                case "go to rock":
                                case "look at rock":
                                case "turn over rock":
                                case "interact with rock":
                                case "move rock":
                                case "pick up rock":
                                case "pickup rock":
                                case "use rock":
                                case "go to stones":
                                case "look at stones":
                                case "turn over stones":
                                case "interact with stones":
                                case "move stones":
                                case "pick up stones":
                                case "pickup stones":
                                case "use stones":
                                case "go to stone":
                                case "look at stone":
                                case "turn over stone":
                                case "interact with stone":
                                case "move stone":
                                case "pick up stone":
                                case "pickup stone":
                                case "use stone":
                                    {
                                        Console.WriteLine("looking at the stones you see that there are inscriptions on three of them, do you want to look at them closer?   yes/no");
                                    }
                                    break;
                                case "yes":
                                    {
                                        if (anspos1 == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Are You Sure?");
                                            anspos1 = true;

                                        }
                                        else if (anspos1 == true & anspos2 == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Ok :D you turn over the three stones and notice that they weren't inscryptions, but an intricate map on how to get out of here! Follow it?   yes/no");
                                            anspos2 = true;

                                        }
                                        else if (anspos1 == true & anspos2 == true & anspos3 == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Phew, ok, for a second there I was worried you were going to be stubborn, He was counting on that... heh, anyways");
                                            anspos3 = true;
                                            goodending = true;
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("Press 'Enter' to continue");
                                        room = 5;

                                        }
                                    }
                                    break;
                                case "no":
                                    {
                                        if (ansneg1 == false & ansneg2 == false & ansneg3 == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("wuss");
                                            ansneg1 = true;

                                        }
                                        else if (ansneg1 == true & ansneg2 == false & ansneg3 == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("hey man, uhh, can you work with me here? I'm trying to help you! Just say 'yes'");
                                            ansneg2 = true;
                                        }

                                        else if (ansneg1 == true & ansneg2 == true & ansneg3 == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("*sigh* i tried");
                                            ansneg3 = true;
                                            badending = true;
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("Press 'Enter' to continue");
                                        room = 4;
                                        }



                                    }
                                    break;

                                default:
                                    Console.WriteLine("reword that?");
                                    break;
                            }
                            break;


                        case 4:
                            if (badending == true)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Now you've done it... ");
                                Console.WriteLine("You should have listened");
                                Thread.Sleep(4000);
                                Console.Clear();
                                Thread.Sleep(1500);
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(1500);
                                Console.WriteLine("you find yourself in a mysterious area, a strange dark mist sits about the place and you have a bad feeling");
                                Thread.Sleep(4000);
                                Console.WriteLine("...");
                                Thread.Sleep(1000);
                                Console.WriteLine("wandering aimlessly about, you find yourself in an open area, with a strange stone in the middle");
                                Thread.Sleep(4000);
                                Console.WriteLine("...");
                                Thread.Sleep(1000);
                                Console.WriteLine("stepping closer, you see it is a grave...");
                                Thread.Sleep(1500);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("YOUR grave");
                                Thread.Sleep(1000);
                                Console.WriteLine("It reads: RIP");
                                Console.WriteLine("");
                                Console.WriteLine("Player:");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("The loser who wouldn't play along");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(1000);
                                Console.WriteLine("You LOSE!");
                            
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Press 'Enter' to continue");
                            badendingcount++;

                                room = 8;
                            }

                            else if (goodending == true)
                            {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                                Thread.Sleep(1000);
                                Console.WriteLine("You WIN!");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Press 'Enter' to continue");
                            goodendingcount++;
                                room = 8;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Thread.Sleep(1000);
                                Console.WriteLine("Ummm, you're not supposed to be here, please restart the game ");
                            }
                            break;
                        default:
                            Console.WriteLine("reword that?");
                            break;
                        case 5:
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(750);
                                Console.WriteLine("Alright, lets see...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2500);
                                Console.WriteLine("Ummm, Ah! I see!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("So, basically...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("Um...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("hmm...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("how do I put this...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("uhhhhh");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("Ok, sooo...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("*clears throat*");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("you are going to have to return to the first room you found yourself in...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(3250);
                                Console.WriteLine("So, yeah, there is a pressure plate in there that will let you escape");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2250);
                                Console.WriteLine("I'm kinda suprised you didnt accidently step on it... heh");

                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Press 'Enter' to continue");
                            room = 6;
                            }
                            break;

                        case 6:
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Thread.Sleep(1250);
                                Console.WriteLine("You find yourself back in the first room, you don't recall walking here, but, it probably doesnt matter");
                                room = 7;

                            }
                            break;

                        case 7:
                            {
                                switch (response)
                                {
                                    case "see":
                                    case "look":
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("You are in the room with the once locked door in front of you and an entryway to the right, there is also a pressure plate somewhere in here");
                                            Console.WriteLine("you get the idea that you should 'double check' the area");
                                        }

                                        break;

                                    case "double check":
                                        {
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("...");




                                        Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("after searching for a very long time, you find a slightly raised stone to the left of the doorway");
                                        }
                                        break;

                                case "go right":
                                case "move right":
                                case "go to the right":
                                case "right":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("You go to the right.");
                                    room = 2;
                                    break;

                                case "go left":
                                case "move left":
                                case "go to the left":
                                case "go back":
                                case "go backwards":
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("You go left.");
                                    room = 1;
                                    break;

                                case "go forward":
                                case "use door":
                                case "go through door":
                                    {
                                        hasKey = true;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("No no, stay in there, we aren't going to do this >:(");
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("you are shoved back into the room forcefully by a gust of air");
                                        room = 1;
                                    }
                                    

                                    break;

                                    case "push pressure plate":
                                    case "press pressure plate":
                                    case "use pressure plate":
                                    case "step on pressure plate":
                                    case "push":
                                    case "press":
                                    case "use":
                                    case "step on":
                                    case "push stone":
                                    case "press stone":
                                    case "use stone":
                                    case "step on stone":


                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("pushing the pressure plate, you hear a deep rumbling");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Nice! Out here a bunch of trees seperated! I dunno how that works, but we shouldn't question it");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("Alright, you should be able to 'escape' now, hopefully He doesn't try to stop you here");
                                        }
                                        break;

                                    case "escape":
                                        {
                                            Console.Clear();
                                            Thread.Sleep(4250);
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("walking back out to the clearing, you find that there is, in fact, a large trail where trees used to be");
                                            Thread.Sleep(4250);
                                            Console.WriteLine("getting closer to the trail, you hear a familiar voice:");
                                            Thread.Sleep(3250);
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("STOP!");
                                            Thread.Sleep(4250);
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("Stopping only for a second, you realize that you are still in full control of your body, He has no power over you now");
                                            Thread.Sleep(4250);
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("witnessing the fact that He has no power now, you feel a smug smile spread on your face as you practically skip out of that place turning around for the breifest of moments to watch as the clearing closes off again");
                                            Thread.Sleep(4250);
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Now, where is the nearest town?");
                                            
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("Press 'Enter' to continue");

                                            room = 4;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("reword that?");
                                        break;

                                }
                            }
                            break;
                        case 8:
                            {
                                while (Bep == true)
                                {
                                    Console.WriteLine("Would you like to play again? You have gotten the good ending " + goodendingcount + " time(s) and the bad ending " + badendingcount + " time(s).        yes/no");
                                    Bep = false;
                                }
                                switch (response)
                                {
                                    case "yes":
                                        {
                                            
                                            Console.WriteLine("you close your eyes, and when you open them again you find yourself in a familiar place");
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            newgame = true;
                                            
                                            room = 1;
                                        }
                                        break;
                                    case "no":
                                        {
                                            FinishedPlaying = true;
                                        }
                                        break;
                                }
                            }
                            break;
                    }//Room Switch
                }//Help/Inv else
            } //Game Finished Loop
       



            
        Console.WriteLine("Congratulations on finishing the game!");
    }

}