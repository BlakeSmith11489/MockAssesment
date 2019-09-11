using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssesment
{
    class Program
    {
        Random random = new Random();
        static int[] numList = new int [100];
        static int p = 1;
        static int max = numList.Length -1;
        static int min = 0;
        static bool correct = false;


        //Number Guessing Game
        static void Main(string[] args)
        {
            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] = p;
                p++;
                Console.WriteLine(numList[i]);
            }


            Console.WriteLine("Welcom to the Wumbo Number Gueesser!");
            Console.ReadKey();
            Console.WriteLine("Have you got a number in mind? \nLemme try to guess it");

            string choice = "";
            while (choice != "0" || !correct)
            {
                correct = true;

                if (choice == "1")
                {

                }
                if (choice == "2")
                {

                }
                if (choice == "3")
                {

                }
            }


            Console.ReadKey();
        }
    }
}
