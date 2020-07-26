using System;
using System.Text;

namespace csharp
{
    class SmallPaths
    {   
        public static int p1, p2, p3;
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Hello Adventurer, welcome to Small Paths. A small slightly educational yet smiley game about Mental Health!");
                Console.WriteLine("Are you ready to begin?");
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hi! " + name);
                Console.WriteLine("Ready to begin? 1 or 2?");
                int choiceUno = Int32.Parse(Console.ReadLine());

                switch (choiceUno) {
                    case 1: 
                    if (choiceUno == 1 ) {
                        Console.WriteLine("Alright cool!");
                        Console.WriteLine("Let's continue with this: ");
                    }
                    break;
                    case 2: 
                    if (choiceUno == 2) {
                        Console.WriteLine("Alrighty then, See you next time!");
                        System.Environment.Exit(1);
                    }
                    break;

                    default: 
                    Console.WriteLine("Please enter a number.");
                    continue;
                }
                Console.WriteLine("Please pick a person " + name);
                Console.WriteLine("1.) Person 1");
                Console.WriteLine("2.) Person 2");
                Console.WriteLine("3.) Person 3");
                int knowledgeChoice = Int32.Parse(Console.ReadLine());

                switch (knowledgeChoice) {

                    case 1: 
                    if (knowledgeChoice == 1) {
                        Console.WriteLine("Say Hello to Ether! They want to talk to you!");
                    } 
                    break;

                    case 2: 
                    if (knowledgeChoice == 2) {
                        Console.WriteLine("Hey hey hoh! Say hello to Johnathan!");
                    }
                    break;
                    case 3: 
                    if (knowledgeChoice == 3) {
                        Console.WriteLine("Say hi to Roger! He's waving at you over there!");
                    }
                    break;
                    default: 
                    Console.WriteLine("Please pick a person!");
                    break;
                }
                /* how the fuck do I write this*/
                /*Stack overflow come thru*/
                while (knowledgeChoice == 1) {
                    Console.WriteLine("Ah, so I see you've picked me. Alright " + name);
                    Console.WriteLine("Pee pee poo poo");
                }
            }
        }
    }
}
