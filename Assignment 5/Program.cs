using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ZombieApocalypse();
        }

        private static void ZombieApocalypse()
        {
            string introText = "############################################################################## \n";
            introText += "****************************************************************************** \n";
            introText += "Welcome to the Year 2017! \n\n";
            introText += "It's been two years since the deadly virus went airbourne, which infected the \n";
            introText += "human race/population and turned them into blood-thriving creatures. \n\n";
            introText += "Your are currently in T.O, and you hear rumors spreading around that \n";
            introText += "three safe quarantine zones are established in the U.S, where you'll \n";
            introText += "be safe and well protected. \n";
            introText += "****************************************************************************** \n";
            introText += "############################################################################## \n";
            Console.WriteLine(introText);

            int selection = 0;

            while (selection != 4)
            {
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +      Which quarantine zone do you want         +");
                Console.WriteLine("             +                  to visit?                     +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Los Angeles                                 +");
                Console.WriteLine("             + 2) Alanta                                      +");
                Console.WriteLine("             + 3) New York City                               +");
                Console.WriteLine("             + 4) I don't want go! (quit)                     +");
                Console.WriteLine("             **************************************************");
                Console.WriteLine();
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        LosAngeles();
                        break;
                    case 2:
                        Atlanta();
                        break;
                    case 3:
                        NewYorkCity();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void GameIntro()
        {
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +      Which quarantine zone do you want         +");
                Console.WriteLine("             +                  to visit?                     +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Los Angeles                                 +");
                Console.WriteLine("             + 2) Alanta                                      +");
                Console.WriteLine("             + 3) New York City                               +");
                Console.WriteLine("             + 4) I don't want go! (quit)                     +");
                Console.WriteLine("             **************************************************");
                Console.WriteLine();
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        LosAngeles();
                        break;
                    case 2:
                        Atlanta();
                        break;
                    case 3:
                        NewYorkCity();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        private static void LosAngeles()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +          How do you plan to reach              +");
                Console.WriteLine("             +              your destination?                 +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Get on a plane                              +");
                Console.WriteLine("             + 2) Fetch a ride                                +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.WriteLine();
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        Plane();
                        break;
                    case 2:
                        FetchRide();
                        break;
                    case 3:
                        Console.Clear();
                        GameIntro();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void Plane()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +           Which route or path do you           +");
                Console.WriteLine("             +                 wish to take?                  +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Route A                                     +");
                Console.WriteLine("             + 2) Route B                                     +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        RouteToLA_Plane_PathA();
                        break;
                    case 2:
                        RouteToLA_Plane_PathB();
                        break;
                    case 3:
                        LosAngeles();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void RouteToLA_Plane_PathA()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "Six hours later... The plane is in the air, flying to Los Angeles,\n";
            bodyText += "suddenly starts to descend. \n\n";
            bodyText += "It comes to the pilot's attention that the fuel guage on the plane \n";
            bodyText += "was displaying false reading. \n\n";
            bodyText += "A few minutes later, the plane plunges quickly and makes a hard landing \n";
            bodyText += "on top of the alps in Colorado Springs. \n\n";
            bodyText += "Killing everyone on board, you desperately tried to scream for help, \n";
            bodyText += "yet no came to your aid as you slowly bleeded out to death! :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void RouteToLA_Plane_PathB()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "Five hours later... The plane successfully landed near the quarantine zone :) \n\n";
            bodyText += "As everyone slowly got off the plane, out of nowhere, a horde of zombines \n";
            bodyText += "pinned down your location and flank your position. \n\n";
            bodyText += "No one surived this deadly assault/massacre, including you, as they carved \n";
            bodyText += "inside your flesh and gnawed your organs! \n\n";
            bodyText += "The camp was overrun a week ago; hence, this mission was a bust! :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void FetchRide()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +           Which route or path do you           +");
                Console.WriteLine("             +                 wish to take?                  +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Route A                                     +");
                Console.WriteLine("             + 2) Route B                                     +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        RouteToLA_FetchRide_PathA();
                        break;
                    case 2:
                        RouteToLA_FetchRide_PathB();
                        break;
                    case 3:
                        LosAngeles();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void RouteToLA_FetchRide_PathA()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "A few hours of driving, the vechile approaches a roadblock. \n\n";
            bodyText += "As the vehicle came to a halt, a group of people move towards \n";
            bodyText += "the vehicle, took our their firing arm and pointed it towards the \n";
            bodyText += "the everyone inside. \n\n";
            bodyText += "The leader of the pack, then instructed everyone to get out of the, \n";
            bodyText += "our else he'll shoot everyone point blank! \n\n";
            bodyText += "Everyone, including you, got of the vehicle and walked away from it. \n\n";
            bodyText += "After everyone got out, the hijakers stormed inside the vehicle and \n";
            bodyText += "and immediately took off! :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void RouteToLA_FetchRide_PathB()
        {
            Console.Clear();
            string bodyText = "****************************************************************************** \n";
            bodyText += "A few hours of travel, along with a group of strangers, the driver \n";
            bodyText += "stops the vehicle on the side of a road. \n\n";
            bodyText += "Everyone was kindly instructed to get off the vechile to scavenge for food \n";
            bodyText += "and other important supplies. \n\n";
            bodyText += "No luck with finding anything resourceful, you decided to go back. \n\n";
            bodyText += "As you made it back, the vehicle was gone and no one was around, except you! :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void Atlanta()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +          How do you plan to reach              +");
                Console.WriteLine("             +              your destination?                 +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Get on a helicopter                         +");
                Console.WriteLine("             + 2) Travel with a military convoy               +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.WriteLine();
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        Helicopter();
                        break;
                    case 2:
                        MilitaryConvoy();
                        break;
                    case 3:
                        Console.Clear();
                        GameIntro();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void Helicopter()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +           Which route or path do you           +");
                Console.WriteLine("             +                 wish to take?                  +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Route A                                     +");
                Console.WriteLine("             + 2) Route B                                     +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        RouteToATL_Helicopter_PathA();
                        break;
                    case 2:
                        RouteToATL_Helicopter_PathB();
                        break;
                    case 3:
                        Atlanta();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void RouteToATL_Helicopter_PathA()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "After five hours of flying, the helicopter unexpectedly started to shudder. \n\n";
            bodyText += "A few seconds later, a cloud of black smoke appeared from the top of the helicoper. \n\n";
            bodyText += "The propellors on the helicopter immediately stopped spinning, and the helicopter \n";
            bodyText += "As a result, the helicopter, rotatingly, descended and hit the ground hard. \n\n";
            bodyText += "No one survived the crash, including you, because the helicopter promply \n";
            bodyText += "exploded due to gasoline ignition :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            GameOver();
        }
        private static void RouteToATL_Helicopter_PathB()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "After three hours of flying, the helicopter safely landed near the camp. \n \n";
            bodyText += "A group of people from the safe camp slowly casually approached the helicoper. \n\n";
            bodyText += "They welcomed everyone, and insisted the entire group to follow them to camp. \n\n";
            bodyText += "As soon as you approached the front gate of the camp, you felt like\n";
            bodyText += "something's unusual about the camp. \n\n";
            bodyText += "Yes, that's right! You walking into hostile territory! \n";
            bodyText += "This camp is not just recruiting survivors so they can live at free will, \n";
            bodyText += "they are, in fact, brought here as hostages, so they can devour them \n";
            bodyText += "for dinner! :O \n\n";
            bodyText += "Muhahahahahahahahahahahahahahaha....! >:) \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void MilitaryConvoy()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +           Which route or path do you           +");
                Console.WriteLine("             +                 wish to take?                  +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Route A                                     +");
                Console.WriteLine("             + 2) Route B                                     +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        RouteToATL_MilitaryConvoy_PathA();
                        break;
                    case 2:
                        RouteToATL_MilitaryConvoy_PathB();
                        break;
                    case 3:
                        Atlanta();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void RouteToATL_MilitaryConvoy_PathA()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "After hours of travelling, the military decided to stop at a near-by \n";
            bodyText += "fuel service station to refill their vechicles. \n\n";
            bodyText += "As they started to pump fuel into their vechiles, a loud alarm started \n";
            bodyText += "to go off from the fuel service station. \n\n";
            bodyText += "The sound was so loud, and it attracted a swarm of zombies near-by. \n\n";
            bodyText += "Within a few minutes, zombies had overrun the whole block, and a huge blast \n";
            bodyText += "from the fuel pump erupted and the whole block went in flames, killing you \n";
            bodyText += "and everyone within the block radius! :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void RouteToATL_MilitaryConvoy_PathB()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "While enroute to Atlanta, heavy gusts of wind was causing all sorts of \n";
            bodyText += "chaos on the road, so the military pulled over to observe the situation. \n\n";
            bodyText += "A few minutes later, the military personnels swiftly got in the vehicles. \n\n";
            bodyText += "Out of a sudden, you witness a terrifying F5 Tornado closing in, and on your \n";
            bodyText += "position. \n\n";
            bodyText += "Just within a few seconds, the tornado ruptured everything in its path, and \n";
            bodyText += "along with it, you and everyone aboard! :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void NewYorkCity()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +          How do you plan to reach              +");
                Console.WriteLine("             +              your destination?                 +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Travel on foot                              +");
                Console.WriteLine("             + 2) Ride a horse                                +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.WriteLine();
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        OnFoot();
                        break;
                    case 2:
                        Horse();
                        break;
                    case 3:
                        Console.Clear();
                        GameIntro();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void OnFoot()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +           Which route or path do you           +");
                Console.WriteLine("             +                 wish to take?                  +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Route A                                     +");
                Console.WriteLine("             + 2) Route B                                     +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1:
                        RouteToNYC_OnFoot_PathA();
                        break;
                    case 2:
                        RouteToNYC_OnFoot_PathB();
                        break;
                    case 3:
                        NewYorkCity();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void RouteToNYC_OnFoot_PathA()
        {
            Console.Clear();
            string bodyText = "****************************************************************************** \n";
            bodyText += "After several days of travelling on foot, you come across a stranded town. \n\n";
            bodyText += "You then walk into a store to seek for food and other supplies. \n\n";
            bodyText += "As soon as you depart the store, a group of ruthless militias spot you, and \n";
            bodyText += "and ambush you! \n\n";
            bodyText += "You immediately hit the floor hard, and then standing over you, \n";
            bodyText += "They yell, 'GOD BLESS AMERICA', and then shoot you right between the eye, \n";
            bodyText += "murdering you without giving you mercy! :( \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void RouteToNYC_OnFoot_PathB()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "After a month of travelling on foot, you run out food and water! \n\n";
            bodyText += "Countless days of walking had dehydrated you and made you starve to death! \n\n";
            bodyText += "Thus, you're in no fit to travel no more, and die shortly from starvation \n";
            bodyText += "and sickness! :( \n";
            bodyText += "****************************************************************************** \n";

            Thread.Sleep(5000);
            GameOver();
        }
        private static void Horse()
        {
            Console.Clear();
            int selection = 0;

            while (selection != 4)
            {
                Console.Write("\n\n\n\n\n\n");
                Console.WriteLine("             ++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("             +           Which route or path do you           +");
                Console.WriteLine("             +                 wish to take?                  +");
                Console.WriteLine("             --------------------------------------------------");
                Console.WriteLine("             + 1) Route A                                     +");
                Console.WriteLine("             + 2) Route B                                     +");
                Console.WriteLine("             + 3) Go up a level                               +");
                Console.WriteLine("             + 4) I no longer wish to go! (quit)              +");
                Console.WriteLine("             **************************************************");
                Console.Write("                    Please make your decision (1 to 4): ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    selection = 0;
                }
                switch (selection)
                {
                    case 1:
                        RouteToNYC_Horse_PathA();
                        break;
                    case 2:
                        RouteToNYC_Horse_PathB();
                        break;
                    case 3:
                        NewYorkCity();
                        break;
                    case 4:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("******************************************************************************");
                        Console.WriteLine("      Sorry, that is an incorrect option/selection, please try again!");
                        Console.WriteLine("******************************************************************************");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine("Press or hit any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        private static void RouteToNYC_Horse_PathA()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "Rushing towards to New York City on a horse, you shortly arrived at the \n";
            bodyText += "Niagara Falls border to U.S.A. :) \n\n";
            bodyText += "However, the bridge doesn't appear to be in good condition, as it is \n";
            bodyText += "damaged and partially wrecked. \n\n";
            bodyText += "Despite the wreckage, the bridge still seems to be merged and intact. \n\n ";
            bodyText += "After giving it a thought, you decided to cross the border and race \n";
            bodyText += "towareds the other end. \n\n";
            bodyText += "Almost half way there, the ground begun to shift out of place, and then \n";
            bodyText += "the bridge unexpectedly collapsed, sending you and your horsey, diving \n";
            bodyText += "in the the water! :( \n\n";
            bodyText += "Enjoy sleeping/swimming with the fishes! >:) \n";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
            GameOver();
        }
        private static void RouteToNYC_Horse_PathB()
        {
            Console.Clear();

            string bodyText = "****************************************************************************** \n";
            bodyText += "After a week of travelling on a horse, you finally arrived at the same camp! :)\n\n";
            bodyText += "Everything seems fine about the place, as you got off your horse. \n\n";
            bodyText += "A committee of survivors head towards you to greet and welcome you inside. \n\n";
            bodyText += "As you walked inside, a member from the welcome committe informs you that \n";
            bodyText += "this is the only existing safe quarantine zone in the U.S, and that the \n";
            bodyText += "other locations in Los Angeles and Atlanta went dark. \n\n";
            bodyText += "Welcome home, you made it. Cheers! :)";
            bodyText += "****************************************************************************** \n";
            Console.WriteLine(bodyText);

            Thread.Sleep(5000);
        }
        private static void GameOver()
        {
            Console.WriteLine();
            Console.WriteLine("##############################################################################");
            Console.WriteLine("                                   Game Over!                                 ");
            Console.WriteLine("##############################################################################");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine("Press or hit any key to try another option...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
