using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssesment
{
    class Program
    {
        static Random random = new Random();
        static int[] numList = new int [100];
       
        static int max = numList.Length -1;
        static int min = 0;
        static bool correct = false;


        //Number Guessing Game
        static void Main(string[] args)
        {
            int p = 1;


            Console.WriteLine("Welcome to the Wumbo Number Gueesser!");
            Console.ReadKey();

            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] = p;
                p++;
                Console.WriteLine(numList[i]);
            }

            Console.ReadKey();
            Console.WriteLine("Have you got a number in mind? \nLemme try to guess it");
            Console.ReadKey();

            string choice = "";

            

            while (choice != "0" || !correct)
            {
                correct = true;
                if (min > max || max < min)
                {
                    Console.WriteLine("You have commited a crime in the world of Wumbo... Begone!");
                    break;
                }
                p = Guess(numList[min], numList[max]);
                Console.WriteLine("Is this your number? \n" + p + "\n1:Yes. 2:Guess Higher. 3: Guess Lower.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("YES!!!!! The Wumbo Number Generator has done it again!! Thank you for" +
                        " playing!!" + " Bye now!");
                    break;
                }
                else if (choice == "2")
                {
                    Console.WriteLine("I must up the number of Wumbo to reach the number... " +
                        "Here goes nothing...");
                    correct = false;
                    GuessHigher(p);

                }
                else if (choice == "3")
                {
                    Console.WriteLine("Too much Wumbo has been used here... sorry sir/madame... " +
                        "lemme try less.");
                    correct = false;
                    GuessLower(p);
                }
                
            }

            Console.ReadKey();
        }

        public static int Guess(int _min, int _max)
        {
            int choice = Program.random.Next(_min, _max);
            return choice;
        }

        public static int GuessHigher(int _min)
        {
            min = _min;
            return min;
        }
        
        public static int GuessLower(int _max)
        {
            max = _max - 1;

            return max;
        }
        

    }
}
